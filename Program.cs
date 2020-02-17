using System;

namespace helloWorld {
    class Program {
        static void Main (string[] args) {
            var myclass = new MyClass();
            Console.WriteLine ($"Hello World! {myclass.ReturnMessage()}");
        }
    }
}