using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCamping
{
    public class EventInfo
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Registered { get; set; }
    }

    public static class EventDatabase
    {
        public static List<EventInfo> Events = new List<EventInfo>
        {
            new EventInfo { Name="Morning Yoga", Date=DateTime.Today.AddHours(9), Description="1 hour relaxing yoga session", ImagePath="images\\symbols\\events\\yoga.jpg", Registered = false },
            new EventInfo { Name="Campfire Night", Date=DateTime.Today.AddHours(20), Description="Music, stories & marshmallows!", ImagePath="images\\symbols\\events\\campfire.jpg", Registered = false },
            new EventInfo { Name="Hiking Adventure", Date=DateTime.Today.AddDays(1).AddHours(8), Description="Guided hike through scenic trails", ImagePath="images\\symbols\\events\\hiking.jpg", Registered = false },
            new EventInfo { Name="Stargazing", Date=DateTime.Today.AddDays(1).AddHours(21), Description="Explore the night sky with telescopes", ImagePath="images\\symbols\\events\\stargazing.jpg", Registered = false },
            new EventInfo { Name="Mushroom Foraging", Date=DateTime.Today.AddDays(2).AddHours(10), Description="Learn to identify edible mushrooms", ImagePath="images\\symbols\\events\\mushroom.jpg", Registered = false }
        };
    }
}
