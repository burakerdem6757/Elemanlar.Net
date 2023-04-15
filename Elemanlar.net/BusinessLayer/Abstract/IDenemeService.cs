using EntityLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDenemeService
    {
        void BlogAdd(IsIlanlari isilanlari);
        void BlogRemove(IsIlanlari isilanlari);
        void BlogUpdate(IsIlanlari isilanlari);
        List<IsIlanlari> GetList();
        IsIlanlariViewModel GetById(int id);

        public OzgecmisViewModel GetOzgecmisGoruntule(int id);
        List<IsIlanlariViewModel> GetbyFavoriIlanlarId(int id);

        List<IsIlanlariViewModel> GetbyBasvurularId(int id);
        List<IsIlanlari> GetBlogListWithCategory();
    }
}
