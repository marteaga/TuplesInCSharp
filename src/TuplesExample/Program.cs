using System;

namespace TuplesExample
{
    class Program
    {
        static void Main()
        {
            var cif = "0000111122222";

            // make sure it's not null
            if (string.IsNullOrWhiteSpace(cif))
            {
                throw new ArgumentException($"Cannot parse CIF if it's empty or null");
            }

            // make sure the length is 13
            if (cif.Length != 13)
            {
                throw new ArgumentException($"CIF value {cif} is length of {cif.Length} but should be 13");
            }

            var yearId = cif.Substring(0, 4);
            var officeId = cif.Substring(4, 4);
            var caseId = cif.Substring(8, 5);

            Console.WriteLine($"Year Id: {yearId}");
            Console.WriteLine($"Office Id: {officeId}");
            Console.WriteLine($"Case Id: {caseId}");
        }
    }
}
