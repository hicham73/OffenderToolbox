using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public static class App
    {
        public static List<CrmEntity> MigEntities { get; set; } = new List<CrmEntity>();
        public static List<CrmLookupEntity> CrmLookupEntities { get; set; } = new List<CrmLookupEntity>();
        public static List<CrmEntity> AllEntities { get; set; } = new List<CrmEntity>();

        public static void InitApp()
        {
            Shared.Setting.Load();

            CrmConnManager.Connect();

        }


        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
        }

        public static void LoadAllEntities() {

            CrmConnManager.Connect();

            RetrieveAllEntitiesRequest req = new RetrieveAllEntitiesRequest
            {
                RetrieveAsIfPublished = true,
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveAllEntitiesResponse res = (RetrieveAllEntitiesResponse)CrmConnManager.LService.Execute(req);

            foreach (var em in res.EntityMetadata)
            {
                if (em.ObjectTypeCode != null)
                {

                    var mige = new CrmEntity()
                    {
                        Code = (int)em.ObjectTypeCode,
                        LogicalName = em.LogicalName,
                        DisplayName = em.DisplayName?.UserLocalizedLabel?.Label
                    };

                    AllEntities.Add(mige);
                    App.MigEntities.Add(mige);

                    foreach (var attr in em.Attributes)
                    {

                        if (attr.AttributeType.Value == AttributeTypeCode.Picklist)
                        {
                            mige.OptionAttributes.Add(new CrmOptionAttribute()
                            {
                                Name = attr.LogicalName
                            });
                        }
                        else if (attr.AttributeType.Value == AttributeTypeCode.Lookup)
                        {
                            var am = attr as LookupAttributeMetadata;

                            if (am.Targets.Count() > 0)
                            {
                                var target = am.Targets[0];
                                if (target.StartsWith("tri_") || target.StartsWith("kc_"))
                                {
                                    var lookupEntity = App.CrmLookupEntities.Where(e => e.LogicalName == target).FirstOrDefault();
                                    if (lookupEntity == null)
                                    {
                                        lookupEntity = new CrmLookupEntity()
                                        {
                                            LogicalName = target
                                        };

                                        App.CrmLookupEntities.Add(lookupEntity);
                                    }
                                    mige.LookupAttributes.Add(new CrmLookupAttribute()
                                    {
                                        Name = attr.LogicalName,
                                        LookupEntity = lookupEntity

                                    });
                                }

                            }

                        }
                    }

                }
            }

            foreach (var e in res.EntityMetadata)
            {
                var lookupEntity = App.CrmLookupEntities.Where(x => x.LogicalName == e.LogicalName).FirstOrDefault();
                if (lookupEntity != null)
                {
                    lookupEntity.PrimaryNameAttribute = e.PrimaryNameAttribute;
                    if (lookupEntity.LogicalName == "tri_state")
                        lookupEntity.PrimaryNameAttribute = "tri_statename";
                }
            }
        }
    }
}
