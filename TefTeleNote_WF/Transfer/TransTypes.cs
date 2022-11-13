using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Transfer
{



    public class TransReferenceGoToPage
    {
        public string referenceText {get; set;}
        public string referencePage {get; set;}
        public string referenceAnch { get; set; }

        public TransReferenceGoToPage()
        {
            this.referenceText = String.Empty;
            this.referencePage = String.Empty;
            this.referenceAnch = String.Empty;
        }
    }
}
