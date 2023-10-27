using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Core.Domain
{
    public class ArtworkType
    {
        public Guid Id { get; set; }
        public string Form {  get; set; }
        public string Genre { get; set; }
        public string Era { get; set; }
    }
}
