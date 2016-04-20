using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
        public Location()
        {
            Experiences = new HashSet<Experience>();
            Persons = new HashSet<Person>();
        }
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
