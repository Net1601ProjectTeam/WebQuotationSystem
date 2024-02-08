using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Account
    {
        protected Account()
        {
        }
        [Key]

        public Guid AccountID { get; set; }
        public string Username {  get; set; }
        public string Password {  get; set; }
        public string Role {  get; set; }
        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
    }
}
