using System.IO;

namespace classes{
    public class File 
    {
        public void WriteFile(string text){

            

            Console.WriteLine("What is the file name you would like to choose? Enter .txt at the end");
            string _fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
    // You can add text to the file with the WriteLine method
            outputFile.WriteLine(text);
    
    // You can use the $ and include variables just like with Console.WriteLine
            
        
            }
        }   

        public void LoadFile(){
            Console.WriteLine("What is the desired filename to Load?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
                
            }
            
            
        }
    }
}