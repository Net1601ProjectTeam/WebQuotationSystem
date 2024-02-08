using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Customer 
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
        }
        [Key]

        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
