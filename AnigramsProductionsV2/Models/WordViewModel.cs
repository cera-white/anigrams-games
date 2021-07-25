using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnigramsProductionsV2.Models
{
    public class WordViewModel
    {
        public string Word { get; set; }
        public string Phonetic { get; set; }
        public string English { get; set; }
        public WordGender Gender { get; set; }
        public PartOfSpeech Type { get; set; }
    }
}