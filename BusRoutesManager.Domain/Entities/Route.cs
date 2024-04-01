using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRoutesManager.Domain.Entities
{
    public class Route
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Bus Bus{ get; set; }
        public virtual Driver Driver { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DayOfWeek { get; set; }
        public virtual ICollection<RouteNode> RouteNodes { get; set; } = new HashSet<RouteNode>();
    }
}
