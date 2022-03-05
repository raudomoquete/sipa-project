using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class FirstCommunion
    {
        public int FirstCommunionId { get; set; }
        public DateTime FirstCommunionDate { get; set; }
        public Parishioner Parishioner { get; set; }
        public string FatherName { get; set; }
        public string FatherIdentification { get; set; }
        public string MotherName { get; set; }
        public string MotherIdentification { get; set; }
        public string CeremonialCelebrant { get; set; }
        public Church Church { get; set; }
    }
}
