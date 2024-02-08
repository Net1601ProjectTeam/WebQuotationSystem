using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Staff
    {
        public Staff() {
            Projects = new HashSet<Project>();
        }
        [Key]
        public Guid StaffId { get; set; }
        public string StaffName { get; set; }
        public string Contact { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
