using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Core.Domain
{
    public class Artwork
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public int? ArtistId { get; set; }
        public int? ArtworkTypeId { get; set; }
        public int? PersonId { get; set; }
    }
}
