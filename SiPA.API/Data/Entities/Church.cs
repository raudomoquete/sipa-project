using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class Church
    {
        public int Id { get; set; }
        public User User { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FoundedDate { get; set; }
        public ICollection<Parishioner> Parishioners { get; set; }
        public ICollection<Christening> Christenings { get; set; }
        public ICollection<FirstCommunion> FirstCommunions { get; set; }
        public ICollection<Confirmation> Confirmations { get; set; }
        public ICollection<Wedding> Weddings { get; set; }
        public ICollection<RequestType> RequestTypes { get; set; }
    }
}
