using Clinic.Domain.DAL;
using Clinic.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Domain.Commands.Base
{
    public abstract class BaseCommand : ICommand
    {
    }

    public abstract class BaseCommand<TContext> : BaseCommand
        where TContext : IDbContext
    {
        protected readonly TContext _context;
        public BaseCommand(TContext context)
        {
            _context = context;
        }
    }
    
}
