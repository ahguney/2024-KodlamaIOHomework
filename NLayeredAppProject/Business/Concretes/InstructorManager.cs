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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
           _instructorDal.Delete(instructor);
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(p=>p.Id.Equals(id));
        }

        public IList<Instructor> GetList()
        {
            return _instructorDal.GetList();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
