using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Translator
{
    public static class DictionaryClass
    {
        public static Dictionary<string, string> myDictionary = null;

        public static void Fill()
        {
            myDictionary = new Dictionary<string, string>();
            myDictionary.Add("my", "من");
            myDictionary.Add("is", "هست");
            myDictionary.Add("name", "اسم");
            myDictionary.Add("hi", "سلام");
            myDictionary.Add("work", "کار کردن");
            myDictionary.Add("a", "یک");
            myDictionary.Add("book", "کتاب");
            myDictionary.Add("and", "و");
        }

        public static void AddWord(string engWord, string persianWord)
        {
            myDictionary.Add(engWord, persianWord);
        }
    }
}