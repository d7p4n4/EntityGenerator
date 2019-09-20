using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntityGenerator
{
    class Generator
    {
        public static void contextGenerate(List<Type> classes, string className, string baseName, string namespaceName, string fileName, string languageExtension)
        {
            string[] text = readIn(fileName + "Context", languageExtension);
            string replaced = "";
            string newLine = "";

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("#classes#"))
                {
                    foreach (var c in classes)
                    {
                        newLine = newLine + text[i + 1].Replace("#classesName#", c.Name).Replace("#tableName#", c.Name + "s") + "\n";
                        newLine = newLine + text[i + 2] + "\n";
                    }
                    replaced = replaced + newLine + "\n";
                    

                    i = i + 3;
                }

                replaced = replaced + text[i] + "\n";
            }
            replaced = replaced.Replace("#className#", className).Replace("#baseName#", baseName).Replace("#namespaceName#", namespaceName);

            writeOut(replaced, className + "Context", languageExtension);
        }

        public static void extensionGenerator(string namespaceName, string fileName, string languageExtension, string outputType, string targetFramework, List<string> folders, Dictionary<string, string> extensions)
        {
            string[] text = readIn(fileName, languageExtension);
            string replaced = "";
            string newLine = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("#folders#"))
                {
                    newLine = newLine + text[i + 1] + "\n";
                    foreach (var folder in folders)
                    {
                        newLine = newLine + text[i + 2].Replace("#folderName#", folder) + "\n";
                        
                    }
                    newLine = newLine + text[i + 3] + "\n";
                    replaced = replaced + newLine + "\n";
                    newLine = "";

                    i = i + 4;
                }
                else if (text[i].Equals("#packageReferences#"))
                {
                    newLine = newLine + text[i + 1] + "\n";
                    foreach (var e in extensions)
                    {
                        newLine = newLine + text[i + 2].Replace("#packageName#", e.Key).Replace("#version#", e.Value) + "\n";

                    }
                    newLine = newLine + text[i + 3] + "\n";
                    replaced = replaced + newLine + "\n";
                    newLine = "";

                    i = i + 4;
                }

                replaced = replaced + text[i] + "\n";
            }
            replaced = replaced.Replace("#outputType#", outputType).Replace("#targetFramework#", targetFramework);

            writeOut(replaced, namespaceName, languageExtension + "proj");
        }

        public static void programGenerator(string fileName, string languageExtension, string namespaceName, string classContextName, Dictionary<string, string> values)
        {
            string[] text = readIn(fileName, languageExtension);
            string replaced = "";
            string newLine = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("#values#"))
                {
                    foreach(var v in values)
                    {
                        newLine = newLine + text[i + 1].Replace("#valueName#", v.Value).Replace("#className#", v.Key) + "\n";
                    }
                    replaced = replaced + newLine;
                    newLine = "";

                    i = i + 2;
                }
                else if (text[i].Equals("#adds#"))
                {
                    foreach (var v in values)
                    {
                        newLine = newLine + text[i + 1].Replace("#valueName#", v.Value).Replace("#className#", v.Key) + "\n";
                    }
                    replaced = replaced + newLine;
                    newLine = "";

                    i = i + 2;
                }
                replaced = replaced + text[i] + "\n";
            }
            replaced = replaced.Replace("#namespaceName#", namespaceName).Replace("#classContextName#", classContextName);

            writeOut(replaced, "SaveTest", languageExtension);
        }

        public static string[] readIn(string fileName, string languageExtension)
        {

            string textFile = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Templates\\", fileName + "." + languageExtension + "T");

            string[] text = File.ReadAllLines(textFile);

            return text;


        }

        public static void writeOut(string text, string fileName, string languageExtension)
        {
            System.IO.File.WriteAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Generated\\" + fileName + "." + languageExtension), text);

        }
    }
}
