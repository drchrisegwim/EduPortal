using EduPortal.Core.Interfaces;
using EduPortal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPortal.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EduPortalDbContext _context;

        public UnitOfWork(EduPortalDbContext context)
        {
            _context = context;
           Courses = new CourseRepository(_context);
           Authors = new AuthorRepository(_context);
        }

        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
