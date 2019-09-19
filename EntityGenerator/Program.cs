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

            Dictionary<string, string> extensions = new Dictionary<string, string>();
            extensions.Add("EntityFramework", "6.2.0");

            Generator.contextGenerate(list, "Person", "PersonDb", "EntityGenerator", "Template", "cs");
            Generator.extensionGenerator("EntityGenerator", "TemplateEntityExtensionNETCore", "cs", "Exe", "netcoreapp2.2", folders, extensions);
        }
    }
}
