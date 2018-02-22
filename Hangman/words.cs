using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class words
    {
        List<string> OptionList = new List<string>()
        { "watermelon", "apple", "cucumber", "doll", "football", "soccer", "couch", "carrot", "animal", "elephant", "computer", "hiking", "jeans", "shirt", "telephone",
        "wallet", "church", "candy", "water", "pizza", "hotdog", "firework", "baseball", "table", "spoon", "flipflops", "kangaroo", "america", "australia", "germany", "fishing",
        "musket", "rifle", "samurai", "boxing", "backpack", "escalator", "elevator", "shopping", "beautiful", "dolphin", "rainbow", "president", "shotgun", "forest", "desert",
        "whiskey", "picture", "pillow", "blanket", "guitar", "piano", "tree", "teacup", "boiling", "stovetop", "oven", "coconut", "pineapple", "airplane", "firetruck"};


       public string deal()

        {
            Shuffle(OptionList);
            string NumOne = OptionList[0];
            OptionList.RemoveAt(0);
            return NumOne;
            
        }
       
            public static void Shuffle(List<string> list)
            {
                int n = list.Count;
                Random rnd = new Random();
                while (n > 1)
                {
                    int k = (rnd.Next(0, n) % n);
                    n--;
                    string value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            } 

        }


    }
    

    



