using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnigramsProductionsV2.EF;
using AnigramsProductionsV2.Models;

namespace AnigramsProductionsV2.Controllers
{
    public class GeneratorController : Controller
    {
        private AnigramsEntities db = new AnigramsEntities();
        private Random rnd = new Random();

        // GET: Generator
        public ActionResult Index()
        {
            var model = new LanguageGeneratorViewModel();

            #region Word List
            model.WordText = @"a determiner
actor noun
adult noun
after preposition
afternoon noun
air noun
airport noun
alive adjective
and conjunction
animal noun
apartment noun
apple noun
arm noun
army noun
art noun
artist noun
attack noun
author noun
Autumn season
baby noun
backwards adverb
back noun
bad adjective
bag noun
ball noun
banana noun
band noun
bank noun
bar noun
bathroom noun
beach noun
beard noun
beat verb
beautiful adjective
because conjunction
bed noun
bedroom noun
beef noun
beer noun
bend verb
beverage noun
bicycle noun
big adjective
bill noun
billion number
bird noun
black adjective
blind adjective
blood noun
blue adjective
boat noun
body noun
bone noun
book noun
bottle noun
bottom adjective
box noun
boy noun
brain noun
bread noun
break verb
breakfast noun
bridge noun
brother noun
brown adjective
build verb
building noun
burn verb
but conjunction
bus noun
buy verb
cake noun
call verb
camera noun
camp noun
car noun
card noun
carry verb
cat noun
catch verb
ceiling noun
cell phone noun
centimeter measurement
chair noun
cheap adjective
cheese noun
chicken noun
child noun
church noun
circle noun
city noun
clay noun
clean adjective
clean verb
clock noun
close verb
clothing noun
club noun
coat noun
coffee noun
cold adjective
color noun
computer noun
consonant noun
contract noun
cook verb
cool adjective
copper noun
corn noun
corner noun
count verb
country noun
court noun
cow noun
crowd noun
cry verb
cup noun
curved adjective
cut verb
dance verb
dark adjective
date noun
daughter noun
day noun
dead adjective
deaf adjective
death noun
deep adjective
diamond noun
die verb
dig verb
dinner noun
direction noun
dirty adjective
disease noun
doctor noun
dog noun
dollar noun
door noun
dot noun
down adverb
draw verb
dream verb
dream noun
dress noun
drink verb
drink noun
drive verb
drug noun
dry adjective
dust noun
ear noun
Earth noun
east adverb
eat verb
edge noun
egg noun
eight number
election noun
energy noun
engine noun
ethnicity noun
evening noun
every determiner
exercise verb
expensive adjective
explode verb
eye noun
face noun
fall verb 
family noun
famous adjective
fan noun
farm noun
fast adjective
father noun
feed verb
female adjective
fight verb
find verb
finger noun
fire noun
fish noun
five number
flat adjective
floor noun
flower noun
fly verb
follow verb
food noun
foot noun
foot measurement
for conjunction
forest noun
fork noun
four number
friend noun
front noun
game noun
garden noun
gasoline noun
gender noun
gift noun
girl noun
glass noun
go verb
gold noun
good adjective
grandfather noun
grandmother noun
grass noun
gray adjective
green adjective
ground noun
grow verb
gun noun
hair noun
half measurement
hand noun
hang verb
happy adjective
hard adjective
hat noun
he pronoun
head noun
healthy adjective
hear verb
heart noun
heat noun
heavy adjective
her pronoun
high adjective
hill noun
him pronoun
hole noun
horse noun
hospital noun
hot adjective
hotel noun
hour measurement
house noun
human noun
hundred number
husband noun
I pronoun
ice noun
if conjunction
image noun
in preposition
inch measurement
injury noun
inside preposition
instrument noun,
island noun
it pronoun
job noun
juice noun
jump verb
key noun
kill verb
kilogram measurement
king noun
kiss verb
kitchen noun
knee noun
knife noun
lake noun
lamp noun
laptop noun
laugh verb
lawyer noun
leaf noun
learn verb
left adjective 
leg noun
lemon noun 
letter noun
library noun
lie verb
lift verb
light noun
light adjective
lightweight adjective
lip noun
listen verb
location noun
lock verb
long adjective
loose adjective
lose verb
loud adjective
love verb
low adjective
lunch noun
magazine noun
male adjective
man noun
manager noun
many determiner
map noun
market noun
marriage noun
marry verb
material noun
me pronoun
mean adjective
medicine noun
melt verb
metal noun
meter measurement
milk noun
million number
mine pronoun
minute measurement
money noun
month measurement
moon noun
morning noun
mother noun
mountain noun
mouse noun
mouth noun
movie noun
murder verb
music noun
narrow adjective
nature noun
neck noun
needle noun
neighbor noun
network noun
new adjective
newspaper noun
nice adjective
night noun
nine number
no adverb
north adverb
nose noun
note noun
nuclear adjective
ocean noun
office noun
oil noun
old adjective
on preposition
one number
open verb
or conjunction
orange adjective
orange noun
outside preposition
page noun
pain noun
paint verb
pants noun
paper noun
parent noun
park noun
pass verb
patient noun
pattern noun
pay verb
peace noun
pen noun
pencil noun
person noun
photograph noun
piece noun
pig noun
pink adjective
plane noun
plant noun
plant verb
plastic noun
plate noun
play verb
player noun
pocket noun
poison noun
police noun
pool noun
poor adjective
pork noun
pound measurement
pray verb
president noun
price noun
priest noun
prison noun
program verb
pull verb
push verb
queen noun
quiet adjective
race verb
radio noun
rain noun
red adjective
religion noun
reporter noun
restaurant noun
rice noun
rich adjective
right adjective
ring noun
river noun
roof noun
room noun
root noun
run verb
sad adjective
salt noun
sand noun
school noun
science noun
screen noun
sea noun
season noun
second measurement
secretary noun
see verb
seed noun
sell verb
seven number
sex noun
shake verb
shallow adjective
she pronoun
ship noun
shirt noun
shoes noun
shoot verb
short adjective
shoulder noun
sick adjective
side noun
sign noun
sign verb
silver noun
sing verb
sister noun
sit verb
six number
skin noun
skirt noun
sky noun
sleep verb
slow adjective
small adjective
smell verb
smile verb
snow noun
soap noun
soft adjective
soil noun
soldier noun
son noun
song noun
sound noun
soup noun
south adverb
space noun
speak verb
spoon noun
sport noun
Spring season
square noun
stain noun
stand verb
star noun
stir verb
stone noun
stop verb
store noun
straight adjective
street noun
strong adjective
student noun
sugar noun
suit noun
Summer season
sun noun
sweat verb
swim verb
table noun
tall adjective
taste verb
tea noun
teach verb
teacher noun
team noun
teardrop noun
technology noun
telephone noun
television noun
temperature noun
ten number
the determiner
theater noun
them pronoun
they pronoun
thick adjective
thin adjective
think verb
this determiner
those determiner
thousand number
three number
throw verb
ticket noun
tight adjective
time noun
tire noun
to preposition
toe noun
tongue noun
tool noun
tooth noun
top adjective
touch verb
town noun
station noun
train noun
transportation noun
tree noun
truck noun
T-shirt noun
turn verb
two number
ugly adjective
university noun
up adverb
valley noun
victim noun
voice noun
vowel noun
waiter noun
wake verb
walk verb
wall noun
war noun
warm adjective
wash verb
watch verb
water noun
wave noun
we pronoun
weak adjective
wear verb
wedding noun
week measurement
weight noun
west adverb
wet adjective
when conjunction
white adjective
wide adjective
wife noun
win verb
wind noun
window noun
wine noun
wing noun
Winter season
with preposition
woman noun
wood noun
work verb
world noun
write verb
yard noun
year measurement
yellow adjective
yes adverb
you pronoun
yours pronoun
young adjective";
            #endregion

            ViewBag.Languages = db.GenLanguages.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LanguageGeneratorViewModel model)
        {
            model.LanguageName = db.GenLanguages.Find(model.LanguageID).Name;
            model.VowelSymbols = BuildSymbolChart(model.LanguageID, true);
            model.ConsonantSymbols = BuildSymbolChart(model.LanguageID, false);

            model.Words = GenerateWords(model.LanguageID, model.WordText);

            return View("Results", model);
        }

