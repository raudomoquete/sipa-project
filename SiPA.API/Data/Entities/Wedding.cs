using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class Wedding
    {
        public int WeddingId { get; set; }
        public DateTime WeddingDate { get; set; }
        [MaxLength(2)]
        public ICollection<Parishioner> Parishioners { get; set; }
        public string FatherName { get; set; }
        public string FatherIdentification { get; set; }
        public string MotherName { get; set; }
        public string MotherIdentification { get; set; }
        public string GodFatherName { get; set; }
        public string GodFatherIdentification { get; set; }
        public string GoMotherName { get; set; }
        public string GodMotherIdentification { get; set; }
        public string Witness { get; set; }
        public string WitnessIdentification { get; set; }
        public string CeremonialCelebrant { get; set; }
        public Church Church { get; set; }
    }
}
