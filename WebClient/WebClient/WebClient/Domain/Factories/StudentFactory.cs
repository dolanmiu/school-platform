using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Domain.Factories
{
    public interface IStudentFactory
    {
        StudentModel Instance(string firstname, string lastname);
    }
    public class StudentFactory : IStudentFactory
    {
        public StudentModel Instance(string firstname, string lastname)
        {
            return new StudentModel
            {
                FirstName = firstname,
                LastName = lastname
            };
        }
    }
}