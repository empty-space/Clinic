using Clinic.Domain.Commands.Base;
using Clinic.Domain.DAL;
using Clinic.Domain.Model;
using Clinic.ViewModel.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Domain.Commands.User
{
    public class SelectUserListCommand : BaseGetCommand<IClinicDbContext,GetUserListViewModel,UserListViewModel>
    {
        public SelectUserListCommand(IClinicDbContext context) : base(context)
        {

        }
        /// <summary>
        /// Пример команды, в которой мы выбираем список юзеров с учетом страниц
        /// </summary>
        /// <param name="viewModelIn"></param>
        /// <returns></returns>
        public override async Task<UserListViewModel> GetAsync(GetUserListViewModel viewModelIn)
        {
            var result = await _context.User
                .Skip(viewModelIn.CountPerPage*(viewModelIn.Page-1))
                .Take(viewModelIn.CountPerPage)
                .Select(u => new UserViewModel { Id = u.Id, PIB = u.PIB }).ToListAsync();

            return new UserListViewModel()
            {
                Page = viewModelIn.Page,
                CountPerPage = viewModelIn.CountPerPage,
                Users = result,
            };
        }
    }
}
