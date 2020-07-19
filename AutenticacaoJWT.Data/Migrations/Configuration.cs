namespace AutenticacaoJWT.Data.Migrations
{
    using AuthenticationJWT.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthenticationJWT.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AuthenticationJWT.Data.Context dc)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            dc.User.AddOrUpdate(x => x.ID, new User
            {
                ID = Guid.Parse("1aae9da6-bf59-4186-9e9a-7a4b120da493"),
                Name = "Josefa",
                UserName = "josefa",
                Password = "test1234",
                DatetimeInsert = DateTime.Now

            });
        }
    }
}
