using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASPMVC.Models
{
    public class Stu:IStu
    {
        MyStudentEntities1 db = new MyStudentEntities1();

        public Student GetStudent(string id)
        {
            return db.Students.SingleOrDefault(s => string.Equals(s.Sno,id));
        }
        public IQueryable<Student> FindAllStudent()
        {
            return db.Students;
        }
        public IQueryable<Student>FindBykey(string name,string cla,string Sno)
        {
            return null;
        }
         public void Add(Student stu)
        {
            db.Students.Add(stu);
        }
        public void Delete(Student stu)
        {
            db.Students.Remove(stu);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}