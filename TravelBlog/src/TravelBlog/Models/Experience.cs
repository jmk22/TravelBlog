using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        public Experience()
        {
            Persons = new HashSet<Person>();
        }

        [Key]
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
