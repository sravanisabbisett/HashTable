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

        /// <summary>
        /// Removes the specified hash.
        /// </summary>
        /// <param name="hash">The hash.</param>
        /// <param name="word">The word.</param>
        public void Remove(MyMapNode<int, string> hash, string word)
        {
            //Loop iterates across the hash to compare key with the word 
            //if passed word matches with the key then hash.remove removes that value
            for (int key = 0; key < hash.size; key++)
            {
                if (hash.Get(key).Equals(word))
                {
                    hash.Remove(key);
                    Console.WriteLine($"Removed {word} from paragraph");
                }
            }
        }
    }
}
