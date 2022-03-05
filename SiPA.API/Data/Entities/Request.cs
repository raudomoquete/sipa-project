using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public RequestType RequestType { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd HH:mm}")]
        public DateTime RequestDate { get; set; }
        public Parishioner Parishioner { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
