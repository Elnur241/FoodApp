using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu sahe bos buraxila bilmez.")]
        [StringLengthAttribute(20,ErrorMessage ="4den az 20-den cox ola bimez",MinimumLength =4)]
        public string Name { get; set; }
  
        public string Description { get; set; }
        public bool Status { get; set; }
        List<Food> Foods { get; set; }
    }
}
