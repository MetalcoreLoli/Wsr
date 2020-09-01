using Shindows.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Shindows.Forms
{
    public partial class CarForm : Form
    {
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
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
