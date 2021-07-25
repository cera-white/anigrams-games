using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnigramsProductionsV2.Models
{
    public class LanguageGeneratorViewModel
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string WordText { get; set; }
        public List<WordViewModel> Words { get; set; }
        public List<LanguageSymbolViewModel> VowelSymbols { get; set; }
        public List<LanguageSymbolViewModel> ConsonantSymbols { get; set; }
    }
}