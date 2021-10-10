using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eKino_UI.Utilities
{
    public class ValidationHelper
    {
        public static bool YoutubeURL(string url)
        {
            Regex regex = new Regex(@"^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=|\?v=)([^#\&\?]*).*");
            Match match = regex.Match(url);

            string test = match.Groups[2].ToString();

            return match.Success ? true : false;
        }
    }
}
