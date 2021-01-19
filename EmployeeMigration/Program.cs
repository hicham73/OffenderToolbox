using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMigration
{
    class Program
    {

        static Guid buId = new Guid("90d82519-a2df-e811-a955-001dd83047b2");
        static void Main(string[] args)
        {
            var client = new CrmServiceClient(@"Url=https://jms.crm9.dynamics.com;authtype=Office365;username=n-hwahbi@kingcounty.gov;password=Juliku99!;RequireNewInstance=true");

            var service = (IOrganizationService)client.OrganizationWebProxyClient != null ? (IOrganizationService)client.OrganizationWebProxyClient : (IOrganizationService)client.OrganizationServiceProxy;

            var role1Name = "KC Officer (base for Adult)";
            //var role2Name = "";
            //var role3Name = "";

            var userId = new Guid("09c7c597-f212-eb11-a813-001dd8018230");

            AddRole(service, role1Name, userId);
            //AddRole(service, role2Name, userId);
            //AddRole(service, role3Name, userId);

        }

        public static void AddRole(IOrganizationService service, string name, Guid userId)
        {
            if (string.IsNullOrEmpty(name))
                return;

            var role = FindRole(service, name);
            //AssignRoleToUser(service, role, userId);

            var team = FindTeam(service, name);
            //AddUserToTeam(service, team, userId);

        }

        private static void AddUserToTeam(IOrganizationService service, Entity team, Guid userId)
        {
            AddMembersTeamRequest addRequest = new AddMembersTeamRequest();

            // Set the AddMembersTeamRequest TeamID property to the object ID of 
            // an existing team.
            addRequest.TeamId = team.Id;

            // Set the AddMembersTeamRequest MemberIds property to an 
            // array of GUIDs that contains the object IDs of one or more system users.
            addRequest.MemberIds = new Guid[] { userId };

            // Execute the request.
            service.Execute(addRequest);
        }

        private static void AssignRoleToUser(IOrganizationService service, Entity role, Guid userId)
        {
            service.Associate("systemuser",
                              userId,
                              new Relationship("systemuserroles_association"),
                              new EntityReferenceCollection() { role.ToEntityReference() });
        }

        public static Entity FindRole(IOrganizationService service, string roleName)
        {
            Entity role;
            QueryExpression query = new QueryExpression
            {
                EntityName = "role",
                ColumnSet = new ColumnSet("roleid"),
                Criteria = new FilterExpression
                {
                    Conditions =
                            {

                                new ConditionExpression
                                {
                                    AttributeName = "name",
                                    Operator = ConditionOperator.Equal,
                                    Values = {roleName}
                                }
                            }
                }
            };

            role = service.RetrieveMultiple(query).Entities.FirstOrDefault();
            if(role == null)
            {
                role = new Entity("role");
                role["name"] = roleName;
                role["businessunitid"] = new EntityReference("businessunit",buId);
                role.Id = service.Create(role);

            }

            return role;
        }

        public static Entity FindTeam(IOrganizationService service, string teamName)
        {
            Entity team;
            QueryExpression query = new QueryExpression
            {
                EntityName = "team",
                ColumnSet = new ColumnSet("teamid"),
                Criteria = new FilterExpression
                {
                    Conditions =
                            {

                                new ConditionExpression
                                {
                                    AttributeName = "name",
                                    Operator = ConditionOperator.Equal,
                                    Values = {teamName}
                                }
                            }
                }
            };

            team = service.RetrieveMultiple(query).Entities.FirstOrDefault();
            if (team == null)
            {
                team = new Entity("team");
                team["name"] = teamName;
                team["businessunitid"] = new EntityReference("businessunit",buId);
                team.Id = service.Create(team);
            }

            return team;
        }

        // Set-MsolUserLicense -UserPrincipalName "davidchew@contoso.com" -AddLicenses "Contoso:ENTERPRISEPACK"
        // from https://docs.microsoft.com/en-us/powershell/module/msonline/set-msoluserlicense?view=azureadps-1.0
    }
}
