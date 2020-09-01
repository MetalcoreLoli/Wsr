using Shindows.DomainLogic;
using Shindows.DomainLogic.Fillters;
using Shindows.DomainLogic.Specifications;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.Forms
{
    public partial class DriversListForm : Form
    {
        private readonly DriverListFormController _controller;
        private BindingList<DriverModel> driversBindingList;
        public DriversListForm()
        {
            InitializeComponent();
            _controller = new DriverListFormController(
                new StandartDialogService(),
                this);

            NameBox.Items.AddRange(_controller.GetNames().Distinct().ToArray());
            MiddleNameBox.Items.AddRange(_controller.GetMiddleNames().Distinct().ToArray());
            LastNameBox.Items.AddRange(_controller.GetLastNames().Distinct().ToArray());

            DriversListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DriversListGrid.AutoGenerateColumns = false;
            Clear();
            CreateBindings();
        }

        private void CreateBindings()
        {
            if (driversBindingList == null)
                driversBindingList = new BindingList<DriverModel>();
                
            IdColumn.DataPropertyName           = nameof(DriverModel.Id);
            NameColumn.DataPropertyName         = nameof(DriverModel.Name);
            MiddleNameColumn.DataPropertyName   = nameof(DriverModel.MiddleName);
            LastNameColumn.DataPropertyName     = nameof(DriverModel.LastName);
            PhoneColumn.DataPropertyName        = nameof(DriverModel.Phone);
            EmailColumn.DataPropertyName        = nameof(DriverModel.Email);

            foreach (var driver in _controller.Drivers)
                driversBindingList.Add(driver);
        }

        private void ApplyFilltersButton_Click(object sender, EventArgs e)
        {
            var name        = NameBox.Text;
            var middleName  = MiddleNameBox.Text;
            var lastName    = LastNameBox.Text;

            Clear();

            var nameSpec        = new DriverNameSpecification(name);
            var midNameSpec     = new DriverMiddleNameSpecification(middleName);
            var lastNameSpec    = new DriverLastNameSpecification(lastName);

            var fillter = new DriverFillter();

            foreach (var item in fillter
                .Execute(_controller.Drivers, nameSpec | midNameSpec | lastNameSpec))
            {
                driversBindingList.Add(item);
            }
          
        }

        private void Clear()
        {
            DriversListGrid.Rows.Clear();
            DriversListGrid.Refresh();

            driversBindingList = new BindingList<DriverModel>();

            DriversListGrid.DataSource = new BindingSource
            {
                DataSource = driversBindingList
            };
           
        }
        private void CleanFilltersButton_Click(object sender, EventArgs e)
        {
            Clear();
            foreach (var driver in _controller.Drivers)
                driversBindingList.Add(driver);
        }

        private void AddDriverButton_Click(object sender, EventArgs e)
        {
            new DriverCreatingForm().ShowDialog();  
        }

        private void AddLicenceToDriverButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriversListGrid.CurrentRow == null)
                    throw new Exception("Please select driver to countinue !!!");

                var row = DriversListGrid.CurrentRow;
                int id = int.Parse(row.Cells["IdColumn"].Value.ToString());
                new LicenceForm(_controller.GetDriverById(id)).ShowDialog();
            }
            catch (Exception ex)
            {
                _controller.DialogService.ShowErrorMessage("Error", ex.Message);
            }
        }

        private void LicencesListButton_Click(object sender, EventArgs e)
        {
            new LicenceListForm().ShowDialog();
        }
    }
}
