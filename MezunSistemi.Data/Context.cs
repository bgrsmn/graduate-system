using MezunSistemi.Data.Migrations;
using MezunSistemi.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MezunSistemi.Data
{
    public class Context:DbContext
    {
        public Context():base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>("Context"));
        }

        public DbSet<Mezun>Mezunlar { get; set; }
        public DbSet<EğitimBilgileri> EgıtımBılgılerı { get; set; }
        public DbSet<SertifikaBilgileri> SertıfıkaBılgılerı { get; set; }
        public DbSet<ÇalışmaBilgileri> CalısmaBılgılerı { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Pozisyon> Pozısyonlar { get; set; }
        public DbSet<ÇalışmaAlanları> CalısmaAlanları { get; set; }
        public DbSet<Takıp> Takıpler { get; set; }
        public DbSet<İlanlar> Ilanlar { get; set; }
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<Anketler> Anketler { get; set; }
        public DbSet<Mesajlar> Mesajlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //s takısı kaldırma
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}
