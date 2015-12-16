using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pharmacy1
{
    class customer
    {
        private string name;
        public static int Id = 1;
        public customer(string name )
        {
            this.name = name;
            Id++;

        }
        public customer()
        {
            //Defult Const
        }
        public string Name
        {

            get { return name; }
            set { name = value; }
        }
            
    }
}
