using System.Collections.Generic;

namespace Vidly.Models.ViewModel
{
    public class CustomerViewModel
    {

        public List<MembershipType> ViewModelMembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}