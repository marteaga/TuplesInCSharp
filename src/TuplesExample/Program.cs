using System;

namespace TuplesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cif = "0000111122222";
            var yearId = cif.Substring(0, 4);
            var officeId = cif.Substring(4, 4);
            var caseId = cif.Substring(8, 5);

            Console.WriteLine($"Year Id: {yearId}");
            Console.WriteLine($"Office Id: {officeId}");
            Console.WriteLine($"Case Id: {caseId}");
        }
    }
}
