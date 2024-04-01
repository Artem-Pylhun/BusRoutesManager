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
        [ForeignKey("ArrivalStation")]
        public int ArrivalStationId { get; set; }
        public virtual BusStation ArrivalStation { get; set; }

        [ForeignKey("DepartureStation")]
        public int DepartureStationId { get; set; }
        public virtual BusStation DepartureStation { get; set; }

        public DateTime RouteDate { get; set; }
    }
}
