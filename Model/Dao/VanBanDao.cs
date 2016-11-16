using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class VanBanDao
    {
        QlyVanBanDbContext db = null;
        public VanBanDao()
        {
            db = new QlyVanBanDbContext();
        }
        public IEnumerable<VanBan> ListAllPaging( int page, int pageSize)
        {
            IQueryable<VanBan> model = db.VanBans;

            return model.OrderByDescending(x => x.VanBanID).ToPagedList(page, pageSize);
        }
        public bool Delete(int id)
        {
            try
            {
                var vb = db.VanBans.Find(id);
                db.VanBans.Remove(vb);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool MultiDelete (int[] checkid)
        {
            for (int i = 0; i < checkid.Length; i++)
            {
                int temp = checkid[i];
                var vb = db.VanBans.Where(ar => ar.VanBanID == temp).SingleOrDefault();
                this.db.VanBans.Remove(vb);
            }
            db.SaveChanges();
            return true;
        }
    }
}
