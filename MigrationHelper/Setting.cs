using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public static class Setting
    {
        public static string ConnString1 { get; set; }
        public static string ConnString2 { get; set; }
        public static string OptionEntitiesValue { get; set; }
        public static string LookupEntitiesValue { get; set; }
        public static string[] MigEntitiesList { get; set; }
        public static string[] LookupSchemaNamesList { get; set; }
        public static string[] LookupDisplayNameList { get; set; }

        public static List<MetaEntity> LookupEntities { get; set; } = new List<MetaEntity>();
        public static List<MetaEntity> OptionEntities { get; set; } = new List<MetaEntity>();

        
        public static void Load()
        {
            ConnString1 = ConfigurationManager.AppSettings["connstring1"];
            ConnString2 = ConfigurationManager.AppSettings["connstring2"];
            OptionEntitiesValue = ConfigurationManager.AppSettings["option-entities"];
            LookupEntitiesValue = ConfigurationManager.AppSettings["lookup-entities"];

            MigEntitiesList  = ConfigurationManager.AppSettings["mig-entities"].Split(',');
            LookupSchemaNamesList = ConfigurationManager.AppSettings["lookup-entities"].Split(',');

            LookupDisplayNameList = new string[] {
                    "System Settings"
                    ,"Access Levels"
                    ,"Activity Log Types"
                    ,"Alert Types"
                    ,"Alert"
                    ,"Appointment Types"
                    ,"Assessment Type"
                    ,"Background Check Purposes"
                    ,"Background Checklists"
                    ,"Badge Types"
                    ,"Behaviors"
                    ,"Behavior Levels"
                    ,"Behavior Response Actions"
                    ,"Booking Types"
                    ,"Cancellation Reasons"
                    ,"Case and Charge Release Codes"
                    ,"CCD Programs"
                    ,"Charge Statuses"
                    ,"Classification Review Reasons"
                    ,"Classification Types"
                    ,"Conditions of Conduct"
                    ,"Contraband Types"
                    ,"Contraband"
                    ,"Counties"
                    ,"Countries"
                    ,"Court Appearance Reasons"
                    ,"Courtrooms"
                    ,"CHRC Approval Route"
                    ,"Criminogenic Needs"
                    ,"Custody Statuses"
                    ,"Diet Types"
                    ,"Divisions"
                    ,"DOC Infraction Codes"
                    ,"Drug Test Type"
                    ,"Education Levels"
                    ,"EHD Alert Types"
                    ,"EHD Equipment"
                    ,"EHD Equipment Types"
                    ,"Facility Approved Items"
                    ,"Fee Types"
                    ,"Gang Organizations"
                    ,"Good Time Category"
                    ,"Grievance Categories"
                    ,"Grievance Sections"
                    ,"Homeless Mailing Locations"
                    ,"Incentive Day Scorings"
                    ,"Incentive Level Scorings"
                    ,"Incentive Items"
                    ,"Incident Types"
                    ,"Interpreter Providers"
                    ,"Job Categories"
                    ,"Keep Separate Reasons"
                    ,"Key Categories"
                    ,"Key Locations"
                    ,"Kite Categories"
                    ,"Kite Requests"
                    ,"Kite Resolutions/Outcomes"
                    ,"Kite Response Templates"
                    ,"Languages"
                    ,"Locations"
                    ,"Locker Locations"
                    ,"Log Note Types"
                    ,"Mail Prohibited Reasons"
                    ,"Mail Types"
                    ,"Meal Hold Back Reasons"
                    ,"Medical Conditions"
                    ,"Medical Note Types"
                    ,"Medication Lockers"
                    ,"Medications"
                    ,"Observation Codes"
                    ,"Offenses"
                    ,"Offense Grades"
                    ,"Outside Program"
                    ,"Performance Metrics"
                    ,"Performance Rating"
                    ,"Plan Requirements"
                    ,"Plan Requirement Categories"
                    ,"Pregnancy Problems"
                    ,"Programs"
                    ,"Program Case Event Statuses"
                    ,"Program Case Event Types"
                    ,"Program Dispositions"
                    ,"Program Enrollment Reasons"
                    ,"Program Types"
                    ,"Property Categories"
                    ,"Property Locations"
                    ,"Property Items"
                    ,"Registration Types"
                    ,"Release Of Information Details"
                    ,"Release Reasons"
                    ,"Relationships"
                    ,"Religions"
                    ,"Reporting Groups"
                    ,"Responses"
                    ,"Restitution Items"
                    ,"Restrictive Housing Types"
                    ,"Rewards"
                    ,"RH Check Types"
                    ,"Risk Level"
                    ,"Scar/Mark Locations"
                    ,"Scar/Mark Types"
                    ,"School Districts"
                    ,"Search Reasons"
                    ,"Subject Security Check Types"
                    ,"Security Levels"
                    ,"Sentence Types"
                    ,"Service and Offerings"
                    ,"Sexual History"
                    ,"Shift Log Posts"
                    ,"Specific Duty Posts"
                    ,"States"
                    ,"Strengths"
                    ,"Subject Note Templates"
                    ,"Subject Note Types"
                    ,"Surveillance Level"
                    ,"Temporary Release Types"
                    ,"Transfer Reasons"
                    ,"Transportation Request Locations"
                    ,"Transportation Request Reasons"
                    ,"Transportation Request Types"
                    ,"Transportation Types"
                    ,"Use of Force Levels"
                    ,"Use of Force Resistance Levels"
                    ,"Use of Force Types"
                    ,"Vehicle Makes"
                    ,"Vehicle Models"
                    ,"Violation Classes"
                    ,"Violations"
                    ,"Visit Denial Reasons"
                    ,"Visit Locations"
                    ,"Visit Reasons"
                    ,"Visit Reason Details"
                    ,"Visit Types"
                    ,"Visitor Denial Reasons"
                    ,"Visitor Property Locations"
                    ,"Volunteer Types"
                    ,"Work Site Restrictions"
                    ,"Youth Behavior Levels"};
            


        }

    }
}
