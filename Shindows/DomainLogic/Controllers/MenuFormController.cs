using Shindows.Forms;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.DomainLogic
{
    public class MenuFormController
    {
        private readonly IDialogService _dialog;
        private readonly MenuForm _form;
        public MenuFormController(IDialogService dialog, MenuForm form)
        {
            _dialog = dialog;
            _form = form;
        }

        public void OpenForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
