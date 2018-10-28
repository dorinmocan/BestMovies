using System.Collections.Generic;

namespace BestMovies.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SignUpFee { get; set; }
        public byte MonthsOfMembership { get; set; }
        public byte DiscountRate { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}