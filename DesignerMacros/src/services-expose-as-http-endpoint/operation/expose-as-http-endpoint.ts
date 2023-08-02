/// <reference path="../common/on-expose-functions.ts" />

/**
 * Used by Intent.Modules\Modules\Intent.Metadata.WebApi
 *
 * Source code here:
 * https://github.com/IntentArchitect/Intent.Modules/blob/master/DesignerMacros/src/services-expose-as-http-endpoint/operation/expose-as-http-endpoint.ts
 */

function exposeAsHttpEndPoint(element: MacroApi.Context.IElementApi): void{

    let httpServiceSettingsId = "c29224ec-d473-4b95-ad4a-ec55c676c4fd"; // from WebApi module

    if (!element.getParent().hasStereotype(httpServiceSettingsId)) {
        element.getParent().addStereotype(httpServiceSettingsId);

        let serviceBaseName = removeSuffix(element.getParent().getName(), "Service");
        element.getParent().getStereotype(httpServiceSettingsId).getProperty("Route").setValue(`api/${toKebabCase(serviceBaseName)}`)
    }

    applyHttpSettingsToOperations(element);
}

function applyHttpSettingsToOperations(operation) {
    let httpSettingsId = "b4581ed2-42ec-4ae2-83dd-dcdd5f0837b6"; // from WebApi module
    let parameterSettingsId = "d01df110-1208-4af8-a913-92a49d219552"; // from WebApi module

    if (!operation.hasStereotype(httpSettingsId)) {
        operation.addStereotype(httpSettingsId);
    }
    let httpSettings = operation.getStereotype(httpSettingsId);
    if (operation.getName().startsWith("Create")) {
        httpSettings.getProperty("Verb").setValue("POST");
        httpSettings.getProperty("Route").setValue(``)
    } else if (operation.getName().startsWith("Update")) {
        httpSettings.getProperty("Verb").setValue("PUT");
        httpSettings.getProperty("Route").setValue(`${(operation.getChildren().some(x => x.getName().toLowerCase() == "id") ? `{id}` : "")}`)
    } else if (operation.getName().startsWith("Delete")) {
        httpSettings.getProperty("Verb").setValue("DELETE");
        httpSettings.getProperty("Route").setValue(`${(operation.getChildren().some(x => x.getName().toLowerCase() == "id") ? `{id}` : "")}`)
    } else if (operation.getName().startsWith("Get") || operation.getName().startsWith("Find") || operation.getName().startsWith("Lookup")) {
        httpSettings.getProperty("Verb").setValue("GET");
        httpSettings.getProperty("Route").setValue(`${(operation.getChildren().some(x => x.getName().toLowerCase() == "id") ? `{id}` : "")}`)
    } else if (operation.typeReference.getType() != null) {
        httpSettings.getProperty("Verb").setValue("GET");
        httpSettings.getProperty("Route").setValue(`${toKebabCase(operation.getName())}${(operation.getChildren().some(x => x.getName().toLowerCase() == "id") ? `/{id}` : "")}`)
    } else {
        httpSettings.getProperty("Verb").setValue("POST");
        httpSettings.getProperty("Route").setValue(`${toKebabCase(operation.getName())}`)
    }

    operation.getChildren("Parameter").forEach(parameter => {
        if (!parameter.hasStereotype(parameterSettingsId)) {
            parameter.addStereotype(parameterSettingsId);
        }
    });
}

exposeAsHttpEndPoint(element);