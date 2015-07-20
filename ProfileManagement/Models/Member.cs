using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfileManagement.Domain.Enum;

namespace ProfileManagement.Domain
{
    public class Member:Human
    {
        public Member()
        {
            Spouse = new Human();
            Children = new List<Human>();
            Children.Add(new Human());
            Address = new Address();
        }

        public long Id { get; set; }

        public string MemberId { get; set; }

        public MaritialStatus MaritialStatus { get; set; }

        public Human Spouse { get; set; }

        public List<Human> Children { get; set; }


        public Address Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string OptionalEmail { get; set; }

        public byte[] Photo { get; set; }
    }
}
