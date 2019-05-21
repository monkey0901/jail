using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MODEL
{

    public class CriminalDbContext : DbContext
    {
        public CriminalDbContext() : base("data source=.;initial catalog=16jail;uid=sa;pwd=123456;") //构造函数，指定数据库名称的约定连接
        {
            Database.SetInitializer<CriminalDbContext>(null);
        }

        public DbSet<CriminalBasicInfoTable> CriminalBasicInfo { get; set; }
    }

    [Table ("CriminalBasicInfoTable")]
    public class CriminalBasicInfoTable
    {

        [Key]
        public string criminalID { get; set; }
        public string criminalName { get; set; }
        public string IDNumber { get; set; }
        public DateTime imprisonTime { get; set; }
        public string imprisonReason { get; set; }
        public double prisonTerm { get; set; }
        public string RFIDNumber { get; set; }
        public string predecessorFileNumber { get; set; }
    }


}
