using Shindows.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Models
{
    public class LicenceModel
    {
        public int Id                           { get; set; }
        public int Serial                       { get; set; }
        public int Number                       { get; set; }
        public DateTime Date                    { get; set; }
        public DateTime ExpireDate              { get; set; }
        public virtual DriverModel Driver       { get; set; }
        public List<CategoryModel> Categories   { get; set; }

        public static LicenceModel Create(Licence licence)
        {
            var cats = new List<CategoryModel>();

            foreach (var cat in licence.LiceneceHasCategories) 
            {
                cats.Add(new CategoryModel(
                    cat.CategoryId,
                    cat.Category.Value
                ));
            }
            return new LicenceModel
            {
                Id = licence.Id,
                Serial = licence.Serial,
                Number = licence.Number,
                Date = licence.Date,
                ExpireDate = licence.ExpireDate,
                Categories = cats
            };
        }
    }
}