        public ActionResult Results(LanguageGeneratorViewModel model)
        {
            return View(model);
        }

        private List<LanguageSymbolViewModel> BuildSymbolChart(int languageId, bool isVowel)
        {
            var symbols = new List<LanguageSymbolViewModel>();

            foreach (var item in db.GenLanguageSymbols.Where(x => x.LanguageID == languageId && x.GenSymbol.IsVowel == isVowel))
            {
                symbols.Add(new LanguageSymbolViewModel()
                {
                    LanguageSymbolID = item.LanguageSymbolID,
                    LanguageID = item.LanguageID,
                    Symbol = item.GenSymbol.Code,
                    Examples = item.Examples
                });
            };

            return symbols;
        }

        private List<WordViewModel> GenerateWords(int languageId, string wordText)
        {
            var words = new List<WordViewModel>();
            var isGendered = db.GenLanguages.Find(languageId).Gendered;
            var hasNeuter = db.GenSuffixes.Any(x => x.LanguageID == languageId && x.Gender == "N");

            foreach (var item in wordText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                PartOfSpeech partOfSpeech;
                WordGender gender = isGendered ? (hasNeuter ? (WordGender)rnd.Next(0, 3) : (WordGender)rnd.Next(0, 2)) : WordGender.Neuter;
                int syllables = rnd.Next(1, 5);
                var wordSymbols = BuildWordSymbols(languageId, gender, syllables);

                words.Add(new WordViewModel()
                {
                    Word = item.Split(' ')[0],
                    Type = Enum.TryParse(item.Split(' ')[1], true, out partOfSpeech) ? partOfSpeech : PartOfSpeech.Other,
                    Gender = gender,
                    Phonetic = string.Join(string.Empty, wordSymbols.Select(x => x.Code)),
                    English = string.Join(string.Empty, wordSymbols.Select(x => x.English))
                });
            }

            return words;
        }

