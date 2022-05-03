using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Models
{
    public class CommercialModel
    {
        public int idCom { get; set; }
        public string nomCom { get; set; }
        public string prenomCom { get; set; }

        public override string ToString()
        {
            return nomCom + " " + prenomCom;
        }
    }
}
