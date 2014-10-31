using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright.src
{
    class item
    {
        public string Name;
        public int Index;
        public string Author;
        public string Series;

        public Dictionary<int, item> Items;
    }
}
