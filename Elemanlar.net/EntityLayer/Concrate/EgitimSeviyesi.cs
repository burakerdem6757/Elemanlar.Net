using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class EgitimSeviyesi
    {
        [Key]
        public int EgitimSeviyesiId { get; set; }
        public string EgitimSeviyesiIsmi { get; set; }
    }
}
