using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;

namespace BrailleTestApp
{
    public class Pattern
    {
        public string GeneratePatternForCharacters(string name)
        {
            string pattern = "";
            foreach (char c in name)
            {
                if (Char.IsLower(c))
                {
                    switch (c)
                    {
                        case 'a':
                            pattern += "⠁";
                            
                            break;
                        case 'b':
                            //pattern += "<span class='red-text'>⠃</span>";
                            pattern += "⠃"; 
                            break;
                        case 'c':
                            pattern += "⠉";
                            break;
                        case 'd':
                            pattern += "⠙";
                            break;
                        case 'e':
                            pattern += "⠑";
                            break;
                        case 'f':
                            pattern += "⠋";
                            break;
                        case 'g':
                            pattern += "⠛";
                            break;
                        case 'h':
                            pattern += "⠓";
                            break;
                        case 'i':
                            pattern += "⠊";
                            break;
                        case 'j':
                            pattern += "⠚";
                            break;
                        case 'k':
                            pattern += "⠅";
                            break;
                        case 'l':
                            pattern += "⠇";
                            break;
                        case 'm':
                            pattern += "⠍";
                            break;
                        case 'n':
                            pattern += "⠝";
                            break;
                        case 'o':
                            pattern += "⠕";
                            break;
                        case 'p':
                            pattern += "⠏";
                            break;
                        case 'q':
                            pattern += "⠟";
                            break;
                        case 'r':
                            pattern += "⠗";
                            break;
                        case 's':
                            pattern += "⠎";
                            break;
                        case 't':
                            pattern += "⠞";
                            break;
                        case 'u':
                            pattern += "⠥";
                            break;
                        case 'v':
                            pattern += "⠧";
                            break;
                        case 'w':
                            pattern += "⠺";
                            break;
                        case 'x':
                            pattern += "⠭";
                            break;
                        case 'y':
                            pattern += "⠽";
                            break;
                        case 'z':
                            pattern += "⠵";
                            break;
                        default:
                            return "Unknown";
                    }
                }
                else if (Char.IsUpper(c))
                {
                    pattern += "⠠";

                    switch (c)
                    {
                        case 'A':
                            pattern += "⠁";
                            break;
                        case 'B':
                            pattern += "⠃";
                            break;
                        case 'C':
                            pattern += "⠉";
                            break;
                        case 'D':
                            pattern += "⠙";
                            break;
                        case 'E':
                            pattern += "⠑";
                            break;
                        case 'F':
                            pattern += "⠋";
                            break;
                        case 'G':
                            pattern += "⠛";
                            break;
                        case 'H':
                            pattern += "⠓";
                            break;
                        case 'I':
                            pattern += "⠊";
                            break;
                        case 'J':
                            pattern += "⠚";
                            break;
                        case 'K':
                            pattern += "⠅";
                            break;
                        case 'L':
                            pattern += "⠇";
                            break;
                        case 'M':
                            pattern += "⠍";
                            break;
                        case 'N':
                            pattern += "⠝";
                            break;
                        case 'O':
                            pattern += "⠕";
                            break;
                        case 'P':
                            pattern += "⠏";
                            break;
                        case 'Q':
                            pattern += "⠟";
                            break;
                        case 'R':
                            pattern += "⠗";
                            break;
                        case 'S':
                            pattern += "⠎";
                            break;
                        case 'T':
                            pattern += "⠞";
                            break;
                        case 'U':
                            pattern += "⠥";
                            break;
                        case 'V':
                            pattern += "⠧";
                            break;
                        case 'W':
                            pattern += "⠺";
                            break;
                        case 'X':
                            pattern += "⠭";
                            break;
                        case 'Y':
                            pattern += "⠽";
                            break;
                        case 'Z':
                            pattern += "⠵";
                            break;
                        default:
                            return "Unknown";
                    }
                }
                else
                {
                    switch (c)
                    {
                        case '0':
                            pattern += "⠴";
                            break;
                        case '1':
                            pattern += "⠂";
                            break;
                        case '2':
                            pattern += "⠆";
                            break;
                        case '3':
                            pattern += "⠒";
                            break;
                        case '4':
                            pattern += "⠲";
                            break;
                        case '5':
                            pattern += "⠢";
                            break;
                        case '6':
                            pattern += "⠖";
                            break;
                        case '7':
                            pattern += "⠶";
                            break;
                        case '8':
                            pattern += "⠦";
                            break;
                        case '9':
                            pattern += "⠔";
                            break;
                        case '.':
                            pattern += "⠲";
                            break;
                        case ',':
                            pattern += "⠂";
                            break;
                        case '?':
                            pattern += "⠢⠦";
                            break;
                        case '!':
                            pattern += "⠖";
                            break;
                        case '\'':
                            pattern += " ⠄";
                            break;
                        case '"':
                            pattern += "⠶⠶";
                            break;
                        case ';':
                            pattern += "⠶";
                            break;
                        case ':':
                            pattern += "⠒";
                            
                            break;
                        case '(':
                            pattern += "⠷";
                            break;
                        case ')':
                            pattern += "⠾";
                            break;
                        case '[':
                            pattern += "⠈⠣";
                            break;
                        case ']':
                            pattern += "⠱⠄";
                            break;
                        case '{':
                            pattern += "⠨⠷";
                            break;
                        case '}':
                            pattern += "⠘⠴";
                            break;
                        case '&':
                            pattern += " ⠈⠯";
                            break;
                        case '$':
                            pattern += "⠈⠎";
                            break;
                        case '@':
                            pattern += "⠈⠜";
                            break;
                        case '+':
                            pattern += "⠬";
                            break;
                        case '%':
                            pattern += "⠘⠴";
                            break;
                        case '^':
                            pattern += "⠈⠂⠂";
                            break;
                        case '_':
                            pattern += "⠸⠤";
                            break;
                        case '/':
                            pattern += "⠌";
                            break;
                        case '\\':
                            pattern += "⠜";
                            break;
                        case '|':
                            pattern += "⠷⠂";
                            break;
                        case '<':
                            pattern += "⠤⠤";
                            break;
                        case '>':
                            pattern += "⠦⠦";
                            break;
                        case '=':
                            pattern += "⠨⠤";
                            break;
                        case '-':
                            pattern += "⠤";
                            break;
                        case '#':
                            pattern += "⠈⠼";
                            break;
                        case '`':
                            pattern += "⠈";
                            break;
                        case '~':
                            pattern += "⠈⠂";
                            break;
                    }
                }
            }
            //we can use html tags in c# files with ASP.NET framework
            string FinalCountSt="<span class='red-text'>"+DotCounter(pattern)+"</span>";
            //string FinalCountSt = $"<span class='red-text'>{DotCounter(pattern)}</span>";
            return pattern + "\n"+ FinalCountSt;
        }