        private List<GenSymbol> BuildWordSymbols(int languageId, WordGender gender, int syllables)
        {
            List<GenSymbol> wordSymbols = new List<GenSymbol>();
            var symbols = db.GenLanguageSymbols.Where(x => x.LanguageID == languageId);
            var vowels = symbols.Where(x => x.GenSymbol.IsVowel == true);
            var consonants = symbols.Where(x => x.GenSymbol.IsVowel == false && x.GenSymbol.IsSeparator == false);
            var separators = symbols.Where(x => x.GenSymbol.IsSeparator == true);
            string genderString;
            switch (gender)
            {
                case WordGender.Masculine:
                    genderString = "M";
                    break;
                case WordGender.Feminine:
                    genderString = "F";
                    break;
                case WordGender.Neuter:
                    genderString = "N";
                    break;
                default:
                    genderString = "N";
                    break;
            }
            var suffixes = db.GenSuffixes.Where(x => x.LanguageID == languageId && x.Gender == genderString);
            int lastSyllableIndex = syllables;

            //50% chance of adding primary stress at the beginning
            if (rnd.Next(0, 2) == 1)
            {
                wordSymbols.Add(separators.FirstOrDefault(x => x.SymbolID == 168).GenSymbol);
            }

            for (int i = 1; i <= syllables; i++)
            {
                int currentIndex = i;

                if (currentIndex == lastSyllableIndex)
                {
                    //last syllable - use suffix
                    if (wordSymbols.Count > 0 && !wordSymbols[wordSymbols.Count - 1].IsVowel)
                    {
                        //last added was consonant - Suffix
                        var suffix = suffixes.OrderBy(x => Guid.NewGuid()).FirstOrDefault().Phonetic.ToArray();

                        wordSymbols = BreakSuffixIntoSymbols(wordSymbols, symbols, suffix);
                    }
                    else
                    {
                        ////last added was vowel - C+Suffix
                        //wordSymbols.Add(vowels.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);
                        //var suffix = suffixes.OrderBy(x => Guid.NewGuid()).FirstOrDefault().Phonetic.ToArray();

                        //wordSymbols = BreakSuffixIntoSymbols(wordSymbols, symbols, suffix);
                    }
                }//end if last syllable
                else
                {
                    if (wordSymbols.Count > 0 && !wordSymbols[wordSymbols.Count - 1].IsVowel)
                    {
                        //last added was consonant - V, VC
                        wordSymbols.Add(vowels.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);

                        if (rnd.Next(0, 2) == 1)
                        {
                            wordSymbols.Add(consonants.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);
                        }
                    }
                    else
                    {
                        //last added was vowel - CV, CVC
                        wordSymbols.Add(consonants.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);
                        wordSymbols.Add(vowels.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);

                        if (rnd.Next(0, 2) == 1)
                        {
                            wordSymbols.Add(consonants.OrderBy(x => Guid.NewGuid()).FirstOrDefault().GenSymbol);
                        }
                    }
                    //add separator
                    wordSymbols = GetSeparator(wordSymbols, separators);
                }
            }//end for

            return wordSymbols;
        }

