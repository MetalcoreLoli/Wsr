using Shindows.Enities;
using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shindows.Core
{
    public class EntityContextSingleton
    {
        private EntityContextSingleton() { }

        private static readonly Lazy<EntityContext> _instance
            = new Lazy<EntityContext>();
        public static EntityContext Instance => _instance.Value;

        public static IEnumerable<string> GetStatuses()
        {
            var context = Instance;
            return from item in context.LicenceStatus.Select(cat => cat.Value).Distinct()
                   select item;
        }

        public static IEnumerable<string> GetNames()
        {
            var context = Instance;
            return from item in context.Licence.Select(cat => cat.Driver)
                   select item.Person.Name;
        }

        public static IEnumerable<string> GetMiddleNames()
        {
            var context = Instance;
            return from item in context.Licence.Select(cat => cat.Driver)
                   select item.Person.MiddleName;
        }

        public static IEnumerable<string> GetLastNames()
        {
            var context = Instance;
            return from item in context.Licence.Select(cat => cat.Driver)
                   select item.Person.LastName;
        }

        public static IEnumerable<LicenceModel> GetLicences()
        {
            var context = Instance;
            foreach (var item in context.Licence)
                yield return LicenceModel.Create(item);
        }

        public static IEnumerable<string> GetStreet()
        {
            var context = Instance;
            return from street in context.Street
                   select street.Street1;
        }

        public static IEnumerable<string> GetJobs()
        {
            var context = Instance;
            return from street in context.Job
                   select street.Name;
        }

        public static IEnumerable<string> GetCompanies()
        {
            var context = Instance;
            return from street in context.Company
                   select street.Name;
        }

        public static IEnumerable<string> GetManufacturers()
        {
            var context = Instance;
            return from man in context.Manufaturer
                   select man.Name;
        }

        public static IEnumerable<string> GetCategories()
        {
            var context = Instance;
            return from cat in context.Category
                   select cat.Value;
        }

        public static IEnumerable<string> GetColorCodes()
        {
            var context = Instance;
            return from cat in context.Color
                   select cat.Code;
        }

        public static IEnumerable<string> GetTypesOfDrive()
        {
            var context = Instance;
            return from cat in context.TypeOfDrive
                   select cat.Value;
        }

        public static IEnumerable<string> GetModels()
        {
            var context = Instance;
            return from cat in context.Model
                   select cat.Name;
        }
    }
}
