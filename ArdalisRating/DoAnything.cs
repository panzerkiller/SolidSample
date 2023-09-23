using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public abstract class DoAnythingBase<TArg, TResult>
    {
        public abstract TResult Execute(TArg a);
    }

    //create a class that inherits from the base class


    public class DoAnything<TArg, TResult> : DoAnythingBase<TArg, TResult>
    {
        private Func<TArg, TResult> _func;
        //constructor
        public DoAnything(Func<TArg, TResult> func)
        {
            _func = func;
        }

        //execute method
        public override TResult Execute(TArg a)
        {
            return _func(a);
        }
    }

    //create a DoOneThing class that inherits from the DoAnything class, the function is print a message at console, return True if no error
    //do not use lambda expression
    public class DoOneThing : DoAnything<string, bool>
    {
        public DoOneThing() : base(PrintMessage)
        {
        }

        private static bool PrintMessage(string message)
        {
            Console.WriteLine(message);
            return true;
        }
    }





    
}