        private List<GenSymbol> BreakSuffixIntoSymbols(List<GenSymbol> wordSymbols, IQueryable<GenLanguageSymbol> symbols, char[] suffix)
        {
            for (int n = 0; n < suffix.Length; n++)
            {
                //make sure char wasn't already included in combo
                if (n > 0)
                {
                    var lastCombo = new string(new char[] { suffix[n - 1], suffix[n] });
                    if (wordSymbols.Any(x => x.Symbol == lastCombo))
                    {
                        continue; //skip to next iteration
                    }
                }

                var combo = new string(new char[] { suffix[n], suffix[n + 1] });

                if (symbols.Any(x => x.GenSymbol.Symbol == combo))
                {
                    //combo was accepted
                    wordSymbols.Add(symbols.FirstOrDefault(x => x.GenSymbol.Symbol == combo).GenSymbol);
                }
                else
                {
                    //combo was not accepted - add single symbol
                    var symbol = suffix[n].ToString();
                    wordSymbols.Add(symbols.FirstOrDefault(x => x.GenSymbol.Symbol == symbol).GenSymbol);
                }
            }//end for

            return wordSymbols;
        }

        private List<GenSymbol> GetSeparator(List<GenSymbol> wordSymbols, IQueryable<GenLanguageSymbol> separators)
        {
            if (!wordSymbols.Any(x => x.SymbolID == 168)) //primary stress has not been set, add it
            {
                wordSymbols.Add(separators.FirstOrDefault(x => x.SymbolID == 168).GenSymbol);
            }
            else
            {
                if (!wordSymbols.Any(x => x.SymbolID == 169)) //secondary stress has not been set, 50% chance to add it
                {
                    if (rnd.Next(0, 2) == 1)
                    {
                        //add secondary stress
                        wordSymbols.Add(separators.FirstOrDefault(x => x.SymbolID == 169).GenSymbol);
                    }
                    else
                    {
                        //add something that isn't stress
                        wordSymbols.Add(separators.OrderBy(x => Guid.NewGuid()).FirstOrDefault(x => x.SymbolID != 168 && x.SymbolID != 169).GenSymbol);
                    }
                }
                else
                {
                    //add something that isn't stress
                    wordSymbols.Add(separators.OrderBy(x => Guid.NewGuid()).FirstOrDefault(x => x.SymbolID != 168 && x.SymbolID != 169).GenSymbol);
                }
            }

            return wordSymbols;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}