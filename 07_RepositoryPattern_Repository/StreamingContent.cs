using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror =1 ,
        SciFi,
        Bromance,
        Action,
        Fantasy,
        Comedy,
        Drama,
        Crime
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public int RunTimeInMin { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public bool IsFamilyFriendly { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, int runTime, DateTime releaseDate,GenreType type, bool familyFriendly)
        {
            Title = title;
            RunTimeInMin = runTime;
            ReleaseDate = releaseDate;
            TypeOfGenre = type;
            IsFamilyFriendly = familyFriendly;
        }
    }
}
