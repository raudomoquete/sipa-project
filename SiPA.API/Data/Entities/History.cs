using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        [ForeignKey("Id")]
        public RequestType RequestType { get; set; }
        public Parishioner Parishioner { get; set; }
    }
}
