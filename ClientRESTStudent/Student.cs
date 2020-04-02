using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTStudent
{
    class Student
    {
        private string nda;
        private string nom;
        private double note;

        public override string ToString()
        {
            return nda + " : " + nom + " : " + note; 
        }
    }
}
