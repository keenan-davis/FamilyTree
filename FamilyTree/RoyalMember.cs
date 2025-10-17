using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class RoyalMember
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        
        public RoyalMember(string name, string title, DateTime birthDate)
        {
            Name = name;
            Title = title;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"{Title} {Name} (b. {BirthDate.ToShortDateString()})";
        }
    }
}
