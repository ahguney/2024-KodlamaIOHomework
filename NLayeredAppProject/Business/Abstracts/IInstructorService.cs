using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IList<Instructor> GetList();
        Instructor GetById(int id);
        void Add(Instructor instructor);

        void Update(Instructor instructor);

        void Delete(Instructor instructor);
    }
}
