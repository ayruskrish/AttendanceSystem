using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;


namespace AMS.Data.Configuration
{
    public class CustomDatabaseIntializer:CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            
            base.Seed(context);
        }
    }
}
