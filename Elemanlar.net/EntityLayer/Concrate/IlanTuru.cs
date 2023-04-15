using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class IlanTuru
    {
        [Key]
        public int IlanTuruId { get; set; }
        public string IlanTuruIsim { get; set; }

    }
}
