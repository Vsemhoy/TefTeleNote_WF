using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class Page
    {
        public string id;
        public string name;
        public int order;

        public Page(string id, string name, int order)
        {
            this.order = order;
            this.name = name;
            this.id = id;
        }
        public Page()
        {
            this.order = 0;
            this.name = String.Empty;
            this.id = String.Empty;
        }
    }
}
