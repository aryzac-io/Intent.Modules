using System;
using System.Collections.Generic;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: DefaultIntentManaged(Mode.Fully, Targets = Targets.Usings)]
[assembly:IntentTemplate("Intent.ModuleBuilder.Java.Templates.JavaFileStringInterpolationTemplate",Version= "1.0")]

namespace ModuleBuilders.Templates.Java.JavaSingleFileStringInter
{
    [IntentManaged(Mode.Fully, Body = Mode.Merge)]
    public partial class JavaSingleFileStringInterTemplate    {
        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public override string TransformText()
        {
            return $@"
package {Package};

public class {ClassName} {{{string.Join(Environment.NewLine, GetMembers())}
}}
";
        }

        private IEnumerable<string> GetMembers()
        {
            var members = new List<string>();

            // example: adding a constructor
            members.Add($@"
    public {ClassName}() {{
    }}");
            return members;
        }
    }
}