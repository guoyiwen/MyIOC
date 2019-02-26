using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Services
{
    public class AndroidPhone : IPhone
    {
        public AndroidPhone()
        {
            Console.WriteLine("{0}构造函数", this.GetType().Name);
        }
        public void Call()
        {
            Console.WriteLine("{0}打电话", this.GetType().Name); ;
        }
    }
}
