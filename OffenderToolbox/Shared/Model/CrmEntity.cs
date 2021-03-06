using Microsoft.Xrm.Sdk;
using MigrationHelper.Modules.Formula;
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
        public string LogicalName { get; set; }
        public string DisplayName { get; set; }

        public List<CrmOptionAttribute> OptionAttributes = new List<CrmOptionAttribute>();
        public List<CrmLookupAttribute> LookupAttributes = new List<CrmLookupAttribute>();
        public List<CrmFormula> Formulas = new List<CrmFormula>();

    }

    public class CrmFormulaEntity: CrmEntity 
    {
        public List<FormulaDiffRecord> FormulaDiffRecords = new List<FormulaDiffRecord>();

        public bool IsDifferent { get; set; } = false;
    }

    public class CrmLookupEntity : CrmEntity
    {
        public List<CrmLookup> LLookups = new List<CrmLookup>();
        public List<CrmLookup> RLookups = new List<CrmLookup>();
        public List<CrmLookup> CommonLookups = new List<CrmLookup>();
        public List<CrmLookup> LeftOnlyLookups = new List<CrmLookup>();
        public List<CrmLookup> RightOnlyLookups = new List<CrmLookup>();

        public string PrimaryNameAttribute { get; internal set; }
        public bool Added { get; internal set; }

    }

    public class CrmAttribute
    {
        public string Name { get; set; }

    }

    public class CrmOptionAttribute : CrmAttribute 
    {
        public List<CrmOption> LOptions = new List<CrmOption>();
        public List<CrmOption> ROptions = new List<CrmOption>();
        public List<CrmOption> CommonOptions = new List<CrmOption>();
        public List<CrmOption> LeftOnlyOptions = new List<CrmOption>();
        public List<CrmOption> RightOnlyOptions = new List<CrmOption>();
    }

    public class CrmLookupAttribute : CrmAttribute
    { 
        public CrmLookupEntity LookupEntity { get; set; }
    }

    public class CrmLookup
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CrmOptionSet
    {
        public List<CrmOption> Options = new List<CrmOption>();
    }

    public class CrmOption
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public bool Usage { get; internal set; } = false;
        public bool AllUsage { get; internal set; } = false;
        public string AllUsageEntities { get; internal set; } = string.Empty;
    }

    public class CrmFormula
    {
        public string Name { get; set; }
        public string SourceEntityName { get; set; }
        public string TargetEntityName { get; set; }
        public Option StatusCode { get; set; }
        public Option StateCode { get; set; }
        public string TargetEntityProperty { get; set; }
        public string TargetEntityproperty { get; internal set; }
        public Option Type { get; set; }
        public Guid Id { get; internal set; }
        public string SourceEntityProperty { get; internal set; }
        public string Description { get; internal set; }
    }


}
