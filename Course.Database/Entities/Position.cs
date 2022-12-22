using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comp.Database.Interfaces;

namespace Course.Database.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        [MaxLength(30), Required] public string PositionName { get; set; }
        public virtual ICollection<Person>? Persons { get; set; }
    }
}
