using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}