using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public class CrmEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public List<CrmAttribute> Attributes = new List<CrmAttribute>();
        public List<CrmFormula> Formulas = new List<CrmFormula>();
    }

    public class CrmAttribute
    {
        public string Name { get; set; }

        public List<CrmOption> LOptions = new List<CrmOption>();
        public List<CrmOption> ROptions = new List<CrmOption>();
        public List<CrmOption> CommonOptions = new List<CrmOption>();
        public List<CrmOption> LeftOnlyOptions = new List<CrmOption>();
        public List<CrmOption> RightOnlyOptions = new List<CrmOption>();

    }

    public class CrmOptionSet
    {
        public List<CrmOption> Options = new List<CrmOption>();
    }

    public class CrmOption
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }

    public class CrmFormula
    {
        public string Name { get; set; }
        public string SourceEntityName { get; set; }
        public string TargetEntityName { get; set; }
        public ValueName StatusCode { get; set; }
        public ValueName StateCode { get; set; }
        public string TargetEntityProperty { get; set; }
        public ValueName Type { get; set; }
    }

    public struct ValueName
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
