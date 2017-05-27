using System;
using System.Collections.Generic;

namespace Clinic.ViewModel.User
{
    public class UserListViewModel
    {
        public List<UserViewModel> Users { get; set; }
        public int Page { get; set; }
        public int CountPerPage { get; set; }
    }

    public class UserViewModel
    {
        public int Id { get; set; }
        public string PIB { get; set; }
    }

}
