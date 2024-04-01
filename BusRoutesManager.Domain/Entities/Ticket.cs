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
        public virtual Route Route{ get; set; }
        public virtual User User{ get; set; }
        public float Price { get; set; }
        public virtual BusStation ArrivalStationId { get; set; }
        public virtual BusStation DepartureStationId { get; set; }
    }
}
