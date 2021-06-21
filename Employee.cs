using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addis_River_Side_Attendance_System
{
    class Employee
    {
       public int pnum, acc, fid;
       public string finame, faname, gfname, dob, hdate, ldate;
       public char gen;
        public Employee(string finame, string faname, string gfname, string dob, string hdate, int pnum, int acc, int fid, char gen)
        {          
            this.finame = finame;
            this.faname = faname;
            this.gfname = gfname;
            this.dob = dob;
            this.hdate = hdate;
            this.pnum = pnum;
            this.acc = acc;
            this.gen = gen;
        }

        public bool validation()
        {
            bool valid = false;
            if (finame.Contains("0") || finame.Contains("1") || finame.Contains("2") || finame.Contains("3") || finame.Contains("4") || finame.Contains("5") || finame.Contains("6") || finame.Contains("7") || finame.Contains("8") || finame.Contains("9"))
            {
                valid = false;
            }
            else if (faname.Contains("0") || faname.Contains("1") || faname.Contains("2") || faname.Contains("3") || faname.Contains("4") || faname.Contains("5") || faname.Contains("6") || faname.Contains("7") || faname.Contains("8") || faname.Contains("9"))
            {
                valid = false;
            }
            else if (gfname.Contains("0") || gfname.Contains("1") || gfname.Contains("2") || gfname.Contains("3") || gfname.Contains("4") || gfname.Contains("5") || gfname.Contains("6") || gfname.Contains("7") || gfname.Contains("8") || gfname.Contains("9"))
            {
                valid = false;
            }
            else if (pnum != 10)
            {
                valid = false;
            }
            //add more validations
            else
                valid = true;
            return valid;
        }
    }
    class Admin
    {
        public string finame, faname, gfname, uname, pw;      
    }
}
