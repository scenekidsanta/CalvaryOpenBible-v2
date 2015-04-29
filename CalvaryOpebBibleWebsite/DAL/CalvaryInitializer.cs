using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalvaryOpebBibleWebsite.Models;

namespace CalvaryOpebBibleWebsite.DAL
{
    public class CalvaryInitializer : System.Data.Entity. DropCreateDatabaseAlways<CalvaryContext>
    {
        protected override void Seed(CalvaryContext context)
        {
            var events = new List<Event>
            {
                new Event{EventID=1, EventType="Hooplah", EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="Middle School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-01")},
                new Event{EventID=2, EventType="rawr", EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="Elementary School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-05")},
                new Event{EventID=3, EventType="Hooplah", EventCoordinator="Frank Sinatra", EventLocation="Lane Fair Grounds", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-07")},
                new Event{EventID=4, EventType="umm", EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-11")},
                new Event{EventID=5, EventType="heh", EventCoordinator="Frank Sinatra", EventLocation="Calvary Open Bible", EventMinistry="College", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-15")},
                new Event{EventID=6, EventType="Hooplah", EventCoordinator="Frank Sinatra", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-17")},
                new Event{EventID=7, EventType="yup", EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="No School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-21")},
                new Event{EventID=8, EventType="Hooplah", EventCoordinator="Frank Sinatra", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-04-24")},
                new Event{EventID=9, EventType="pewpew", EventCoordinator="Bob Sasslefras", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-06-01")},
                new Event{EventID=10, EventType="Hooplah", EventCoordinator="Frank Sinatra", EventLocation="Calvary Open Bible", EventMinistry="High School", EventName="Sunday Funday", EventTime=DateTime.Parse("2015-05-01")}
            };
            events.ForEach(s => context.Event.Add(s));
            context.SaveChanges();
        }
    }
}
