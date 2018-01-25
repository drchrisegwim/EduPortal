using EduPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPortal.Core.Interfaces
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
