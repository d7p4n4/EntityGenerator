using System;
using System.Text;
using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;
using System.CodeDom.Compiler;

namespace EntityGenerator
{
    public class ReadLines
    {
        public static Type readIn() {
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

            return eType;
        }
    }
}
