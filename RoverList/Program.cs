using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("rock");
            list.Add("dock");
            list.Add("sock");
            list.Add("lock");
            list.Add("pock");
            list.Add("jock");
            list.Add("mock");
            list.Add("shock");
            list.Add("crock");
            list.Add("mice");
            list.Add("rat");
            list.Add("block");
            list.Add("cat");
            list.Add("bat");
            list.Add("pat");
            list.Add("rack");
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            Console.WriteLine("Input a word");
            String word = "";
            while(word != "done")
            {
                if(word == "done")
                {
                    break;
                }
                else 
                { 
                list.Add(word);
                word = Console.ReadLine();
                }
            }
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list
            Console.WriteLine("Input a word");
            word = "";
            while (word != "done")
            {
                if (word == "done")
                {
                    break;
                }
                else
                {
                    list.Add(0, word);
                    word = Console.ReadLine();
                }
            }
            list.ListNodes();
            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            for(int i = list.Count - 1; i > 0; i--)
            {
                int length = list.ElementAt(i).Length;
                
                if (length % 2 != 0)
                {
                list.RemoveAt(i);
                }

            }
            list.ListNodes();
            // TODO:  Clear the list
            // TODO:  Print out the list
            list.Clear();
            list.ListNodes();

        }
    }
}
