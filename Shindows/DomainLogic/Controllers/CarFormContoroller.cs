using Shindows.Core;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Controllers
{
    public class CarFormContoroller
    {
        public IDialogService DialogService { get; }

        public CarFormContoroller(IDialogService dialogService)
        {
            DialogService = dialogService;
        }

        public void Insert(CarModel car)
        {
            var context = EntityContextSingleton.Instance;

            context.Car.Add (new Enities.Car 
            {
                DriverId =  car.Driver.Id,
                ColorId = EntityContextSingleton.FindColorOrDefault(color => color.Code.Equals(car.Color.Code)).Id,
                ModelId = EntityContextSingleton.FindModelOrDefault(model => model.Name.Equals(car.Model.Name)).Id,
                TypeOfDriveId = EntityContextSingleton.FindTypeOfDriveOrDefault(type => type.Value.Equals(car.DriveType.Type)).Id,
                VIN = car.VIN,
                Year = car.Year,
                Weight = car.Weight,
            });

            context.SaveChanges();
        }
    }
}
