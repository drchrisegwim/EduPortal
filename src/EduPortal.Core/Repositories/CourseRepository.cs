using EduPortal.Core.Entities;
using EduPortal.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EduPortal.Core.Repositories
{
    class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(EduPortalDbContext context)
           : base(context)
        {
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return EduPortalDbContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return EduPortalDbContext.Courses
                //.Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public EduPortalDbContext EduPortalDbContext
        {
            get { return Context as EduPortalDbContext; }
        }
    }
}
