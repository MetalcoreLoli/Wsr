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
                if (DriverPhotoBox.Image == null)
                    throw new Exception("Please upload driver photo !!!");

                driver = driverBuilder
                    .WithId(0)
                    .WithName(NameBox.Text)
                    .WithMiddleName(MIddleNameBox.Text)
                    .WithLastName(LastNameBox.Text)
                    .WithDescription(DesriptionBox.Text)
                    .WithEmail(EmailBox.Text)
                    .WithPhone(PhoneBox.Text)
                    .WithImage(DriverPhotoBox.Image)
                    .Lives
                        .At(0, StreetBox.Text)
                        .WithHouseNumber(HouseNumberBox.Text)
                        .WithPostcode(PostcodeBox.Text)
                    .Works
                        .At(0, CompanyBox.Text)
                        .AsA(0, JobBox.Text)
                    .Passport
                        .WithSerial(int.Parse(PassportSerialBox.Text))
                        .WithNumber(int.Parse(PassportNumberBox.Text))
                    .Build();

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
