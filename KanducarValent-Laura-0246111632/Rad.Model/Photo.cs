using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad.Model
{
    public class Photo
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Accommodation))]
        public int AccommodationID { get; set; }
        public Accommodation? Accommodation { get; set; }

        [Required]
        public string? ImageUrl { get; set; }
    }
}
