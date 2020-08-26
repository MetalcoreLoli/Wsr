using Shindows.Enities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Models
{
    public class DriverModel
    {
        public Int32 Id                     { get; set; }
        public string Name                  { get; set; }
        public string MiddleName            { get; set; }
        public string LastName              { get; set; }
        public JobModel Job                 { get; set; }
        public CompanyModel Company         { get; set; }
        public PassportModel    Passport    { get; set; }
        public AddressModel     Address     { get; set; }
        public string Email                 { get; set; }
        public string Phone                 { get; set; }
        public byte[] Image                 { get; set; }
        public string Description           { get; set; }

        /// <summary>
        /// Фабричный метод для создания модели водителя
        /// </summary>
        /// <param name="driver">представление таблицы водитель</param>
        /// <returns></returns>
        public static DriverModel CreateFrom(Driver driver) 
        {
            return new DriverModel
            {
                Id          = driver.Id,
                Name        = driver.Person.Name,
                MiddleName  = driver.Person.MiddleName,
                LastName    = driver.Person.LastName,
                Job         = new JobModel(driver.JobId, driver.Job.Name),
                Company     = new CompanyModel(driver.CompanyId, driver.Company.Name),
                Passport    = new PassportModel(
                    driver.Person.PassportId, 
                    driver.Person.Passport.Serial, 
                    driver.Person.Passport.Number),

                Address = new AddressModel(
                    driver.Person.AddressId,
                    new StreetModel(
                        driver.Person.Address.StreetId, 
                        driver.Person.Address.Street.Street1),
                    driver.Person.Address.Number,
                    driver.Person.Address.Postcode),
                Email = driver.Person.Email,
                Image = driver.Person.Photo,
                Description = driver.Person.Description
            };
        }
    }
}
