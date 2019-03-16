using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDemo
{
    class Employee
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        string rFID;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Adress { get => adress; set => adress = value; }
        public string RFID { get => rFID; set => rFID = value; }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
