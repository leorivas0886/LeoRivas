using LeoRivas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoRivas.Core.Aggregates_Groups_of_Entities
{
    public class Hobby : RootEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan? Schedule_StartTime { get; set; }
        public TimeSpan? Schedule_EndTime { get; set; }
        
    }
}
