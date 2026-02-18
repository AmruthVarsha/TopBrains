using System;
using System.Text.RegularExpressions;
using LogProcessing;





namespace LogProcessing
{
    class LogParser
    {
        private readonly string ValidLineRegexPattern = @"^\[(TRC|DBG|WRN|FTL|INF|ERR)\]\s+\w+";
        private readonly string SplitLineRegexPattern = @"<\*{3}>|<={4}>|<\^\*>";
        private readonly string QuotesPasswordRegexPattern = @"PASSWORD|password";
        private readonly string EndOfLineRegexPattern = @"(end-of-line\d+)$";
        private readonly string WeakPasswordRegexPattern = @"password[A-Za-z0-9]+";

        public bool isValidLine(string text)
        {
            return Regex.IsMatch(text, ValidLineRegexPattern);
        }

        public string[] SplitLogLine(string text)
        {
            return Regex.Split(text,SplitLineRegexPattern);
        }

        public int CountQuotedPasswords(string text)
        {
            MatchCollection matches = Regex.Matches(text , QuotesPasswordRegexPattern);
            return matches.Count;
     
        }

        public string RemoveEndOfLineText(string text)
        {
            return Regex.Replace(text,EndOfLineRegexPattern,"");
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] line = new string[lines.Length];
            int a=0;
            foreach(string i in lines)
            {
                Match m = Regex.Match(i,WeakPasswordRegexPattern);
                if (m.Success)
                {
                    line[a] = m.Value +": "+i;
                }
                else
                {
                    line[a] = "--------: "+i;
                }
                a++;
            }
            return line;
        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        LogParser logParser = new LogParser();

        string validLine = Console.ReadLine();
        Console.WriteLine(logParser.isValidLine(validLine));

        string slpitInput = Console.ReadLine();
        string[] split = logParser.SplitLogLine(slpitInput);

        foreach(string i in split)
        {
            Console.WriteLine(i);
        }

        string quotedPassword = Console.ReadLine();
        Console.WriteLine(logParser.CountQuotedPasswords(quotedPassword));
        string endOfLine = Console.ReadLine();
        Console.WriteLine(logParser.RemoveEndOfLineText(endOfLine));

        int n = int.Parse(Console.ReadLine());
        string[] lines = new string[n];
        for(int i = 0; i < n; i++)
        {
            lines[i] = Console.ReadLine();
        }
        lines = logParser.ListLinesWithPasswords(lines);
        foreach(string i in lines)
        {
            Console.WriteLine(i);
        }

    }
}