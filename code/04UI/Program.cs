using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    class Program
    {
        // Anna Voloshin .NET 91448/11 John Bryce

        // some check-functions
        static void ShowAllSearches()
        {
            using (SearchLogic logic = new SearchLogic())
            {
                List<SearchDTO> searches22 = logic.GetAllSearches();
                foreach (SearchDTO s in searches22)
                    Console.WriteLine("ID: " + s.id + ", File Name: " + s.searchString + ", Path: " + s.folderToSearch);
            }
        }

        static void ShowAllResults()
        {
            using (ResultLogic logic = new ResultLogic())
            {
                List<ResultDTO> results33 = logic.GetAllResults();
                foreach (ResultDTO r in results33)
                    Console.WriteLine("ID: " + r.id + ", File Name: " + r.resultString + ", Path: " + r.folderToSearch);
            }
        }

        static void Main(string[] args)
        {
            //ShowAllSearches();
            //ShowAllResults();

            using (HandleSearchesUI handleSearchersUI = new HandleSearchesUI())
            {
                handleSearchersUI.Start();
            }
        }
    }
}
