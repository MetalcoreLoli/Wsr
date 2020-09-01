using Shindows.DomainLogic;
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
    public partial class MenuForm : Form
    {
        private readonly MenuFormController _controller;
        public MenuForm()
        {
            InitializeComponent();
            _controller = new MenuFormController(
                new StandartDialogService(),
                this);
        }

        private void DriverListForm_Click(object sender, EventArgs e)
        {
            _controller.OpenForm(new DriversListForm());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCarForm_Click(object sender, EventArgs e)
        {
            new CarForm().ShowDialog();
        }
    }
}
