using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;


namespace AMS.Data.Configuration
{
    public class CustomDatbaseInitilizer :DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //we can write our data initializer here

            base.Seed(context);
        }
    }
}
