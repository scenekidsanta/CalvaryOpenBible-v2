using CalvaryOpebBibleWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalvaryOpebBibleWebsite.DAL
{
    public class CalvaryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CalvaryContext>
    {

        protected override void Seed(CalvaryContext context)
        {
            var belief = new List<Belief>
            {
            new Belief{ BeliefID= 1, BeliefTitle="The Bible", BeliefDetails="We believe the Bible is the inspired Word of God and the only infallible guide and rule of our faith and practice. (Psalm 119:89; Matthew 24:35; 2 Timothy 2:15, 3:16-17; 2 Peter 1:19-21.)"},
            };

            belief.ForEach(s => context.Belief.Add(s));
            context.SaveChanges();

            var Events = new List<Event>
            {
            new Event{EventID=1,EventType="SundayMorning",EventName="First Service",EventLocation="Calvary Open Bible",EventMinistry="General", EventTime = DateTime.Parse("2015-04-12-10:00")},
      
            };
            Events.ForEach(s => context.Event.Add(s));
            context.SaveChanges();
            var Pastors = new List<Pastor>
            {
            new Pastor{PastorID=1, Title="Head Pastors", PastorName="Kirk & Diane Stickler",Details="Kirk and Diane Stickler joined our staff in September of 2004.  Prior to that, Kirk was a real estate agent in our area.  Feeling the call of God to serve in full time ministry, they excitedly made the jump from the business world to the greatest occupation in the world! Coming from a great Christian home, Kirk grew up in both Rapid City, South Dakota, and Eugene, Oregon. With his father being a contractor, it was natural that Kirk would follow in his steps. Prior to and during his real estate career, he has been involved in the construction of many homes and small developments. He loves motorcycles, cars and any other toy with a motor. He is currently building a 1936 Chevy street rod. Diane grew up on the Oregon coast in Coos Bay, and also came from a great Christian home. She moved to Springfield as a freshman in high school after the death of her parents. She loves crafts, stamping, being a mom and playing the piano. Diane is also overseeing our Women's Ministry at Calvary. Kirk & Diane have three children.  The Sticklers love to travel, camp, hike, bike ride and explore. "},
           
            };
            Pastors.ForEach(s => context.Pastor.Add(s));
            context.SaveChanges();
        }
    }

}