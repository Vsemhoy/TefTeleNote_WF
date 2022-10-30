using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Generators
{
    public static class RandomText
    {
        private static int digitCorrector(int start, int last) { 
            Random random = new Random();
            return random.Next(start, last); 
        }

        public static string generateRandomString(int length = 100)
        {
            Random random = new Random();
            string characters = "eatoinhsrdlwmguycfpbkvxjzq";
            string vowels = "eaoiuy";
            string consonants = "tinhsrdlwmgcfpbkvxjzq";
            string capchars = "EATOINHSRDLWMGUYCFPBKVXJZQ";

            string[] gaps = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", ", ", ", ", ", ", ", ", ", ", ", ", ", ", " - ", "'", ": ", "; ", " — " };
            string[] capitalgaps = { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "?", "!", "!?", "..." };
            int charactersLength = characters.Length; 
            int capcharsLength = capchars.Length; 
            string randomString = "";

            int boycounter = 0;
            int lettrCounter = 0;
            int enterCounter = 0;
            string lactCapafter = "";
            string lastCharAfter = "";
            int VC_POSITION = 0;
            int startcounter = 0;

            int wordCounts = 0;
            int enterCounts = 0;

            for (int i = 0; i < length; i++) {
                if (boycounter == 0) {
                    wordCounts = random.Next(7, 27);
                }
                if (enterCounter == 0) {
                    enterCounts = random.Next(3, 13); 
                }
                for (int w = 0; w < random.Next(1, 12); w++ ) {
                    if (((boycounter == 1) && (lettrCounter == 0)) || startcounter == 0) {
                        startcounter++;
                        randomString += capchars[random.Next(0, digitCorrector(0, capcharsLength - 1))];
                        lettrCounter++;
                    } 
                    else
                    {
                        if (VC_POSITION == 0){
                        characters = vowels;
                        charactersLength = vowels.Length;
                        VC_POSITION = 1;
                        } 
                        else
                        {
                        characters = consonants;
                        charactersLength = consonants.Length;
                        VC_POSITION = 0;
                        }
                        string lastcharBefore = characters[random.Next(0, digitCorrector(0, charactersLength - 1))].ToString();
                        
                        if (lastcharBefore != lastCharAfter){
                            randomString += lastcharBefore;
                            lastCharAfter = lastcharBefore;
                        } else { 
                            randomString += characters[random.Next(0, digitCorrector(0, charactersLength - 1))].ToString(); 
                        }
                        lettrCounter++;
                    }
                }
                if (boycounter == wordCounts) {
                string capitalpoint = capitalgaps[(random.Next(0, capitalgaps.Length - 1))];
                randomString = randomString + capitalpoint + "\n\r";
                boycounter = 0; 
                    lettrCounter = 0;
                    enterCounter++;
                    if (enterCounter == enterCounts) {
                    randomString = randomString + "\n\r";
                    enterCounter = 0;
                    }
                } 
                else
                {
                string gap = gaps[(random.Next(0, gaps.Length - 1))];
                randomString = randomString + gap;
                }
                boycounter++;
            }
            randomString = randomString.Substring(0, randomString.Length - 1) + ".";
            return randomString.Trim();
        }
    }
}
