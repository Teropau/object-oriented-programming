using System;
using System.Collections.Generic;

namespace MPHarjoitustyö
{
    public class Movies
    {
        public string title { get; set; }
        public int year { get; set; }
        public IList<string> cast { get; set; }
        public string genre { get; set; }
    }
}
