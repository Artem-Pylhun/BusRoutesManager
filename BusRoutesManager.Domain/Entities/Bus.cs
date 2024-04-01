using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Domain.Entities
{
    public class Bus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Model Model { get; set; }
        public int Capacity { get; set; }
        public string PlateNumber { get; set; }
         
        public virtual ICollection<Route> Routes { get; set; } = new HashSet<Route>();
    }
}
