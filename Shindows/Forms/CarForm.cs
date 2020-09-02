using Shindows.Builders;
using Shindows.Core;
using Shindows.DomainLogic.Builders;
using Shindows.DomainLogic.Controllers;
using Shindows.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using VIN_LIB;

namespace Shindows.Forms
{
    public partial class CarForm : Form
    {
        private readonly CarFormContoroller _controller;
        public CarForm()
        {
            InitializeComponent();

            ModelBox.Items          .AddRange(EntityContextSingleton.GetModels()        .ToArray());
            ManufacturerBox.Items   .AddRange(EntityContextSingleton.GetManufacturers() .ToArray());
            CategoryBox.Items       .AddRange(EntityContextSingleton.GetCategories()    .ToArray());
            ColorBox.Items          .AddRange(EntityContextSingleton.GetColorCodes()    .ToArray());
            DriveTypeBox.Items      .AddRange(EntityContextSingleton.GetTypesOfDrive()  .ToArray());

            NameBox.Items           .AddRange(EntityContextSingleton.GetNames().Distinct()         .ToArray());
            MiddleNameBox.Items     .AddRange(EntityContextSingleton.GetMiddleNames().Distinct()   .ToArray());
            LastNameBox.Items       .AddRange(EntityContextSingleton.GetLastNames().Distinct()     .ToArray());

            TypeOfEngine.Items      .AddRange(EntityContextSingleton.GetEngines().Distinct()       .ToArray());


            _controller = new CarFormContoroller(new StandartDialogService());
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var carBuilder = new CarModelBuilder(new VINParserBase());
                var driverBulder = new DriverModelBuilder();

                var driver = EntityContextSingleton.FindDriverOrDefault(NameBox.Text, MiddleNameBox.Text, LastNameBox.Text);
                if (driver != null)
                    driverBulder.WithId(driver.Id);
                else
                {
                    new DriverCreatingForm().ShowDialog();
                    driver = EntityContextSingleton.FindDriverOrDefault(NameBox.Text, MiddleNameBox.Text, LastNameBox.Text);
                    driverBulder.WithId(driver.Id);
                }


                var completedCar = carBuilder
                    .Color
                        .WithColorCode(ColorBox.Text)
                    .Model
                        .WithManufacturer(0, ManufacturerBox.Text)
                        .WithEngine(0, TypeOfEngine.Text)
                        .Called(ModelBox.Text)
                    .DriverType
                        .WithType(DriveTypeBox.Text)
                    .WithVIN(VINBox.Text)
                    .WithYear(CarYearBox.Value.Year)
                    .WithWeight(int.Parse(WeightBox.Text))
                    .WithDriver(driverBulder)
                    .Build();

                _controller.Insert(completedCar);
            }
            catch (Exception ex)
            {
                _controller.DialogService.ShowErrorMessage("Yay", ex.Message);
            }
            finally
            {
                _controller.DialogService.ShowMessage("Yay", "Yay");
            }
           
        }
    }
}
