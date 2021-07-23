using System;

namespace MemeTown.Models
{
    public class ImportantLinks
    {
        public string Id {get;set;}
        public string Url{get;set;}

        public ImportantLinks()
        {
            Url= "https://www.youtube.com/watch?v=o-YBDTqX_ZU"; //default is the mega meme.
        }
    }
}