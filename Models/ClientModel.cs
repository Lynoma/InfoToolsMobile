using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Models
{
    public class ClientModel
    {
        public int idC { get; set; }
        public string nomC { get; set; }
        public string prenomC { get; set; }
        public string adrC { get; set; }
        public string telC { get; set; }
        public string mailC { get; set; }
        public string mdpC { get; set; }
        public int isCli { get; set; }

        public override string ToString()
        {
            return nomC + " " + prenomC;
        }
    }
}
