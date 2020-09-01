using Shindows.Core;
using Shindows.Enities;
using Shindows.Forms;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.DomainLogic
{
    public class DriverListFormController
    {
        private readonly IDialogService _dialog;
        private readonly DriversListForm _form;
        public List<DriverModel> Drivers { get; set; }
        public IDialogService DialogService => _dialog;

        public DriverListFormController(IDialogService dialog, DriversListForm form)
        {
            _dialog = dialog;
            _form = form;
            FillDirverModelList();
        }

        public IEnumerable<string> GetStatues()
        {
            return EntityContextSingleton.GetStatuses();
        }

        public IEnumerable<string> GetNames()
        {
            return EntityContextSingleton.GetNames();
        }

        public IEnumerable<string> GetMiddleNames()
        {
            return EntityContextSingleton.GetMiddleNames();
        }

        public IEnumerable<string> GetLastNames()
        {
            return EntityContextSingleton.GetLastNames();
        }

        private void FillDirverModelList()
        {
            if (Drivers == null)
                Drivers = new List<DriverModel>();

            var context = EntityContextSingleton.Instance;
            foreach (var item in context.Driver)
                Drivers.Add(item);
        }

        internal DriverModel GetDriverById(int id)
        {
            var context = EntityContextSingleton.Instance;
            var driver = context.Driver.First(dr => dr.Id.Equals(id));
            return DriverModel.CreateFrom(driver);
        }
    }
}
