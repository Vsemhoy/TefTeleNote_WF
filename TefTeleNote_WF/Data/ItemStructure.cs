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
        public string path { get; set; }
        public int type { get; set; }
        public int order { get; set; }
        public int level { get; set; }
        public int tabIndex { get; set; }

        public bool isOpen;
        public ItemStructure()
        {
            this.id = Generators.ID.Generate(32);
            this.name = "New page";
            this.type = ItemStructure.PAGE;
            this.order = 1;
            this.level = 1;
            this.tabIndex = 1;
            this.path = String.Empty;
            this.isOpen = true;
        }

        public static ItemStructure GetItemStructById(List<ItemStructure> its, string id)
        {
            if ( its != null)
            {
                foreach (ItemStructure istru in its)
                {
                    if (istru.id == id)
                    {
                        return istru;
                    }
                }
            }
            return null;
        }

        internal static List<ItemStructure> Reorder(List<ItemStructure> bookStructure, ItemStructure sourcePage)
        {
            List<ItemStructure> newStruct = new List<ItemStructure>();
            int torder = sourcePage.order;
            int order = 0;
            bool added = false;
            foreach (ItemStructure istru in bookStructure)
            {
                if (torder == order)
                {
                    newStruct.Add(sourcePage);
                    order++;
                    added = true;
                }
                if (istru.id != sourcePage.id)
                {
                    istru.order = order;
                    newStruct.Add(istru);
                    order++;
                }
            }
            if (added == false)
            {
                newStruct.Add(sourcePage);
            }
            return newStruct;
        }
    }


}
