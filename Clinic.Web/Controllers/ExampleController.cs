using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clinic.Domain.Model;
using Clinic.Domain.DAL;
using Clinic.Domain.Commands.User;
using Clinic.ViewModel.User;

namespace Clinic.Web.Controllers
{
    public class ExampleController : Controller
    {
        private readonly SelectUserListCommand _selectUserListCommand;
        public ExampleController(SelectUserListCommand selectUserListCommand)
        {
            _selectUserListCommand = selectUserListCommand;
        }
        public async Task<IActionResult> UserList()//GetUserListViewModel viewModelIn)
        {
            var viewModel = await _selectUserListCommand.GetAsync(new GetUserListViewModel());
            return View(viewModel);
        }
    }
}
