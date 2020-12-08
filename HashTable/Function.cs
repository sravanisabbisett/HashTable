using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Function
    {
        //Dictionary for storing  count of the strings provided
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        /// <summary>
        ///Display the count the of words provided.
        /// </summary>
        /// <param name="hash">The hash.</param>
        public void FrequencyOfWord(MyMapNode<int, string> hash)
        {
            for (int key = 0; key < hash.size; key++)
            {
                frequency.TryAdd(hash.Get(key).ToLower(), 0);
                frequency[hash.Get(key).ToLower()]++;
            }
            foreach (KeyValuePair<string, int> item in frequency)
            {
                Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
            }
        }
    }
}
