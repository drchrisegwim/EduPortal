using EduPortal.Core.Entities;
using EduPortal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPortal.Core.Repositories
{
    public class AuthorRepository : BaseRepository<Author> , IAuthorRepository
    {
        public AuthorRepository(EduPortalDbContext context) : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return EduPortalDbContext.Authors
                //.Include(a => a.Courses)
                .SingleOrDefault(a => a.Id == id);
        }

        public EduPortalDbContext EduPortalDbContext
        {
            get { return Context as EduPortalDbContext; }
        }
    }
}
