using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            
        }

        public void OptionSetMap()
        {

            Dictionary<string, List<MapItem>> map = new Dictionary<string, List<MapItem>>();

            var lines = File.ReadAllLines(@"C:\Users\hwahbi\OneDrive - DXC Production\Documents\KC\OptionSetMap.csv");
            foreach (var line in lines)
            {
                var tokens = line.Split(',');

                var entityname = tokens[0];
                var optionname = tokens[1];

                var item = new MapItem()
                {
                    lvalue = tokens[3],
                    rvalue = tokens[5]
                };

                List<MapItem> items;

                map.TryGetValue(optionname, out items);

                if (items == null)
                {
                    items = new List<MapItem>();
                    map.Add(optionname, items);
                }

                items.Add(item);

            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\hwahbi\OneDrive - DXC Production\Documents\KC\OptionSetMap.sql"))
            {
                foreach (var key in map.Keys)
                {
                    file.WriteLine($"create function {key}(@val varchar(255)) returns varchar(255)");
                    file.WriteLine($"as begin");
                    file.WriteLine($"    return case");
                    var items = map[key];

                    foreach (var item in items)
                    {
                        file.WriteLine($"            when @val = '{item.lvalue}' then '{item.rvalue}'");
                    }
                    file.WriteLine($"            else @val");
                    file.WriteLine($"    end");
                    file.WriteLine($"end");
                    file.WriteLine($"go ------------------------------------------------------------");


                }
            }
        }




    }

    class MapItem {
        public string lvalue { get; set; } 
        public string rvalue { get; set; }
    }
}
