using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(p=>p.Id.Equals(id));
        }

        public IList<Course> GetList()
        {
            return _courseDal.GetList();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
