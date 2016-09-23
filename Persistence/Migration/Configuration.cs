using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Migration
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        //protected override void Seed(Context.StoreContext context)
        //{
            
        //}
    }
}


