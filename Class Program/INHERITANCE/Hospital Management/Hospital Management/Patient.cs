using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hospital_Management
{
    internal class Patient:Person
    {
        private string diseases;

        public string Diseases
        {
            get { return diseases; }
            set { string diseases; }
        }
        
        public Patient() : base()
        {
            Console.WriteLine("Default patient constructor called !");
        }

        public Patient(string name, int age, string diseases)
        {
            this.diseases = diseases;
        }

    }
}
