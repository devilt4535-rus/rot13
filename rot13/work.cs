using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rot13
{
    internal class work
    {
        public static void WordEncryption(string enter)
        {
            if (enter == " " || enter == "")
            {
                Console.WriteLine();
                Console.WriteLine($"Стока пуста");
                Console.WriteLine();
            }
            else
            {
                char[] lowercase = new char[]
                {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                };
                char[] upperCase = new char[]
                {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
                };
                var enterchars = enter.ToArray();
                for (int i = 0; i < enterchars.Length; i++)
                {
                    if (char.IsLetter(enterchars[i]))
                    {
                        bool check = false;
                        foreach (var c in lowercase)
                        {
                            if (enterchars[i] == c)
                            {
                                check = true;
                            }
                        }
                        foreach (var c in upperCase)
                        {
                            if (enterchars[i] == c)
                            {
                                check = true;
                            }
                        }
                        if (check)
                        {
                            char symbol = ' ';
                            int counter = 0;
                            bool checksymbol = false;
                            for (int j = 0; j < lowercase.Length; j++)
                            {
                                if (enterchars[i] == lowercase[j])
                                {
                                    checksymbol = true;
                                }
                                if (checksymbol)
                                {
                                    counter++;
                                    if (counter == 14)
                                    {
                                        symbol = lowercase[j];
                                        counter = 0;
                                        checksymbol = false;
                                        break;
                                    }
                                }
                                if (j == 25)
                                {
                                    if (checksymbol == false)
                                    {
                                        break;
                                    }
                                    j = 0;
                                }
                            }
                            for (int j = 0; j < upperCase.Length; j++)
                            {
                                if (enterchars[i] == upperCase[j])
                                {
                                    checksymbol = true;
                                }
                                if (checksymbol)
                                {
                                    counter++;
                                    if (counter == 14)
                                    {
                                        symbol = upperCase[j];
                                        counter = 0;
                                        break;
                                    }
                                }
                                if (j == 25)
                                {
                                    if (checksymbol == false)
                                    {
                                        break;
                                    }
                                    j = 0;
                                }
                            }
                            enterchars[i] = symbol;
                        }
                    }
                }
                Console.Write($"Текст после шифрования - : ");
                foreach (var c in enterchars)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"Текст до шифрования - : {enter}");
                Console.WriteLine();
            }
        }
    }
}
