/*
Rules for a valid CSV file
    # Separate fields with a delimeter, usually a comma
    # Each record must start on its own line
    # Include a header in the first line of the file with a list of column names with the same delimiter
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using FluentCSV.Models;

namespace FluentCSV
{
    public class CSVReader
    {
        public static IEnumerable<string> GetAllRecords(string FilePathAndName)
        {
            IEnumerable<string> lines = null;

            try
            {
                lines = File.ReadLines(FilePathAndName);

                foreach (string line in lines)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lines;
        }

        public static void GetFieldValue(string line)
        {
            
        }
    }
}
