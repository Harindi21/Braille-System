namespace BrailleTestApp
{
    public class pattern
    {
        public string GeneratePattern(string name)
        {
            if (name == "A")
                return ".";
            if (name == "B")
                return "..";
            else
                return "done";

        }
    }
}
