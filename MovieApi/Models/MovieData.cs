using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieClient.Models
{
    public class MovieData
    {
        [Required(ErrorMessage = "This Field is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Actor { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Sales { get; set; } = 0;
    }
}
