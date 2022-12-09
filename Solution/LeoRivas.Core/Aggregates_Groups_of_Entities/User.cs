using LeoRivas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoRivas.Core.Aggregates_Groups_of_Entities
{
    public class User : RootEntity
    {
        public string Location { get; set; } = string.Empty;
        public string TypeOfUser { get; set; } = string.Empty;

    }
}
