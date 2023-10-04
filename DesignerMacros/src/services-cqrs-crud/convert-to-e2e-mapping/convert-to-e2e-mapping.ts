/// <reference path="../../../typings/elementmacro.context.api.d.ts" />

if (element.isMapped() && element.specialization == "Command") {
    convertCommand(element);
} else if (element.isMapped() && element.specialization == "Query") {
    convertQuery(element);
}

function convertCommand(command: IElementApi) {
    let target = command.getMapping().getElement();
    let entity = target.getParent("Class") ?? target;
    if (command.getName().startsWith("Create")) {
        let action = createAssociation("Create Entity Action", command.id, target.id);
        let mapping = action.createMapping(command.id, entity.id);
        mapping.addMappedEnd([command.id], [target.id]);
        mapContract(command, [command.id], [target.id], mapping);
    } else if (command.getName().startsWith("Delete")) {
        let action = createAssociation("Delete Entity Action", command.id, entity.id);
        let mapping = action.createMapping(command.id, entity.id);
        
        let idField = command.getChildren("DTO-Field").find(x => (x.isMapped() && x.getMapping().getElement().hasStereotype("PrimaryKey")) || (x.getName() == "Id" || x.getName() == `${entity.getName()}Id`));
        let entityPk = entity.getChildren("Attribute").find(x => x.hasStereotype("Primary Key"));
        if (idField && entityPk) {
            mapping.addMappedEnd([idField.id], [entityPk.id]);
        }

        mapContract(command, [command.id], [target.id], mapping);
    } else if (command.isMapped()) {
        let action = createAssociation("Update Entity Action", command.id, target.id);

        // Query Entity Mapping
        let queryMapping = action.createMapping(command.id, entity.id, "25f25af9-c38b-4053-9474-b0fabe9d7ea7"); 
        let idField = command.getChildren("DTO-Field").find(x => (x.isMapped() && x.getMapping().getElement().hasStereotype("PrimaryKey")) || (x.getName() == "Id" || x.getName() == `${entity.getName()}Id`));
        let entityPk = entity.getChildren("Attribute").find(x => x.hasStereotype("Primary Key"));
        if (idField && entityPk) {
            queryMapping.addMappedEnd([idField.id], [entityPk.id]);
        }
        // Update Entity Mapping
        let updateMapping = action.createMapping(command.id, entity.id, "01721b1a-a85d-4320-a5cd-8bd39247196a"); 
        if (target.id != entity.id) {
            updateMapping.addMappedEnd([command.id], [target.id]);
        }
        mapContract(command, [command.id], [target.id], updateMapping);
    }
}

function convertQuery(query: IElementApi) {
    let entity = query.getMapping().getElement();
    let action = createAssociation("Query Entity Action", query.id, entity.id);
    if (query.typeReference.getIsCollection()) {
        action.typeReference.setIsCollection(true);
    }
    let mapping = action.createMapping(query.id, entity.id);
    mapContract(query, [query.id], [entity.id], mapping);
}

function mapContract(dto: MacroApi.Context.IElementApi, sourcePath: string[], targetPathIds: string[], mapping: MacroApi.Context.IElementToElementMappingApi): void {
    console.log("mapContract: " + dto.getName())
    dto.getChildren("DTO-Field").filter(x => x.isMapped() && !(dto.specialization == "Command" && x.getMapping().getElement().hasStereotype("Primary Key"))).forEach(field => {
        if (field.typeReference.getType().specialization != "DTO" || field.typeReference.getIsCollection()) {
            mapping.addMappedEnd(sourcePath.concat([field.id]), targetPathIds.concat(field.getMapping().getPath().map(x => x.id)))
        }
        if (field.typeReference.getType().specialization == "DTO") {
            mapContract(field.typeReference.getType(), sourcePath.concat([field.id]), targetPathIds.concat(field.getMapping().getPath().map(x => x.id)), mapping);
        }
        field.clearMapping();
    })
    dto.clearMapping();
}