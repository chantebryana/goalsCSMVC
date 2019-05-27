using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace goalsCSMVC.Models
{
    public class Moon1
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime FullMoonDate { get; set; }
    }
}
