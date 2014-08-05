namespace CRUDFunJQuery.Migrations
{
    using CRUDFunJQuery.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUDFunJQuery.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUDFunJQuery.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                    u => u.Name,
                    new User { Name = "Aditya J", Address = "AHM", ContactNo = "9327013470" },
                    new User { Name = "Krunal M", Address = "AHM", ContactNo = "9426402587" },
                    new User { Name = "Pranay R", Address = "PUN", ContactNo = "9825098250" },
                    new User { Name = "Maulik S", Address = "HMT", ContactNo = "9385285255" }
                );
        }
    }
}
