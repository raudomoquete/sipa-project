using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class RequestType
    {
        [Key]
        public int Id { get; set; }
        public string RequestName { get; set; }
        public DateTime RequestDate { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
