using Shindows.Builders;
using Shindows.DomainLogic;
using Shindows.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shindows.Forms
{
    public partial class DriverCreatingForm : Form
    {
        private readonly DriverCreatingController _controller;

        public DriverCreatingForm()
        {
            InitializeComponent();
            _controller = new DriverCreatingController(
                new StandartDialogService(),
                this);

            JobBox.Items.AddRange(_controller.GetJobs().ToArray());
            CompanyBox.Items.AddRange(_controller.GetCompanies().ToArray());
            StreetBox.Items.AddRange(_controller.GetStreet().ToArray());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _controller.BackToLogin();
        }

        private void DriverCreatingForm_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Models.DriverModel driver = null;

                DriverModelBuilder driverBuilder = new DriverModelBuilder();

                driverBuilder.SetId(0);

                driverBuilder.SetAddress(0, 0, StreetBox.Text, HouseNumberBox.Text, PostcodeBox.Text);
                driverBuilder.SetCompany(0, CompanyBox.Text);
                driverBuilder.SetJob(0, JobBox.Text);
                driverBuilder.SetPassport(0, int.Parse(PassportSerialBox.Text), int.Parse(PassportNumberBox.Text));

                driverBuilder.SetName(NameBox.Text);
                driverBuilder.SetMiddleName(MIddleNameBox.Text);
                driverBuilder.SetLastName(LastNameBox.Text);

                driverBuilder.SetDescription(DesriptionBox.Text);
                driverBuilder.SetEmail(EmailBox.Text);
                driverBuilder.SetPhone(PhoneBox.Text);

                if (DriverPhotoBox.Image == null)
                    throw new Exception("Please upload driver photo !!!");

                driverBuilder.SetImage(DriverPhotoBox.Image);

                driver = driverBuilder.GetDriverModel();
                _controller.Insert(driver);
            }
            catch (Exception ex)
            {
                _controller.DialogService.ShowErrorMessage("ERROR", ex.Message);
            }
        }

        private void ImageLoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_controller.DialogService.OpenFileDialog(out string pictureName))
                {
                    var pic = new Bitmap(pictureName);
                    
                    if (pic.Width > 512 && pic.Height > 512)
                        throw new Exception("The picture must be 3x4");

                    DriverPhotoBox.Image = pic;
                }
            }
            catch (Exception ex)
            {
                _controller.DialogService.ShowErrorMessage("ERROR", ex.Message);
            }
           

        }
    }
}
