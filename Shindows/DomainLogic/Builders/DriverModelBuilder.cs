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
        protected DriverModel _driver;

        public DriverModelBuilder()
        {
            _driver = new DriverModel();
        }

        public DriverModelBuilder(DriverModel driver) => _driver = driver;

        public DriverModelBuilder WithId(int id)
        {
            _driver.Id = id;
            return this;
        }

        public DriverModelBuilder WithName(string name)
        {
            _driver.Name = name.IfNullThrowException();
            return this;
        }

        public DriverModelBuilder WithMiddleName(string middleName)
        {
            _driver.MiddleName = middleName.IfNullThrowException();
            return this;
        }

        public DriverModelBuilder WithLastName(string lastName)
        {
            _driver.LastName = lastName.IfNullThrowException();
            return this;
        }

        public DriverModelBuilder WithEmail(string email)
        {
            _driver.Email = email.IfNullThrowException();
            return this;
        }

        public DriverModelBuilder WithPhone(string phone)
        {
            _driver.Phone = phone.IfNullThrowException();
            return this;
        }

        public DriverModelBuilder WithImage(Image image)
        {
            byte[] binImage = image.ImageToByties();

            // 2 Mb is 2097152 bytes
            if (binImage.Length > 2097152)
                throw new Exception("The picture size must be under 2Mb !!!");
            _driver.Image = binImage;
            return this;
        }

        public DriverModelBuilder WithDescription(string description)
        {
            _driver.Description = description;
            return this;
        }

        public DriverModelAddressBuilder Lives      => new DriverModelAddressBuilder(_driver);
        public DriverModelCompanyBuilder Works      => new DriverModelCompanyBuilder(_driver);
        public DriverModelPassportBuilder Passport  => new DriverModelPassportBuilder(_driver);
        public DriverModel Build() => _driver;

        public class DriverModelAddressBuilder : DriverModelBuilder
        {
            public DriverModelAddressBuilder(DriverModel driver) : base(driver) 
            {
                _driver.Address = new AddressModel();
            }

            public DriverModelAddressBuilder WithAddress(int id, int streetId, string streetName, string houseNumber, string postcode)
            {
                _driver.Address = new AddressModel(
                    id,
                    new StreetModel(streetId, streetName),
                    houseNumber.IfNullThrowException(),
                    postcode.IfNullThrowException());
                return this;
            }
            public DriverModelAddressBuilder At(int streetId, string streetName)
            {
                _driver.Address.Street = new StreetModel(
                    streetId, 
                    streetName.IfNullThrowException());
                return this;
            }
            public DriverModelAddressBuilder WithHouseNumber(string houseNumber)
            {
                _driver.Address.HouseNumber = houseNumber.IfNullThrowException();
                return this;
            }
            public DriverModelAddressBuilder WithPostcode(string postcode)
            {
                _driver.Address.PostCode = postcode.IfNullThrowException();
                return this;
            }
        }
        public class DriverModelPassportBuilder : DriverModelBuilder
        {
            public DriverModelPassportBuilder(DriverModel model) : base(model)
            {
                _driver.Passport = new PassportModel();

            }

            public DriverModelPassportBuilder WithPassport(int id, int serial, int number)
            {
                _driver.Passport = new PassportModel(id, serial, number);
                return this;
            }

            public DriverModelPassportBuilder WithSerial(int serial)
            {
                _driver.Passport.Serial = serial;
                return this;
            }

            public DriverModelPassportBuilder WithNumber(int number)
            {
                _driver.Passport.Number = number;
                return this;
            }
        }
        public class DriverModelCompanyBuilder : DriverModelBuilder
        {
            public DriverModelCompanyBuilder(DriverModel model) : base(model) 
            {
                _driver.Company = new CompanyModel();
            }

            public DriverModelCompanyBuilder AsA(int id, string name)
            {
                _driver.Job = new JobModel(
                    id,
                    name.IfNullThrowException());
                return this;
            }

            public DriverModelCompanyBuilder At(int id, string name)
            {
                _driver.Company = new CompanyModel(
                    id,
                    name.IfNullThrowException());
                return this;
            }
        }
    }
}
