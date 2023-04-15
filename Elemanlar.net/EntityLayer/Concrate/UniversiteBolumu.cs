using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class UniversiteBolumu
    {
        [Key]
        public int UniversitBolumuId { get; set; }
        public string UniversiteBolumuIsmi { get; set; }
    }
}
