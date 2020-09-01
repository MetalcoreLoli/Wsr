using Shindows.DomainLogic;
using Shindows.Forms;
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

namespace Shindows
{
    public partial class AuthonrizationForm : Form
    {
        private readonly AuthorizantionController _controller;
        public AuthonrizationForm()
        {
            InitializeComponent();
            _controller = new AuthorizantionController(new StandartDialogService());
        }

        private async void LogInButton_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                UserModel user = new UserModel(LoginBox.Text, PasswordBox.Text);
                if (!await _controller.CheckUserAsync(user))
                    throw new System.Exception("Неправильный логин или пароль!!!!");
                new MenuForm().ShowDialog();

            }
            catch (Exception ex)
            {
                _controller.Dialog.ShowErrorMessage("Error", ex.Message);
            }
        }
    }
}
