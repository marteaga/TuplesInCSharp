using System;

namespace TuplesExample
{
    class Program
    {
        static void Main()
        {
            // The CIF to parse
            var cif = "0000111122222";

            // call the method to parse
            var caseDetails = ParseCif(cif);

            // output to console for now
            Console.WriteLine($"Year Id: {caseDetails.Item1}");
            Console.WriteLine($"Office Id: {caseDetails.Item2}");
            Console.WriteLine($"Case Id: {caseDetails.Item3}");
        }

        /// <summary>
        /// Parse the CIF and set the values of year, office and case parameters passed in
        /// </summary>
        /// <param name="cif"></param>
        private static (string,string,string) ParseCif(string cif)
        {
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

            // parse the data
            return (cif.Substring(0, 4), cif.Substring(4, 4), cif.Substring(8, 5));
        }

    }
}
