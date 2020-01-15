using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Translator
{
    /// <summary>
    /// Summary description for Translator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Translator : WebService
    {

        [WebMethod]
        public string Translate(string input)
        {
            DictionaryClass.AddWords();

            var words = input.Split(' ');
            var transalte = DictionaryClass.myDictionary.Where(a => a.Key == input);

            string c="";
            foreach (var item in transalte)
            {
               c = item.Value.ToString();
            }
            return c;
        }
    }
}
