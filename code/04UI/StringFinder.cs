using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    class StringFinder
    {
        // class includs event
        public event EventHandler<StringEventArgs> StringFound;

        // search function
        public void SearchFiles(string folder, string textToSearch, int SearchID)
        {
            textToSearch = textToSearch.ToLower();

            // get files array from folder
            string[] files = Directory.GetFiles(folder);
            #region LOOP

            // for each file
            foreach (string f in files) 
            {
                string fileName = Path.GetFileNameWithoutExtension(f).ToLower();

                // checks if the fileName matches searched value, textToSearch
                if (fileName.Contains(textToSearch)) 
                {
                    // if the statement is true = there is a file to save
                    using (ResultLogic logic = new ResultLogic()) 
                    {
                        // active event to print on UI
                        StringFound?.Invoke(this, new StringEventArgs(f, textToSearch)); 
                        logic.AddResult(new ResultDTO { folderToSearch = folder, resultString = textToSearch, searchID = SearchID });
                    }
                }
            }
            #endregion
            string[] directories = Directory.GetDirectories(folder);

            if (Directory.Exists(folder))
            {
                foreach (string d in directories)
                {
                    try
                    {
                        SearchFiles(d, textToSearch, SearchID);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        //Console.ReadLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
