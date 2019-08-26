using System;
using CsvParser.Contracts;

namespace CsvParser.Web.Core
{
    /// <summary>
    /// This file must be unit tested
    /// </summary>
    public class ValidationService : IValidationService
    {
        /// <summary>
        /// Takes in a file name and determines whether it is a csv file or not.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool IsCsvFile(string filename)
        {
            //TODO fill in your logic here
            throw new NotImplementedException();
        }
    }
}
