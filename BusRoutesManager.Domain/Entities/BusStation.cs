using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusRoutesManager.Domain.Entities
{
    public class BusStation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual City City { get; set; }
        public string Address { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public virtual ICollection<RouteNode> RouteNodes { get; set; } = new HashSet<RouteNode>();
        public virtual ICollection<Ticket> ArrivalTickets { get; set; } = new List<Ticket>();
        public virtual ICollection<Ticket> DepartureTickets { get; set; } = new List<Ticket>();
    }
}
