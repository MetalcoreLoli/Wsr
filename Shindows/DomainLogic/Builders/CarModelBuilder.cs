using Shindows.Builders;
using Shindows.Enities;
using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using VIN_LIB;

namespace Shindows.DomainLogic.Builders
{
    public class CarModelBuilder
    {
        protected CarModel _root;
        protected readonly IVINParser _parser;
        public CarModelBuilder(IVINParser parser) : this (new CarModel(), parser)
        { 
        }

        public CarModelBuilder(CarModel car, IVINParser parser) 
        {
            _root = car;
            _parser = parser;
        }

        public CarModelModelBuilder Model               => new CarModelModelBuilder(_root, _parser);
        public CarColorModelBuilder Color               => new CarColorModelBuilder(_root, _parser);
        public CarTypeOfDriveModelBuilder DriverType    => new CarTypeOfDriveModelBuilder(_root, _parser);


        public CarModelBuilder WithVIN(string vin)
        {
            if (!_parser.CheckVIN(vin))
                throw new Exception("Bad VIN !!!");
            _root.VIN = vin;
            return this;
        }

        public CarModelBuilder WithYear(int year)
        {
            _root.Year = year;
            return this;
        }

        public CarModelBuilder WithWeight(int weight)
        {
            _root.Weight = weight;
            return this;
        }
        
        public CarModelBuilder WithId(int id)
        {
            _root.Id = id;
            return this;
        }

        public CarModelBuilder WithDriver(DriverModelBuilder builder)
        {
            _root.Driver = builder.Build();
            return this;
        }
        public CarModel Build() => _root;
    }

    public class CarModelModelBuilder : CarModelBuilder
    {
        public CarModelModelBuilder(CarModel car, IVINParser parser) : base(car, parser)
        {
            _root.Model = new ModelModel();
        }

        public new CarModelModelBuilder WithId(int id)
        {
            _root.Model.Id = id;
            return this;
        }
        
        public CarModelModelBuilder Called(string name)
        {
            _root.Model.Name = name;
            return this;
        }

        public CarModelModelBuilder WithManufacturer(int id, string name)
        {
            _root.Model.Manufacturer = new ManufacturerModel 
            {
                Id = id,
                Name = name
            };
            return this;
        }

        public CarModelModelBuilder WithEngine(int id, string type)
        {
            _root.Model.Engine = new EngineModel
            {
                Id = id,
                Type = type
            };
            return this;
        }
        
    }
    
    public class CarColorModelBuilder : CarModelBuilder
    {
        public CarColorModelBuilder(CarModel car, IVINParser parser) : base(car, parser)
        {
            _root.Color = new ColorModel();
        }
        public new CarColorModelBuilder WithId(int id)
        {
            _root.Color.Id = id;
            return this;
        }
        public CarColorModelBuilder WithColorCode(string code)
        {
            _root.Color.Code = code;
            return this;
        }
        public CarColorModelBuilder WithValue(string value)
        {
            _root.Color.Value = value;
            return this;
        }
        public CarColorModelBuilder IsMetallic(bool isMetallic)
        {
            _root.Color.IsMetallic = isMetallic;
            return this;
        }
    }

    public class CarTypeOfDriveModelBuilder : CarModelBuilder
    {
        public CarTypeOfDriveModelBuilder(CarModel car, IVINParser parser) : base(car, parser)
        {
            _root.DriveType = new DriveTypeModel();
        }

        public new CarTypeOfDriveModelBuilder WithId(int id)
        {
            _root.DriveType.Id = id;
            return this;
        }

        public CarTypeOfDriveModelBuilder WithType(string type)
        {
            _root.DriveType.Type = type;
            return this;
        }
    }
}
