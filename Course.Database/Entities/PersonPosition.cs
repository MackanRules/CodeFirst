using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comp.Database.Interfaces;

namespace Course.Database.Entities
{
    public class PersonPosition : IReferenceEntity
    {
        [Required] public int PersonId { get; set; }
        [Required] public int PositionId { get; set; }
        public Person? Person { get; set; }
        public Position? Position { get; set; }
    }
}
