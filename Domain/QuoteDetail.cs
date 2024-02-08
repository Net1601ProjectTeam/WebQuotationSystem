using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class QuoteDetail
    {
        public QuoteDetail() { }

        public Guid QuoteID {  get; set; }
        public string QuoteNumber { get; set; }
        public DateTime QuoteDate { get; set;}
        public double TotalAmount { get; set;}
        public Guid ProjectID {  get; set; }
        public Guid MaterialID { get; set; }
        public Guid EquipmentID { get; set; }
        public  Project Project { get; set; }
        public  Material Material { get; set; }
        public  Equipment Equipment { get; set; }
    }
}
