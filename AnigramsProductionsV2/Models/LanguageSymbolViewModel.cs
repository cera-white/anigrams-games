using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnigramsProductionsV2.Models
{
    public class LanguageSymbolViewModel
    {
        public int LanguageSymbolID { get; set; }
        public int LanguageID { get; set; }
        public string Symbol { get; set; }
        public string Examples { get; set; }
    }
}