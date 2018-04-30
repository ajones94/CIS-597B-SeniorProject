using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SQLDatabaseApp
{
    public class TextSanitation
    {
        public TextSanitation()
        {

        }

        public bool SanitizeText(string input)
        {
            string pattern = "^[a-zA-Z0-9_/-@]+$";
            Match match = Regex.Match(input, pattern);

            if (match.Success) { return true; }
            else { return false; }
        }
    }
}
