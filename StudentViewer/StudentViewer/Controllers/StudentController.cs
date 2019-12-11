using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository;
using Repository.Common;

namespace StudentViewer.Controllers
{
   
    public class StudentController : ApiController
    {
        private readonly IGenericRepository<Student> _studentRepository;
        public StudentController(IGenericRepository<Student> studentRepository)
        {
            
            _studentRepository = studentRepository;
        }
         
        public IQueryable<Student> GetStudentList()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
