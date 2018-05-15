using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    public class CSV_parser
    {
        public object[][] Parse_CSV(string csv)
        {
            var rows = csv.Split(';');
            object[][] formatted_csv = new object[rows.Length][];
            int i = 0;

            foreach (var row in rows)
            {
                var values = row.Split(',');
                object[] current_row = new object[values.Length];
                int j = 0;
                foreach (var value in values)
                {
                    current_row[j] = value.Trim();
                    j++;
                }

                formatted_csv[i] = current_row;
                i++;
            }

            return formatted_csv;
        }
    }
}
