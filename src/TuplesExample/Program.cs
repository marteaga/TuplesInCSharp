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
            Console.WriteLine($"Year Id: {caseDetails.Year}");
            Console.WriteLine($"Office Id: {caseDetails.OfficeId}");
            Console.WriteLine($"Case Id: {caseDetails.CaseId}");
        }

        /// <summary>
        /// Parse the CIF and set the values of year, office and case parameters passed in
        /// </summary>
        /// <param name="cif"></param>
        private static Case ParseCif(string cif)
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
            return new Case
            {
                Year = cif.Substring(0, 4),
                OfficeId = cif.Substring(4, 4),
                CaseId = cif.Substring(8, 5)

            };
        }

        public class Case
        {
            /// <summary>
            /// Gets or sets the year the case was created
            /// </summary>
            public string Year { get; set; }
            /// <summary>
            /// Gets or sets the office that created the case
            /// </summary>
            public string OfficeId { get; set; }
            /// <summary>
            /// Gets or sets the case id for the cause
            /// </summary>
            public string CaseId { get; set; }
            /// <summary>
            /// Returns a string that represents the current object which is a composit of the Year, OfficeId, CaseId properties
            /// </summary>
            /// <returns>A string that represents the current object which is a composit of the Year, OfficeId, CaseId properties</returns>
            public override string ToString()
            {
                return $"{Year}{OfficeId}{CaseId}";
            }
        }
    }
}
