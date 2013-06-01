namespace Explore.Migrations
{
    using Explore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Explore.Models.ExploreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Explore.Models.ExploreDb context)
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
            Department d = new Department();
            d.Id = 1;
            d.Description = "Information Services Department";
            context.Departments.Add(d);

            d = new Department();
            d.Id = 1;
            d.Description = "Service";
            context.Departments.Add(d);

            d = new Department();
            d.Id = 1;
            d.Description = "Quality Assurance";
            context.Departments.Add(d);

            Designation desig = new Designation();
            desig.Id = 1;
            desig.Description = "TSM";
            context.Designations.Add(desig);

            desig = new Designation();
            desig.Id = 1;
            desig.Description = "PRM";
            context.Designations.Add(desig);

            desig = new Designation();
            desig.Id = 1;
            desig.Description = "QLT";
            context.Designations.Add(desig);
        }
    }
}
