﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IList<Course> GetList();
        Course GetById(int id);
        void Add(Course course);

        void Update(Course course);

        void Delete(Course course);
    }
}
