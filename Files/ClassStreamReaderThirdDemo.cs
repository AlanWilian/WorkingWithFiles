using System;
using System.IO;

namespace Files {
    class ClassStreamReaderThirdDemo {


        public void streamReaderDemo() {
            string path = @"c:\temp\file1.txt";
            try {
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }

}
}
