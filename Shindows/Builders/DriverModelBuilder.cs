using Shindows.Core;
using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Builders
{
    public class DriverModelBuilder
    {
        private DriverModel _driver;

        public DriverModelBuilder()
        {
            _driver = new DriverModel();
        }

        public void SetId(int id)
        {
            _driver.Id = id;
        }

        public void SetName(string name)
        {
            _driver.Name = name.IfNullThrowException();
        }

        public void SetMiddleName(string middleName)
        {
            _driver.MiddleName = middleName.IfNullThrowException();
        }
        
        public void SetLastName(string lastName)
        {
            _driver.LastName = lastName.IfNullThrowException();

        }
        
        public void SetJob(int id, string name)
        {
            _driver.Job = new JobModel(
                id, 
                name.IfNullThrowException());

        }

        public void SetCompany(int id, string name)
        {
            _driver.Company = new CompanyModel(
                id,
                name.IfNullThrowException());

        }

        public void SetPassport(int id, int serial, int number)
        {
            _driver.Passport = new PassportModel(id, serial, number);
        }
        
        public void SetAddress(int id, int streetId, string streetName, string houseNumber, string postcode)
        {
            _driver.Address = new AddressModel(
                id,
                new StreetModel(streetId, streetName),
                houseNumber.IfNullThrowException(),
                postcode.IfNullThrowException());
        }
        
        public void SetEmail(string email)
        {
            _driver.Email = email.IfNullThrowException();
        }

        public void SetPhone(string phone)
        {
            _driver.Phone = phone.IfNullThrowException();
        }

        public void SetImage(Image image)
        {
            byte[] binImage = image.ImageToByties();

            // 2 Mb is 2097152 bytes
            if (binImage.Length > 2097152)
                throw new Exception("The picture size must be under 2Mb !!!");
            _driver.Image = binImage;
        }

        public void SetDescription(string description)
        {
            _driver.Description = description;
        }

        public DriverModel GetDriverModel() => _driver;
    }
}
