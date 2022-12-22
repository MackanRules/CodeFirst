using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comp.Database.Interfaces;

namespace Course.Database.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        [MaxLength(30), Required] public String Firstname { get; set; }
        [MaxLength(30), Required] public String Lastname { get; set; }
        [Required] public int Salary { get; set; }
        [Required] public bool Union { get; set; }
        [Required] public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public virtual ICollection<Position>? Positions { get; set; }   

    }
}
