using System;
using System.Collections.Generic;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace AOP
{
    public class LogAfterBehavior : IInterceptionBehavior
    {
        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn methodReturn = getNext()(input, getNext);//执行后面的全部动作

            Console.WriteLine("LogAfterBehaviorStart");
            Console.WriteLine(input.MethodBase.Name);
            foreach (var item in input.Inputs)
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(item));
                //反射&序列化获取更多信息
            }
            Console.WriteLine("LogAfterBehaviorEnd" + methodReturn.ReturnValue);
            return methodReturn;
        }

        public bool WillExecute
        {
            get { return true; }
        }
    }
}
