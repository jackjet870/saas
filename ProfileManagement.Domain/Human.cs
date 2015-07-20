using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfileManagement.Domain.Enum;

namespace ProfileManagement.Domain
{
    public class Human
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
    }
}
