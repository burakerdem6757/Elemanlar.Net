using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class CalismaSekli
    {
        [Key]
        public int CalismaSekliId { get; set; }
        public string CalismaSekliIsmi { get; set; }
        public int Status { get; set; }
    }
}
