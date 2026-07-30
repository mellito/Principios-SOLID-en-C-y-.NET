using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Contract
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}