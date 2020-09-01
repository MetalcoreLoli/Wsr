using Shindows.DomainLogic;
using Shindows.DomainLogic.Fillters;
using Shindows.DomainLogic.Specifications;
using Shindows.DomainLogic.Specifications.Licence;
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
    public partial class LicenceListForm : Form
    {
        private readonly LicenceListFormController _controller;
        private BindingList<LicenceModel> licencesBindingList;

        public LicenceListForm()
        {
            InitializeComponent();
            _controller = new LicenceListFormController(
                new StandartDialogService(), this);

            NameBox.Items.AddRange(_controller.GetNames().ToArray());
            MiddleNameBox.Items.AddRange(_controller.GetMiddleNames().ToArray());
            LastNameBox.Items.AddRange(_controller.GetLastNames().ToArray());
            StatusBox.Items.AddRange(_controller.GetStatues().ToArray());
            DriversListGrid.AutoGenerateColumns = false;
            DriversListGrid.ReadOnly = true;
            CreateBindings();
        }

        private void CreateBindings()
        {
            if (licencesBindingList == null)
                licencesBindingList = new BindingList<LicenceModel>();

            IdColumn.DataPropertyName           = nameof(LicenceModel.Id);
            StatusColumn.DataPropertyName       = nameof(LicenceModel.Status);
            SerialColumn.DataPropertyName       = nameof(LicenceModel.Serial);
            NumberColumn.DataPropertyName       = nameof(LicenceModel.Number);

            foreach (var licences in _controller.GetLicences())
               // licencesBindingList.Add(driver);
                DriversListGrid.Rows.Add(
                    licences.Id,
                    licences.Serial,
                    licences.Number,
                    licences.Driver.Name, 
                    licences.Driver.MiddleName, 
                    licences.Driver.LastName, 
                    licences.Driver.Phone, 
                    licences.Driver.Email,
                    licences.Status
                    );
           // DriversListGrid.DataSource = new BindingSource { DataSource = licencesBindingList };
        }

        private void Clear()
        { 
            licencesBindingList = new BindingList<LicenceModel>();
            DriversListGrid.Rows.Clear();
            DriversListGrid.Refresh();
           
            //DriversListGrid.DataSource = new BindingSource { DataSource = licencesBindingList };
        }

        private void ApplyFilltersButton_Click(object sender, EventArgs e)
        {
            var fillter = new LicenceFillter();

            Clear();
            var statusSpec      = new LicenceStatusSpecification(StatusBox.Text);
            var nameSpec        = new LicenceNameSpecification(NameBox.Text);
            var midNameSpec     = new LicenceMiddleNameSpecification(MiddleNameBox.Text);
            var lastNameSpec    = new LicenceLastNameSpecification(LastNameBox.Text);
            foreach (var licences in fillter.Execute(_controller.GetLicences(), statusSpec | nameSpec | lastNameSpec | midNameSpec))
                DriversListGrid.Rows.Add(
                   licences.Id,
                   licences.Serial,
                   licences.Number,
                   licences.Driver.Name,
                   licences.Driver.MiddleName,
                   licences.Driver.LastName,
                   licences.Driver.Phone,
                   licences.Driver.Email,
                   licences.Status
                   );
        }

        private void CleanFilltersButton_Click(object sender, EventArgs e)
        {
            Clear();
            foreach (var licences in _controller.GetLicences())
                DriversListGrid.Rows.Add(
                   licences.Id,
                   licences.Serial,
                   licences.Number,
                   licences.Driver.Name,
                   licences.Driver.MiddleName,
                   licences.Driver.LastName,
                   licences.Driver.Phone,
                   licences.Driver.Email,
                   licences.Status
                   );
        }
    }
}
