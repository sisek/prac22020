using System;

namespace Problems
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Prefix(string input){

            if (input == null)
                return null;
            
            //get the length
            int length = input.Length;

            //get the number of words, ignoring empty entries
             string[] splitInput = input.Split(" ");

            int words = 0;
            for(int i = 0; i < splitInput.Length; i++)
            {
                if (!string.IsNullOrEmpty(splitInput[i]))
                    words++;
            }    

            //combine into one output
            string output = length + "," + words + ":" + input;

            //return output
            return output;
        }

    }

}
