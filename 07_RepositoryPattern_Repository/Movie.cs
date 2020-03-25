using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class Movie : StreamingContent
    {
        public bool IsSequel { get; set; }
        public Movie() { }
        public Movie(string title,int runTime,DateTime releaseDate,GenreType type, bool isFamilyFriendly, bool isSequel) : base(title,runTime,releaseDate,type,isFamilyFriendly)
        {
            IsSequel = isSequel;
        }
    }
}
