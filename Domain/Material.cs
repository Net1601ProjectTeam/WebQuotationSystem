using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Material
    {
        public Material()
        {
            QuoteDetails = new HashSet<QuoteDetail>();
        }
        [Key]

        public Guid MaterialID { get; set; }
        public string MaterialName { get; set; }

        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }

        public string Image { get; set; }
        public ICollection<QuoteDetail> QuoteDetails { get; set; }
    }
}
