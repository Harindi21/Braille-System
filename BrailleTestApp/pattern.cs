namespace BrailleTestApp
{
    public class pattern
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
            return pattern;
        }

        public string GeneratePatternForShape(string name, string radius, string length, string height, string sideLength)
        {

            if(name=="Circle")
            {
                double p = 2 * 3.41 * Convert.ToDouble(radius);
                string p2 = p.ToString();
                return p2+".c";
            }
            if (name == "Square")
            {
                double p = Convert.ToDouble(sideLength)*4;
                string p2 = p.ToString();
                return p2+".s";
            }
            if (name == "Rectangle")
            {
                double p = (Convert.ToDouble(length) * 2)+ (Convert.ToDouble(height) * 2);
                string p2 = p.ToString();
                return p2+".s";
            }
            else return "unknown";
        }
    }
}


