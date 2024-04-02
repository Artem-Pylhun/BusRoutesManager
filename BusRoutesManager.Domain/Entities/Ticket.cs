using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Domain.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual User User{ get; set; }
        public float Price { get; set; }
        [ForeignKey("ArrivalRouteNode")]
        public int ArrivalRouteNodeId { get; set; }
        public virtual RouteNode ArrivalRouteNode { get; set; }

        [ForeignKey("DepartureRouteNode")]
        public int DepartureRouteNodeId { get; set; }
        public virtual RouteNode DepartureRouteNode { get; set; }

        public DateTime RouteDate { get; set; }

        public virtual Route Route { get; set; }
    }
}
