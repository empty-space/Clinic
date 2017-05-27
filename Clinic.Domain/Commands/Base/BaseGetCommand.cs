using Clinic.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Domain.Commands.Base
{
    public abstract class BaseGetCommand<TContext, TViewModel, TResult> : BaseCommand<TContext>
        where TContext : IDbContext
    {
        public BaseGetCommand(TContext context) : base(context)
        {
        }

        public abstract Task<TResult> GetAsync(TViewModel viewModel);

        //todo
        //public abstract class BaseUpdateCommand<TContext, TViewModel, TResult> : BaseCommand<TContext>
        //    where TContext : IDbContext
        //{
        //    public BaseUpdateCommand(TContext context) : base(context)
        //    {
        //    }

        //    public abstract Task<TResult> UpdateAsync(TViewModel viewModel);
        //}


        //public abstract class BaseDeleteCommand<TContext, TViewModel, TResult> : BaseCommand<TContext>
        //    where TContext : IDbContext
        //{
        //    public BaseDeleteCommand(TContext context) : base(context)
        //    {
        //    }

        //    public abstract Task<TResult> DeleteAsync(TViewModel viewModel);
        //}    
    }


}
