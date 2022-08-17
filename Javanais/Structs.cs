using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javanais
{
    public static class Structs
    {
        public static string Encode(string traduction)
        {
            if (Structs.CheckVowel(traduction[0]))
            {
                traduction = traduction.ToLower();
                string temp = traduction.Insert(0, "Av");
                traduction = Structs.AddAvAfterConsonent(3, temp);
            }
            else
            {
                traduction = Structs.AddAvAfterConsonent(0, traduction);
            }
            return traduction;
        }

        public static string Decode(string traduction)
        {
            // attention il faut prendre en compte les mots composés ex: Astre avance
            if ((traduction[0] == 'a' || traduction[0] == 'A') && traduction[1] == 'v' && Structs.CheckVowel(traduction[2]))
            {
                string temp = traduction.Remove(0, 2);
                traduction = Structs.RemoveAvAfterConsonent(1, temp);
            }
            else
            {
                traduction = traduction.ToLower();
                traduction = Structs.RemoveAvAfterConsonent(0, traduction);
            }
            return traduction;
        }

        public static string AddAvAfterConsonent(int n, string traduction)
        {
            for (int i = n; i < traduction.Length - 2; i++)
            {
                // faire une version courte avec un while
                if (traduction[i] == ' ' && Structs.CheckVowel(traduction[i+1]))
                {
                    string temp = traduction.Insert(i+1, "Av");
                    traduction = temp;
                    i += 2;
                }
                else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckVowel(traduction[i + 1]))
                {
                    string temp = traduction.Insert(i + 1, "av");
                    traduction = temp;
                    i += 3;
                }
                else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckVowel(traduction[i + 2]))
                {
                    string temp = traduction.Insert(i + 2, "av");
                    traduction = temp;
                    i += 4;
                }
                else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && Structs.CheckVowel(traduction[i + 3]))
                {
                    string temp = traduction.Insert(i + 3, "av");
                    traduction = temp;
                    i += 5;
                }
                else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && Structs.CheckConsonent(traduction[i + 3]) && Structs.CheckVowel(traduction[i + 4]))
                {
                    string temp = traduction.Insert(i + 4, "av");
                    traduction = temp;
                    i += 6;
                }
                else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && Structs.CheckConsonent(traduction[i + 3]) && Structs.CheckConsonent(traduction[i + 4]) && Structs.CheckVowel(traduction[i + 5]))
                {
                    string temp = traduction.Insert(i + 5, "av");
                    traduction = temp;
                    i += 7;
                }

                // AUTRE VERSION
                //if (Structs.CheckConsonent(traduction[i])) //une consonne
                //{
                //    if (Structs.CheckConsonent(traduction[i + 1])) // 2 consonnes
                //    {
                //        if (Structs.CheckConsonent(traduction[i + 2])) // 3 consonnes
                //        {
                //            if (Structs.CheckConsonent(traduction[i + 3])) // 4 consonnes
                //            {
                //                if (Structs.CheckConsonent(traduction[i + 4])) // 5 consonnes
                //                {
                //                    string temp = traduction.Insert(i + 5, "av");
                //                    traduction = temp;
                //                    i += 7;
                //                }
                //                else
                //                {
                //                    string temp = traduction.Insert(i + 4, "av");
                //                    traduction = temp;
                //                    i += 6;
                //                }
                //            }
                //            else
                //            {
                //                string temp = traduction.Insert(i + 3, "av");
                //                traduction = temp;
                //                i += 5;
                //            }
                //        }
                //        else
                //        {
                //            string temp = traduction.Insert(i + 2, "av");
                //            traduction = temp;
                //            i += 4;
                //        }
                //    }
                //    else
                //    {
                //        string temp = traduction.Insert(i + 1, "av");
                //        traduction = temp;
                //        i += 3;
                //    }
                //}
            }
            return traduction;
        }

        public static string RemoveAvAfterConsonent(int n, string traduction)
        {
            for (int i = n; i < traduction.Length - 2; i++)
            {
                if (traduction[i] == ' ' && traduction[i + 1] == 'a' && traduction[i + 2] == 'v' && Structs.CheckVowel(traduction[i + 3]))
                {
                    string temp = traduction.Remove(i + 1, 2);
                    traduction = temp;
                }
                else if (!Structs.CheckVowel(traduction[i]))
                {
                    if (Structs.CheckConsonent(traduction[i]) && traduction[i + 1] == 'a' && traduction[i + 2] == 'v')
                    {
                        string temp = traduction.Remove(i + 1, 2);
                        traduction = temp;
                    }
                    else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && traduction[i + 2] == 'a' && traduction[i + 3] == 'v')
                    {
                        string temp = traduction.Remove(i + 2, 2);
                        traduction = temp;
                        i += 1;
                    }
                    else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && traduction[i + 3] == 'a' && traduction[i + 4] == 'v')
                    {
                        string temp = traduction.Remove(i + 3, 2);
                        traduction = temp;
                    }
                    else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && Structs.CheckConsonent(traduction[i + 3]) && traduction[i + 4] == 'a' && traduction[i + 5] == 'v')
                    {
                        string temp = traduction.Remove(i + 4, 2);
                        traduction = temp;
                    }
                    else if (Structs.CheckConsonent(traduction[i]) && Structs.CheckConsonent(traduction[i + 1]) && Structs.CheckConsonent(traduction[i + 2]) && Structs.CheckConsonent(traduction[i + 3]) && Structs.CheckConsonent(traduction[i + 4]) && traduction[i + 5] == 'a' && traduction[i + 6] == 'v')
                    {
                        string temp = traduction.Remove(i + 5, 2);
                        traduction = temp;
                    }
                }
            }
            return traduction;
        }

        public static bool CheckVowel(char c)
        {
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (char vowel in Vowels)
            {
                if (c == vowel)
                    return true;
            }
            return false;
        }

        public static bool CheckConsonent(char c)
        {
            char[] Consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            foreach (char consonant in Consonants)
            {
                if (c == consonant)
                    return true;
            }
            return false;
        }
    }
}

