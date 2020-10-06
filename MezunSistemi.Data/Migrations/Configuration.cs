namespace MezunSistemi.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MezunSistemi.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MezunSistemi.Data.Context";



        }

        protected override void Seed(MezunSistemi.Data.Context context)
        {
        }
    }
}
