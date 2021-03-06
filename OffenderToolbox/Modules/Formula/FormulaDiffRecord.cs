using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace MigrationHelper.Modules.Formula
{
    public class FormulaDiffRecord
    {
        public string Name { get; set; }
        public string EntityName { get; set; }
        public CrmFormula LFormula { get; set; }
        public CrmFormula RFormula { get; set; }
        public bool IsDifferent { get; set; } = false;
    }
}
