using Microsoft.Crm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public class CSVFile
    {

        public string FileName { get; set; }

        public List<CSVBloc> Blocs { get; set; } = new List<CSVBloc>();

        public void Export()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName))
            {
                foreach (var bloc in Blocs)
                {
                    if (bloc.Rows.Count > 0)
                    {
                        var ens = bloc.EntityName.Split(',');
                        foreach (var en in ens)
                        { 
                            file.WriteLine($"{en},{bloc.AttributeName},,");
                        }
                        foreach (var row in bloc.Rows)
                        {
                            file.WriteLine(row.ToString());
                        }
                    }
                }
            }
        }

        
    }

    public class CSVBloc 
    {
        public string EntityName { get; set; }
        public string AttributeName { get; set; }

        public List<CSVRow> Rows { get; set; } = new List<CSVRow>();

        public void AddRow(string[] cols)
        {
            var row = new CSVRow();
            foreach (var col in cols)
            {
                var _col = col == null ? string.Empty : col;

                if (_col != null && _col.IndexOf(",") > -1)
                    _col = $"\"{_col}\"";
                
                row.Columns.Add(_col);
            }
            Rows.Add(row);
        }
        
    }

    public class CSVRow
    {
        public List<string> Columns = new List<string>();

        public override string ToString()
        {
            var str = string.Join(",", Columns.ToArray());
            return $",,{str}";
        }

    }
}
