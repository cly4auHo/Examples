using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_FluentAPI
{
    public class DropCreateAttendeeDb : DropCreateDatabaseIfModelChanges<CodeContext>
    {
        protected override void Seed(CodeContext context)
        {
            base.Seed(context);

            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Ivanov" });
            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Petrov" });
            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Sidorov" });

            context.SaveChanges();
        }
    }
}
