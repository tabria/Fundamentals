using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalException
{
    class MyExeption : Exception
    {
        public MyExeption() : base("My first exception is awesome!!!")
        {

        }

    }
}
