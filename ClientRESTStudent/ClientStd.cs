using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClientRESTStudent
{
    class ClientStd
    {
        public static double GetMoyenne()
        {
            WebClient webClient = new WebClient();
            string response = webClient.DownloadString("http://localhost:55933/Service1.svc/student/moy");
            response = response.Replace('.', ',');
            return double.Parse(response);
        }
        public static List<Student> GetReussis()
        {
            WebClient webClient = new WebClient();
            string response = webClient.DownloadString("http://localhost:55933/Service1.svc/student/reussis");
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            List<Student> studentsReussis = (List<Student>)jsonSerializer.Deserialize<List<Student>>(response);
            response = response.Replace('.', ',');
            return studentsReussis;
        }

        public static List<Student> GetParNom(string motDansNom)
        {
            WebClient webClient = new WebClient();
            string response = webClient.DownloadString("http://localhost:55933/Service1.svc/student/nom" + motDansNom);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            List<Student> etudiantReussis =(List<Student>)jsonSerializer.Deserialize<List<Student>>(response);
            return etudiantReussis;
        }
        public static Student GetParNDA(string nda)
        {
            WebClient webClient = new WebClient();
            string response = webClient.DownloadString("http://localhost:55933/Service1.svc/student/" + nda);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            Student student = (Student)jsonSerializer.Deserialize<Student>(response);
            return student;
        }

    }
}
