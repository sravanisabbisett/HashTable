using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            Function function = new Function();
            //Adds details to 
            //uc1
            /* hash.Add(0, "To");
             hash.Add(1, "be");
             hash.Add(2, "or");
             hash.Add(3, "not");
             hash.Add(4, "to");
             hash.Add(5, "be");
             //Calls frequencyOfWord method 
             function.FrequencyOfWord(hash);*/
            //UC2
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //Split converts paragraph  into array of sub strings
            string[] para = paragraph.Split(" ");
            int key = 0;
            //Loop iterates on paragraph and adds key and value of each substing
            //To hash
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            //Calls Frequency of word method to print word count
            function.FrequencyOfWord(hash);
            Console.ReadKey();
        }
    }
}
