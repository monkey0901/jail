using System.Collections.Generic;
using System.Linq;
using MODEL;

namespace DAL
{
    public class ButtonAction
    {


        //删除记录(User中应包含主键ID值)
        public static bool Delete(CriminalBasicInfoTable user)
        {
            using (CriminalDbContext db = new CriminalDbContext())
            {
                db.CriminalBasicInfo.Attach(user);
                db.CriminalBasicInfo.Remove(user);
                return db.SaveChanges() > 0;
            }
        }


        //返回所有记录
        public static List<CriminalBasicInfoTable> GetAll()
        {
            using (CriminalDbContext db = new CriminalDbContext())
            {
                var CrimeQuery = (from b in db.CriminalBasicInfo
                                     orderby b.criminalID
                                     select b).ToList();
                return CrimeQuery;
            }
        }

        //返回查询记录
        public static List<CriminalBasicInfoTable> GetAll(string s)
        {
            using (CriminalDbContext db = new CriminalDbContext())
            {
                var CrimeQuery1 = from b in db.CriminalBasicInfo
                                    where b.criminalID.Contains(s)  
                                    orderby b.criminalID
                                    select b;
                List<CriminalBasicInfoTable> CrimeList = new List<CriminalBasicInfoTable>();

                CrimeList = CrimeQuery1.ToList();

                return CrimeList;

            }
        }
        //添加记录
        public static bool Insert(CriminalBasicInfoTable user)
        {
            using (CriminalDbContext db = new CriminalDbContext())
            {
                db.CriminalBasicInfo.Add(user);
                return db.SaveChanges() > 0;  //保存数据
            }
        }
        //修改记录
        public static bool Update(CriminalBasicInfoTable user)
        {
            using (CriminalDbContext db = new CriminalDbContext())
            {
                db.CriminalBasicInfo.Attach(user);
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }



    }
}
