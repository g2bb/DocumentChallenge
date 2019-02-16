using System;
using System.IO;

namespace Document {
    class Program {
        static void Main() {
            bool running = true;
            Console.WriteLine("Document");
            while (running == true) {
                Console.WriteLine("Please enter name for the document:");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter the content for the document:");
                string content = Console.ReadLine();

                if (!name.EndsWith(".txt")) {
                    name += ".txt";
                }

                StreamWriter sw = null;
                try {
                    sw = new StreamWriter(name);
                    sw.WriteLine(content);
                    Console.WriteLine("name" + name + " was saved successfully. The document has " + content.Length + " characters.");
                } catch (Exception e) {
                    Console.WriteLine(e);
                } finally {
                    if(sw != null) {
                        sw.Close();
                    }
                }
                Console.WriteLine("Do you want to create a nother document? (Y/N)");
                running = (Console.ReadLine().ToLower()) == "Y";
            }
        }
    }
}
