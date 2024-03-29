﻿using System.Web;
using CsvParser.Domain;

namespace CsvParser.Contracts
{
    public interface ICsvFileHandler
    {
        /// <summary>
        /// Takes in an input stream from HttpPostedFileBase and returns a parsed CsvTable object
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        CsvHandleResult ParseCsvFile(HttpPostedFileBase inputFile, bool containsHeader);
    }
}
