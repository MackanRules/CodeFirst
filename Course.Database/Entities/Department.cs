using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Comp.Database.Interfaces;

namespace Course.Database.Entities
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        [MaxLength(30), Required] public string DepartmentName { get; set; }
        [Required] public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
