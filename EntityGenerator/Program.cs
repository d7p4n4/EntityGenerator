using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace EntityGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            var csc = new CSharpCodeProvider();
            var cc = csc.CreateCompiler();
            CompilerParameters cp = new CompilerParameters();

            cp.ReferencedAssemblies.Add("mscorlib.dll");
            cp.ReferencedAssemblies.Add("System.dll");
            StringBuilder sb = new StringBuilder();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"d:\Server\Visual_studio\GeneratedClasses\GeneratedClasses\PersonPersistentPreProcessed.cs");
            while ((line = file.ReadLine()) != null)
            {
                sb.Append(line);
                counter++;
            }

            // The string can contain any valid c# code
            // "results" will usually contain very detailed error messages
            var results = csc.CompileAssemblyFromSource(cp, sb.ToString());
            System.Reflection.Assembly _assembly = results.CompiledAssembly;
            Type[] _types = _assembly.GetTypes();
            Type eType = _assembly.GetType("Foo.MyClass");

            file.Close();

            List<Type> list = new List<Type>();
            list.Add(eType);

            List<string> folders = new List<string>();
            folders.Add("Generated");
            folders.Add("Templates");
            folders.Add("SourceClass");

            Dictionary<string, string> values = new Dictionary<string, string>();
            foreach(var l in list)
            {
                string name = l.Name;
                string vName = name.Substring(0, 1).ToLower();

                values.Add(name, vName);
            }
            /*
            Dictionary<string, string> extensions = new Dictionary<string, string>();
            extensions.Add("EntityFramework", "6.2.0");
            */
            Generator.contextGenerate(list, "TestClass", "TestDb", "EntityGenerator", "Template", "cs");
            /*Generator.extensionGenerator("EntityGenerator", "TemplateEntityExtensionNETCore", "cs", "Exe", "netcoreapp2.2", folders, extensions);
            Generator.programGenerator("TemplateSaveProgram", "cs", "EntityGenerator", "TestClassContext", values);

            Generator.generateEntityMethods("TemplateEntityMethods", "cs", "EntityGenerator", typeof(TestClassContext), list);
        */
        }
    }
}
