using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningASPMVC.Models
{
    interface IStu
    {
        Student GetStudent(string id);
        IQueryable<Student> FindAllStudent();
        IQueryable<Student> FindBykey(string naem, string cla, string Sno);
        void Add(Student stu);
        void Delete(Student Stu);
        void Save();

    }
}
