using Shindows.Builders;
using Shindows.Core;
using Shindows.DomainLogic.Builders;
using Shindows.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIN_LIB;

namespace Shindows.Models
{
    public class CarModel
    {
        public Int32 Id                     { get; set; }
        public Int32 Year                   { get; set; }
        public Int32 Weight                 { get; set; }
        public String VIN                   { get; set; }
        public DriverModel Driver           { get; set; }
        public ModelModel Model             { get; set; }
        public ColorModel Color             { get; set; }
        public DriveTypeModel DriveType     { get; set; }

        public static CarModel Create(Car car)
        {
            var carBuilder = new CarModelBuilder(new VINParserBase());

            var driverBuilder = new DriverModelBuilder()
                .WithName(car.Driver.Person.Name)
                .WithMiddleName(car.Driver.Person.MiddleName)
                .WithLastName(car.Driver.Person.LastName)
                .WithImage(car.Driver.Person.Photo.BytiesToImage())
                .WithDescription(car.Driver.Person.Description)
                .WithEmail(car.Driver.Person.Email)
                .WithPhone(car.Driver.Person.Phone)
                .Works
                    .At(car.Driver.CompanyId, car.Driver.Company.Name)
                    .AsA(car.Driver.JobId, car.Driver.Job.Name)
                .Lives
                    .At(car.Driver.Person.Address.StreetId, car.Driver.Person.Address.Street.Street1)
                    .WithHouseNumber(car.Driver.Person.Address.Number)
                    .WithPostcode(car.Driver.Person.Address.Postcode)
                .Passport
                    .WithSerial(car.Driver.Person.Passport.Serial)
                    .WithNumber(car.Driver.Person.Passport.Number)
                .WithId(car.DriverId);

            var completedCar = carBuilder
                .WithId(car.Id)
                .WithVIN(car.VIN)
                .WithWeight(car.Weight)
                .WithYear(car.Year)
                .Model
                    .WithId(car.ModelId)
                    .Called(car.Model.Name)
                    .WithManufacturer(car.Model.ManufaturerId, car.Model.Manufaturer.Name)
                    .WithEngine(car.Model.EngineTypeId, car.Model.EngineType.Type)
                .DriverType
                    .WithId(car.TypeOfDriveId)
                    .WithType(car.TypeOfDrive.Value)
                .Color
                    .WithId(car.ColorId)
                    .WithColorCode(car.Color.Code)
                    .WithValue(car.Color.Value.ToString())
                    .IsMetallic(car.Color.IsMettalic)
                .WithDriver(driverBuilder)
                .Build();

            return completedCar;
        }

    }
}
