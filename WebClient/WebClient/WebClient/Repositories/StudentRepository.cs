using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Domain;
using WebClient.Domain.Factories;
using WebClient.Gateways;

namespace WebClient.Repositories
{
    public interface IStudentRepository
    {
        IList<StudentModel> GetStudents(string parentID);
    }
    public class StudentRepository : IStudentRepository
    {
        private IStudentGateway gateway;
        private IStudentFactory factory;

        public StudentRepository(IStudentGateway gateway, IStudentFactory factory) 
        {
            this.gateway = gateway;
            this.factory = factory;
        }
        public IList<StudentModel> GetStudents(string parentID) 
        {
            IList<StudentModel> students = new List<StudentModel>();
            string[,] studentDetails = this.gateway.GetStudentDetails(parentID);

            for(int i = 0; i < studentDetails.GetLength(0); i++) 
            {
                students.Add(this.factory.Instance(studentDetails[i, 0], studentDetails[i, 1]));
            }

            return students;
        }
    }
}