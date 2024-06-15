using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Model
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public float salary { get; set; }


        public override string ToString()
        {
            return string.Format("ID:" + id + " Name: " + name + " Salary:" + salary);
        }



    }

}
