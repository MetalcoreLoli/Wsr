using Shindows.Core;
using Shindows.DomainLogic;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Models.DriverModel driver = new Models.DriverModel
                {
                    Name = NameBox.Text.IfNullThrowException(),
                    MiddleName = NameBox.Text.IfNullThrowException(),
                    LastName = NameBox.Text.IfNullThrowException(),
                    Passport = new Models.PassportModel(0, int.Parse(PassportSerialBox.Text), int.Parse(PassportNumberBox.Text)),
                    Address = new Models.AddressModel(
                        0, 
                        new Models.StreetModel (0, StreetBox.Text.IfNullThrowException()),
                        HouseNumberBox.Text.IfNullThrowException(),
                        PostcodeBox.Text.IfNullThrowException()
                        ),
                    Company = new Models.CompanyModel(0, CompanyBox.Text.IfNullThrowException()),
                    Job = new Models.JobModel(0, JobBox.Text.IfNullThrowException()),
                    Email = EmailBox.Text.IfNullThrowException(),
                    Phone = PhoneBox.Text.IfNullThrowException(),
                    Description = DesriptionBox.Text
                };

                //if (DiverPhotoBox.Image == null)
                //    throw new Exception("Please upload driver photo !!!");

                //driver.Image = DiverPhotoBox.Image.ImageToByties();
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
                string pictureName = "";
                if (_controller.DialogService.OpenFileDiolog(out pictureName)) 
                {
                    var pic = new Bitmap(pictureName);
                    if (pic.Width > 512 && pic.Height > 512)
                        throw new Exception("Picture must be 3x4");
                    DiverPhotoBox.Image = pic;
                }
            }
            catch (Exception ex)
            {
                _controller.DialogService.ShowErrorMessage("ERROR", ex.Message);
            }
           

        }
    }
}
