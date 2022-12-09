using LeoRivas.Core.Aggregates_Groups_of_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoRivas.Core.Entities
{
    public class Persona : RootEntity
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; }
        public ICollection<Hobby> Hobbies { get; set; }


    }
}
