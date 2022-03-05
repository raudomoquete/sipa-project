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
        public int Id { get; set; }
        public string CivilStatus { get; set; }
        public string Nationality { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime DateOfBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public User User { get; set; }
        public Church Church { get; set; }
        public int ChristeningId { get; set; }
        public Christening Christening { get; set; }
        public int FirstCommunionId { get; set; }
        public FirstCommunion FirstCommunion { get; set; }
        public int ConfirmationId { get; set; }
        public Confirmation Confirmation { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
