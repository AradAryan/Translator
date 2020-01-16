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
        #region Translate Function
        /// <summary>
        /// Translate Input String
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [WebMethod]
        public string Translate(string input)
        {
            DictionaryClass.Fill();
            DictionaryClass.AddWord("welcome", "خوش آمدید");
            string output = "";
            var words = input.Split(' ');
            foreach (var item in words)
            {
                var translate =
                    DictionaryClass.myDictionary.Where(search => string.Compare
                    (strA: search.Key, ignoreCase: true, strB: item) == 0).FirstOrDefault();

                if (translate.Value != null)
                    output += translate.Value + " ";
                else
                    output += " _ ";
            }
            return output;
        }
        #endregion
    }
}
