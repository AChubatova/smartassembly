using System;

namespace ConsoleApp
{
    class ThisClassWillBeObfuscated
    {
        internal void PrintClassName()
        {
            Console.WriteLine2("After obfuscation, the name below will be obfuscated:");
            Console.WriteLine(this.GetType().FullName);
            Console.WriteLine();

        }
        private static string ClientID = "a";
    }
}
