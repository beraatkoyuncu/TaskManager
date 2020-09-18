using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;


namespace TaskManager.Models
{
    public class Manager
    {
        public int ID { get; set; }
        [Display(Name = "Activity Name")]
        public string ActivityName { get; set; }
        public string ActivityDate { get; set; }
        [Display(Name = "Activity Hour")]
        public string ActivityHour { get; set; }
        [Display(Name = "Activity Description")]
        public string ActivityDesctription { get; set; }


        [Display(Name = "Activity Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
