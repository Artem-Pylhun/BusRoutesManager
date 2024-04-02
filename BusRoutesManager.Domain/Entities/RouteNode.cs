using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Domain.Entities
{
    public class RouteNode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual BusStation Station { get; set; }
        public virtual Route Route { get; set; }
        public DateTime ArrivalTime { get; set; }

        public virtual ICollection<Ticket> ArrivalTickets { get; set; } = new List<Ticket>();
        public virtual ICollection<Ticket> DepartureTickets { get; set; } = new List<Ticket>();

    }
}
