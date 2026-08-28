using Rad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad.Model
{
    public class Attachment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Route { get; set; }

        [ForeignKey(nameof(Accommodation))]
        public int AccommodationId { get; set; }
        public Accommodation? Accommodation { get; set; }

    }
}
