using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    public class ResultLogic : BaseLogic
    {
        // DB addition of results
        public void AddResult(ResultDTO result)
        {
            Result resultToAdd = new Result
            {
                ResultString = result.resultString,
                SearchID = result.searchID,
                FolderToSearch = result.folderToSearch,
            };
            db.Results.Add(resultToAdd);
            db.SaveChanges();
        }


        // check function for internal use
        public List<ResultDTO> GetAllResults()
        {
            var q = from r in db.Results
                    select new ResultDTO
                    {
                        id = r.ResultID,
                        resultString = r.ResultString,
                        searchID = r.SearchID,
                        folderToSearch = r.FolderToSearch
                    };

            return q.ToList();
        }
    }
}
