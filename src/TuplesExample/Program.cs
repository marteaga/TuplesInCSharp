using System;

namespace TuplesExample
{
    class Program
    {
        static void Main()
        {
            // The CIF to parse
            var cif = "0000111122222";

            // the variables to set
            string yearId, officeId, caseId;

            // call the method to parse
            ParseCif(cif, out yearId, out officeId, out caseId);

            // output to console for now
            Console.WriteLine($"Year Id: {yearId}");
            Console.WriteLine($"Office Id: {officeId}");
            Console.WriteLine($"Case Id: {caseId}");
        }

        /// <summary>
        /// Parse the CIF and set the values of year, office and case parameters passed in
        /// </summary>
        /// <param name="cif"></param>
        /// <param name="yearId"></param>
        /// <param name="officeId"></param>
        /// <param name="caseId"></param>
        private static void ParseCif(string cif, out string yearId, out string officeId, out string caseId)
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
            yearId = cif.Substring(0, 4);
            officeId = cif.Substring(4, 4);
            caseId = cif.Substring(8, 5);
        }
    }
}
