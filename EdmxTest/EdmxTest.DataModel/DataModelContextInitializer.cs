using System.Collections.Generic;
using System.Data.Entity;

namespace EdmxTest.DataModel
{
    public class DataModelContextInitializer : DropCreateDatabaseIfModelChanges<DataModelContext>
    {
        protected override void Seed(DataModelContext context)
        {
            List<Team> teams = new List<Team>
            {
                new Team { Id = 1, Name = "Liverpool" },
                new Team { Id = 2, Name = "Ireland" },
            };

            foreach (var t in teams)
            {
                context.Teams.Add(t);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}