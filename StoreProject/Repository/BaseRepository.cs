using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Repository
{
    public abstract class BaseRepository
    {
        protected readonly StoreContext _context;

        public BaseRepository(StoreContext context)
        {
            _context = context;
        }
    }
}
