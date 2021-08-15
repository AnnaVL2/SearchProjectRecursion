using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    public class SearchLogic : BaseLogic
    {
        // DB addition of searches
        public int AddSearch(SearchDTO search)
        {
            Search searchToAdd = new Search
            {
                SearchString = search.searchString,
                FolderToSearch = search.folderToSearch
            };
            db.Searches.Add(searchToAdd);
            db.SaveChanges();
            search.id = searchToAdd.SearchID;
            return search.id;
        }

        // check function for internal use
        public List<SearchDTO> GetAllSearches()
        {
            var q = from s in db.Searches
                    select new SearchDTO
                    {
                        id = s.SearchID,
                        searchString = s.SearchString,
                        folderToSearch = s.FolderToSearch
                    };
            return q.ToList();
        }
    }
}
