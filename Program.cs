using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoded
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = null;
            string decoded = null;
            int length;

            Console.WriteLine("Welcome to Decoded v1.5");
            Console.WriteLine("Use '!' to exit");
            while (true)
            {
                Console.WriteLine("Enter what you would like to decode:");
                code = Console.ReadLine().ToLower();
                length = code.Length;
                decoded = null;

                //Console.WriteLine(length);
                if (code != "")
                {

                }
                if (code == "!")
                {
                    Environment.Exit(0);
                }
                else if (code == "?")
                {
                    Console.WriteLine("Created by Markus Gudelis and Nolan Pilon");
                    Console.WriteLine("http://opticalraze.com");
                    Console.WriteLine("Codes");
                    Console.WriteLine("'A' : 'q', 'B' : 'w', 'C' : 'e', 'D' : 'r', 'E' : 't', 'F' : 'y', 'G' : 'u', 'H' : 'i', 'I' : 'o', 'J' : 'p', 'K' : 'a', 'L' : 's', 'M' : 'd', 'N' : 'f', 'O' : 'g', 'P' : 'h', 'Q' : 'j', 'R' : 'k', 'S' : 'l', 'T' : 'z', 'U' : 'x', 'V' : 'c', 'W' : 'v', 'X' : 'b', 'Y' : 'n', 'Z' : 'm'");
                    decoded = "Thanks for using Decoded";
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        char x = code[i];

                        switch (x)
                        {
                            case 'a':
                                decoded += "q";
                                break;
                            case 'b':
                                decoded += "w";
                                break;
                            case 'c':
                                decoded += "e";
                                break;
                            case 'd':
                                decoded += "r";
                                break;
                            case 'e':
                                decoded += "t";
                                break;
                            case 'f':
                                decoded += "y";
                                break;
                            case 'g':
                                decoded += "u";
                                break;
                            case 'h':
                                decoded += "i";
                                break;
                            case 'i':
                                decoded += "o";
                                break;
                            case 'j':
                                decoded += "p";
                                break;
                            case 'k':
                                decoded += "a";
                                break;
                            case 'l':
                                decoded += "s";
                                break;
                            case 'm':
                                decoded += "d";
                                break;
                            case 'n':
                                decoded += "f";
                                break;
                            case 'o':
                                decoded += "g";
                                break;
                            case 'p':
                                decoded += "h";
                                break;
                            case 'q':
                                decoded += "j";
                                break;
                            case 'r':
                                decoded += "k";
                                break;
                            case 's':
                                decoded += "l";
                                break;
                            case 't':
                                decoded += "z";
                                break;
                            case 'u':
                                decoded += "x";
                                break;
                            case 'v':
                                decoded += "c";
                                break;
                            case 'w':
                                decoded += "v";
                                break;
                            case 'x':
                                decoded += "b";
                                break;
                            case 'y':
                                decoded += "n";
                                break;
                            case 'z':
                                decoded += "m";
                                break;
                            case ' ':
                                decoded += " ";
                                break;
                            default:
                                decoded += "?";
                                break;
                        }
                    }
                }
                Console.WriteLine("The word is: {0}", decoded);
            }
        }
    }
}
