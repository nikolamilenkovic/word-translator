using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTranslator
{
    public class Translation
    {
        public ResponseData responseData { get; set; }
        public string responseDetails { get; set; }
        public int responseStatus { get; set; }
        public IList<Match> matches { get; set; }
    }

    public class ResponseData 
    {
        public string translatedText { get; set; }
    }
}
