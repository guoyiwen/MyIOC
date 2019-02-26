using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleIOCUnityDemo.Untiy;
using Interface;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace ConsoleIOCUnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var android = UnityIocHelper.Instance.GetService<IPhone>("TestPhone");
            android.Call();


            //single
            var android1 = UnityIocHelper.Instance.GetService<IPhone>();
            android1.Call();

            var android2 = UnityIocHelper.Instance.GetService<IPhone>();
            android2.Call();


            //aop
            var androidAOP = UnityIocHelper.AOPInstance.GetService<IPhone>();
            androidAOP.Call();
        }
    }
}
