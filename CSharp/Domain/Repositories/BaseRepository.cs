using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp;

namespace CSharp.Domain.Repositories
{
    public abstract class BaseRepository
    {

        protected readonly CSharpDbContext context;

        public BaseRepository(CSharpDbContext c)
        {
            context = c;
        }
    }
}
