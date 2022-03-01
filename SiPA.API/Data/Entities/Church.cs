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
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Parishioner> Parishioners { get; set; }
        public ICollection<Christening> Christenings { get; set; }
        public ICollection<FirstCommunion> FirstCommunions { get; set; }
        public ICollection<Confirmation> Confirmations { get; set; }
        public ICollection<Wedding> Weddings { get; set; }
        [ForeignKey("Id")]
        public ICollection<RequestType> RequestTypes { get; set; }
    }
}
