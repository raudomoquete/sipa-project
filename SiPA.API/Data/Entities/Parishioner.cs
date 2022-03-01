using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class Parishioner
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Church Church { get; set; }
        public Christening Christening { get; set; }
        public FirstCommunion FirstCommunion { get; set; }
        public Confirmation Confirmation { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
