using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalvaryOpebBibleWebsite.Models;

namespace CalvaryOpebBibleWebsite.DAL
{
    public class CalvaryInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CalvaryContext>
    {
        protected override void Seed(CalvaryContext context)
        {
            var events = new List<Event>
            {
                new Event{EventID=1, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=2, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=3, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=4, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=5, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=6, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=7, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=8, EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")}
            };
            events.ForEach(s => context.Event.Add(s));
            context.SaveChanges();
        }
    }
}
