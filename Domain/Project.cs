using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Project
    {
        public Project()
        {
            Rooms=new HashSet<Room>();
            QuoteDetail=new HashSet<QuoteDetail>();
        }
        [Key]

        public Guid ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set;}
        public string Status { get; set; }
        public Guid StaffId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
        public  ICollection<Room> Rooms { get; set; }
        public  ICollection<QuoteDetail> QuoteDetail { get; set; }

    }
}
