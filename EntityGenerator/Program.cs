using System;
using System.Collections.Generic;

namespace EntityGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Type> list = new List<Type>();
            list.Add(typeof(PersonBase));

            List<string> folders = new List<string>();
            folders.Add("Generated");
            folders.Add("Templates");

            Dictionary<string, string> values = new Dictionary<string, string>();
            foreach(var l in list)
            {
                string name = l.Name;
                string vName = name.Substring(0, 1).ToLower();

                values.Add(name, vName);
            }

            Dictionary<string, string> extensions = new Dictionary<string, string>();
            extensions.Add("EntityFramework", "6.2.0");

            Generator.contextGenerate(list, "Person", "PersonDb", "EntityGenerator", "Template", "cs");
            Generator.extensionGenerator("EntityGenerator", "TemplateEntityExtensionNETCore", "cs", "Exe", "netcoreapp2.2", folders, extensions);
            Generator.programGenerator("TemplateSaveProgram", "cs", "EntityGenerator", "PersonContext", values);
        }
    }
}
