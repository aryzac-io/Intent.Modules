using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.CSharp.Builder;

namespace Intent.Modules.Common.CSharp.Builder;

public class CSharpInterfaceField : CSharpField
{
    public CSharpInterfaceField(string type, string name) : base(type, name)
    {
    }
}

public class CSharpInterfaceProperty : CSharpProperty
{
    public CSharpInterfaceProperty(string type, string name) : base(type, name, null)
    {
    }

    public override string GetText(string indentation)
    {
        return $@"{(!XmlComments.IsEmpty() ? $@"{XmlComments.ToString(indentation)}
" : string.Empty)}{indentation}{Type} {Name} {{ {Getter}{(!IsReadOnly ? $" {Setter}" : string.Empty)} }}{(InitialValue != null ? $" = {InitialValue};" : string.Empty)}";
    }
}

public class CSharpInterface : CSharpDeclaration<CSharpInterface>
{
    public CSharpInterface(string name)
    {
        Name = name.ToCSharpIdentifier();
    }
    public string Name { get; private set; }
    public string AccessModifier { get; private set; } = "public ";
    public IList<string> Interfaces { get; set; } = new List<string>();
    public IList<CSharpInterfaceField> Fields { get; set; } = new List<CSharpInterfaceField>();
    public IList<CSharpInterfaceProperty> Properties { get; set; } = new List<CSharpInterfaceProperty>();
    public IList<CSharpInterfaceMethod> Methods { get; set; } = new List<CSharpInterfaceMethod>();


    public CSharpInterface ExtendsInterface(string type)
    {
        Interfaces.Add(type);
        return this;
    }

    public CSharpInterface ImplementsInterfaces(IEnumerable<string> types)
    {
        foreach (var type in types) 
            Interfaces.Add(type);

        return this;
    }

    public CSharpInterface AddField(string type, string name, Action<CSharpInterfaceField> configure = null)
    {
        var field = new CSharpInterfaceField(type, name);
        Fields.Add(field);
        configure?.Invoke(field);
        return this;
    }

    public CSharpInterface AddProperty(string type, string name, Action<CSharpInterfaceProperty> configure = null)
    {
        var property = new CSharpInterfaceProperty(type, name);
        Properties.Add(property);
        configure?.Invoke(property);
        return this;
    }

    public CSharpInterface InsertProperty(int index, string type, string name, Action<CSharpInterfaceProperty> configure = null)
    {
        var property = new CSharpInterfaceProperty(type, name);
        Properties.Insert(index, property);
        configure?.Invoke(property);
        return this;
    }

    public CSharpInterface AddMethod(string returnType, string name, Action<CSharpInterfaceMethod> configure = null)
    {
        return InsertMethod(Methods.Count, returnType, name, configure);
    }

    public CSharpInterface InsertMethod(int index, string returnType, string name, Action<CSharpInterfaceMethod> configure = null)
    {
        var method = new CSharpInterfaceMethod(returnType, name);
        Methods.Insert(index, method);
        configure?.Invoke(method);
        return this;
    }

    public CSharpInterface Internal()
    {
        AccessModifier = "internal ";
        return this;
    }
    public CSharpInterface InternalProtected()
    {
        AccessModifier = "internal protected ";
        return this;
    }

    public CSharpInterface Protected()
    {
        AccessModifier = "protected ";
        return this;
    }
    public CSharpInterface Private()
    {
        AccessModifier = "private ";
        return this;
    }
    public CSharpInterface Partial()
    {
        IsPartial = true;
        return this;
    }

    public bool IsPartial { get; set; }

    public override string ToString()
    {
        return ToString("");
    }

    public string ToString(string indentation)
    {
        return $@"{GetAttributes(indentation)}{indentation}{AccessModifier}{(IsPartial ? "partial " : "")}interface {Name}{GetBaseTypes()}
{indentation}{{{GetMembers($"{indentation}    ")}
{indentation}}}";
    }

    private string GetBaseTypes()
    {
        var types = new List<string>();
        foreach (var @interface in Interfaces)
        {
            types.Add(@interface);
        }

        return types.Any() ? $" : {string.Join(", ", types)}" : "";
    }

    private string GetMembers(string indentation)
    {
        var members = new List<string>();

        members.AddRange(Fields.Select(x => x.ToString(indentation)));
        members.AddRange(Properties.Select(x => x.GetText(indentation)));
        members.AddRange(Methods.Select(x => x.ToString(indentation)));

        return !members.Any() ? "" : $@"
{string.Join($@"

", members)}";
    }
}