        public string GeneratePatternForShape(string name)
        {
            string pattern = "";
            if(name=="Circle")
            {
                pattern += "⠫⠿";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern+"\n"+ FinalCountSt;
            }
            if (name == "Square")
            {
                pattern = "⠫⠼⠙";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Rectangle")
            {
                pattern = "⠫⠊";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n"+ FinalCountSt;
            }

            if (name == "Triangle")
            {
                pattern += "⠫⠼⠉";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }

            if (name == "Pentagon")
            {
                //when I put pattern += " ⠫⠼⠑\n"; it didnt generate the correct amount if dots. Omitted both space and \n. Then it worked
                pattern += "⠫⠼⠑";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Hexagon")
            {
                pattern += "⠫⠼⠋";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Heptagon")
            {
                pattern += "⠫⠼⠛";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" +  FinalCountSt;
            }
            if (name == "Octagon")
            {
                pattern += "⠫⠼⠓";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Nonagon")
            {
                pattern += "⠫⠔";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n"+ FinalCountSt;
            }
            if (name == "Trapezoid")
            {
                pattern += "⠫⠵";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Rhombus")
            {
                pattern += "⠫⠓";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" +  FinalCountSt;
            }
            if (name == "Parallelogram")
            {
                pattern += "⠫⠛";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            if (name == "Quadrilateral")
            {
                pattern += "⠫⠟";
                string FinalCountSt = "<span class='red-text' style='display: block; margin-bottom: 1em;'>" + DotCounter(pattern) + "</span>";
                return pattern + "\n" + FinalCountSt;
            }
            else return "unknown";
        }

        public string DotCounter(string sign)
        {

            string ReturnStatment = "";
            int Dots = 0;

            foreach (char c in sign)
            {
                //cannot use only foreach (char c in braille) without a for loop assuming that each Braille
                //character is represented by a single Unicode character, which isn't always the case. some Braille characters
                //are represented by multiple Unicode characters

                //no of dots in each character
                int dotsInChar = 0;
                for (int i = 0; i < 6; i++)
                {
                    if ((c & (1 << i)) != 0)
                    {
                        dotsInChar++;
                    }
                }
                // Add the number of dots in the current Braille character to the total
                Dots += dotsInChar;
            }
            ReturnStatment += "Number of dots: " + Dots.ToString();
            return ReturnStatment; // Output: Number of dots: 10
        }

        public string ShapePerimeters(string name, string radius, string length, string height, string sideLength, string tr1, string tr2, string tr3, string pentL, string hexL, string heptL, string octL, string nongL, string Pl1, string Pl2, string Pl3, string Pl4, string Tz1, string Tz2, string Tz3, string Tz4, string Rh1, string Rh2, string Rh3, string Rh4, string Ql1, string Ql2, string Ql3, string Ql4)
        {
            if (name == "Circle")
            {
                double p = 2 * 3.14 * Convert.ToDouble(radius);
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Square")
            {
                double p = Convert.ToDouble(sideLength) * 4;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Rectangle")
            {
                double p = (Convert.ToDouble(length) * 2) + (Convert.ToDouble(height) * 2);
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }

            else if(name == "Triangle")
            {
                double p = (Convert.ToDouble(tr1)) + (Convert.ToDouble(tr2)) + (Convert.ToDouble(tr3));
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }

            else if(name == "Pentagon")
            {
                double p = (Convert.ToDouble(pentL)) * 5;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Hexagon")
            {
                double p = (Convert.ToDouble(hexL)) * 6;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Heptagon")
            {
                double p = (Convert.ToDouble(heptL)) * 7;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Octagon")
            {
                double p = (Convert.ToDouble(octL)) * 8;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Nonagon")
            {
                double p = (Convert.ToDouble(nongL)) * 9;
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Trapezoid")
            {
                double p = (Convert.ToDouble(Tz1)) + (Convert.ToDouble(Tz2)) + (Convert.ToDouble(Tz3)) + (Convert.ToDouble(Tz4));
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Rhombus")
            {
                double p = (Convert.ToDouble(Rh1)) + (Convert.ToDouble(Rh2)) + (Convert.ToDouble(Rh3)) + (Convert.ToDouble(Rh4));
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if(name == "Parallelogram")
            {
                double p = (Convert.ToDouble(Pl1)) + (Convert.ToDouble(Pl2)) + (Convert.ToDouble(Pl3)) + (Convert.ToDouble(Pl4));
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else if (name == "Quadrilateral")
            {
                double p = (Convert.ToDouble(Ql1)) + (Convert.ToDouble(Ql2)) + (Convert.ToDouble(Ql3)) + (Convert.ToDouble(Ql4));
                string p2 = "<span class='red-text'>Perimeter: " + p.ToString() + "\n</span>";
                return p2;
            }
            else
                return "unknown"; 
        }
    }
}
