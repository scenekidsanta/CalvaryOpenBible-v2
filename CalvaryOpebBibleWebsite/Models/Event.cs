using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalvaryOpebBibleWebsite.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required]
        // Will allow us to categorize events as SundayMornings, YouGroupThursdayNights, WeeklyActivitiesOfInterest, or ComingEvents
        // Might consider changing the names of event types, or coming up with a new system
        // TODO: populate a list of the event types for user to choose from when creating an event
        public string EventType { get; set; }

        [Required]
        // Group that the event is targeting.  Will allow for displaying in the proper area when linked with ministry page
        // TODO: populate list of ministry types or user to choose from
        public string EventMinistry { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventLocation { get; set; }
        public DateTime EventTime { get; set; }

        // Thought this might be good to have, but could definitely get rid of
        public string EventCoordinator { get; set; }
    }
}