using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class ItemStructure
    {
        public const int PAGE = 1;
        public const int FOLDER = 2;

        public string id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public int order { get; set; }
        public int level { get; set; }
        public int tabIndex { get; set; }
        public ItemStructure()
        {
            this.id = Generators.ID.Generate(32);
            this.name = "New page";
            this.type = ItemStructure.PAGE;
            this.order = 1;
            this.level = 1;
            this.tabIndex = 1;
        }
    }

}
