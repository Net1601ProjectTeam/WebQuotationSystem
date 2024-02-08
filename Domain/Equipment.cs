using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Equipment
    {
        public Equipment() {
         
            QuoteDetails = new HashSet<QuoteDetail>();
        }
        [Key]
        public Guid EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string Note { get; set; }
        public double UnitPrice {  get; set; }
        public  ICollection<QuoteDetail> QuoteDetails { get; set; }
    }
}
