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
        public string Translate(string word)
        {
            var temp = DictionaryClass.myDictionary.Values;
            var b = DictionaryClass.myDictionary.Where(a => a.Key == word);
            
            return b.ToString(); ;
        }
    }
}
