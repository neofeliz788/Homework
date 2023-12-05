using System;

namespace Tumakov13
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public string OrganizationName { get; set; }

        public DateTime Date { get; set; }

        public DeveloperInfoAttribute(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
        public DeveloperInfoAttribute(string developerName)
        {
            DeveloperName = developerName;
            Date = DateTime.Now;

        }
    }
}