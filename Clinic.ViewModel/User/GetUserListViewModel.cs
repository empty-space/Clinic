using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.ViewModel.User
{
    public class GetUserListViewModel
    {
        public int Page { get; set; } = 1;
        public int CountPerPage { get; set; } = 10;    
    }
}
