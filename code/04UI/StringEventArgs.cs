using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    class StringEventArgs : EventArgs
    {
        public string Dir { get; set; }
        public string TextToSearch { get; set; }

        public StringEventArgs(string dir, string textToSearch)
        {
            Dir = dir;
            TextToSearch = textToSearch;
        }
    }
}
