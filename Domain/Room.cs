using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Room
    {
        public Room()
        {
        }
        [Key]

        public Guid RoomID {  get; set; }
        public string RoomName { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
