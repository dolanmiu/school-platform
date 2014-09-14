using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Gateways
{
    public interface IStudentGateway
    {
        string[,] GetStudentDetails(string parentID);
    }
    public class StudentGateway : IStudentGateway 
    {
        public string[,] GetStudentDetails(string parentID)
        {
            string json =  @"{
              'array': [
                {
                  'firstname': 'bob',
                  'lastname': 'dylan'
                },
                {
                  'firstname': 'dolan',
                  'lastname': 'miu'
                },
                {
                  'firstname': 'dick',
                  'lastname': 'ass'
                }
              ]
            }";
            return new string[,] { { "1", "2", "rtw456456" }, { "3", "4", "656dfg345" }, { "5", "6", "34556gsdfg5" }, { "7", "8", "4563563dgf45" } };
        }
    }
}