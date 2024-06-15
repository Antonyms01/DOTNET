using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    
        class emp
        {
            string fname;
            string lname;
            string mname;
            public emp(string fname,string lname,string mname)
            {
                this.fname = fname;
                this.mname = mname;

            if(lname.Length>4 && lname.Length<16)
            {
                this.lname = lname;
            }
            }

           public emp(string fname,string lname)
            {
                this.fname = fname;
                if (lname.Length > 4 && lname.Length < 16)
                {
                    this.lname = lname;
                }
            }

            public string display()
            {
                return "fname:  " + fname + " lname:  " +lname+ " mname:  " + mname;
                //Console.WriteLine("{0}{1}{2}",fname,lname,mname);
              
            }
        }
        
    class demo
    { 
        static void Main(string[] args)
        {
            emp e1 = new emp("Sohan","Sarode","Ganesh");
            emp e2 = new emp("Mrunal","Bhole","Kiran");
            emp e3 = new emp("Tanish", "Thombare", "Sunil");
            Console.WriteLine(e1.display());
            Console.WriteLine(e2.display());
            Console.WriteLine(e3.display());

        }
    }
}


