using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    [Table("FavoriIlanlar")]
    public class FavoriIlanlar
    {
        [Key]
        public int FavoriIlanId { get; set; }
        public int IlanId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime FavoriyeAlmaTarihi { get; set; }
        public int Status { get; set; }
    }
}
