using Shindows.Core;
using Shindows.DomainLogic;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.Forms
{
    public partial class LicenceForm : Form
    {
        private readonly LicenceController _controller;
        private readonly DriverModel _driverModel;
        public LicenceForm(DriverModel driverModel)
        {
            InitializeComponent();
            _controller         = new LicenceController(new StandartDialogService());
            _driverModel        = driverModel;
            NameBox.Text        = driverModel.Name;
            MiddleName.Text     = driverModel.MiddleName;
            LastNameBox.Text    = driverModel.LastName;

            if (driverModel.Image != null)
            {
                PhotoBox.Image = driverModel.Image.BytiesToImage();
            }
        }

        private async Task SetSerailUndNumber()
        {
            SerialBox.Text =            (await _controller.GetLastLicenceSerialAsync() + 1).ToString();
            LicenceNumberBox.Text =     (await _controller.GetLastLicenceNumberAsync() + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var cats = (from cat in CategoriesBox.Text.Trim().Split(',')
                        select new CategoryModel(0, cat)).ToList();

            _controller.Insert(new LicenceModel
            {
                Driver      = _driverModel,
                Date        = DateTime.Now,
                ExpireDate  = DateTime.Now.AddYears(10),
                Serial      = int.Parse (SerialBox.Text),
                Number      = int.Parse(LicenceNumberBox.Text),
                Categories  = cats
            });
        }

        private async void LicenceForm_Load(object sender, EventArgs e)
        {
            await SetSerailUndNumber();
            CategoriesBox.Items.AddRange(_controller.GetCategories().ToArray());
        }

        private void AddCatButton_Click(object sender, EventArgs e)
        {
            CategoryBox.Text += CategoriesBox.Text + ", ";
        }
    }
}
