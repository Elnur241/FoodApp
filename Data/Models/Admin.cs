using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string userName { get; set; }
        [StringLength(20)]
        public string password { get; set; }
        [StringLength(1)]
        public string Role { get; set; }

    }
}
