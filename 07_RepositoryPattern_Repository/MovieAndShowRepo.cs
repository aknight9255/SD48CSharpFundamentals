using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    class MovieAndShowRepo : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }
    }
}
