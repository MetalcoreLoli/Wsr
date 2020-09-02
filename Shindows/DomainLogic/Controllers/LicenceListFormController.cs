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

namespace Shindows.DomainLogic
{
    public class LicenceListFormController
    {
        public IDialogService DialogService { get; }
        private readonly LicenceListForm form;

        public LicenceListFormController(IDialogService dialogService, LicenceListForm form)
        {
            DialogService = dialogService;
            this.form = form;
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

        public IEnumerable<LicenceModel> GetLicences()
        {
            return EntityContextSingleton.GetLicences();
        }
    }
}
