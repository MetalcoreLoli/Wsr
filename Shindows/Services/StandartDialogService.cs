using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.Services
{
    class StandartDialogService : IDialogService
    {
        public bool OpenFileDialog(out string fileName)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                return true;
            }
            fileName = string.Empty;
            return false;
        }

        public DialogResult ShowErrorMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowMessage(string title, string message)
        {
            return MessageBox.Show(message, title);
        }
    }
}
