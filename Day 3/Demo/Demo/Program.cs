using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*create a class student with member variable id, fname give  a validation fname should be min 3 char and max 15 char
 * instance member are private,write getter setter for first name.
create object of student class using getter print its name modify user name using setter, and print modified name.
namespace Demo*/
namespace Demo
{
    class student
    {
        private int id;
        string fname;

        public student(int id,string fname)
        {
            this.id = id;
            name = fname;
            Console.WriteLine(fname);
        }

        public string name
        {
            get
            {
                Console.WriteLine("In Getter");
                return this.fname;
            }

            set 
            {
                Console.WriteLine("In Setter");
                    if(value.Length<3 && value.Length>15)
                {
                    Console.WriteLine("Error");

                }
                    else
                {
                    this.fname= value;
                }
            }
        }

        public string display()
        {
            return "ID: " + id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1=new student(1,"Sohan");
            s1.name = "Rohan";
            Console.WriteLine(s1.display());

        }
    }
}
