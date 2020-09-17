using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper.Modules.OptionSetModule
{
    public class LookupManager
    {

        internal static void Compare()
        {
            foreach (var cl in App.CrmLookupEntities)
            {
                cl.CommonLookups = cl.LLookups.Where(lo => cl.RLookups.Where(ro => ro.Name == lo.Name).Any()).ToList();
                cl.LeftOnlyLookups = cl.LLookups.Where(lo => !cl.RLookups.Where(ro => ro.Name == lo.Name).Any()).ToList();
                cl.RightOnlyLookups = cl.RLookups.Where(ro => !cl.LLookups.Where(lo => lo.Name == ro.Name).Any()).ToList();
            }

        }


    }
}
