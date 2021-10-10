using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eKino_UI.Utilities
{
    public class YoutubeUrlConverter
    {
        public static string ToEmbedUrl(string url)
        {
            Regex regex = new Regex(@"^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=|\?v=)([^#\&\?]*).*");
            Match match = regex.Match(url);

            if(match.Success && match.Groups[2].Length == 11)
            {
                return "https://www.youtube.com/embed/" + match.Groups[2] + "?autoplay=0";
            }

            return url;
        }
    }
}
