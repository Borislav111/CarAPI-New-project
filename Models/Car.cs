using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int CarPrice { get; set; }
        public int Year { get; set; }
        public string PhoneNumber { get; set; }

    }
}
