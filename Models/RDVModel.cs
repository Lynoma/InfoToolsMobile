using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Models
{
    public class RDVModel
    {
        public int IdRDV { get; set; }
        public DateTime DateRDV { get; set; }
        public ClientModel Client { get; set; }
        public CommercialModel Commercial { get; set; }

        public RDVModel()
        {
            Client = new ClientModel();
            Commercial = new CommercialModel();
        }
    }
}
