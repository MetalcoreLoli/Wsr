using Shindows.Enities;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic
{
    public class LicenceController
    {
        public LicenceController(IDialogService dialogService)
        {
            DialogService = dialogService;
        }

        public IDialogService DialogService { get; }

        public void Insert(LicenceModel model)
        {
            try
            {
                using (var context = new EntityContext())
                {
                    /*
                     	@driverId       int,
	                    @serail         int,
	                    @number         int,
	                    @date           date,
	                    @expitreDate    date,
	                    @category       nvarchar (255)
                     */

                    context.Database.ExecuteSqlCommand(
                        $"exec [AddLicence] @driverId='{model.Driver.Id}'," +
                                          $"@serail='{model.Serial}'," +
                                          $"@nubmer='{model.Number}'," +
                                          $"@date='{model.Date}'," +
                                          $"@category='{model.Categories.First().Value}'");
                    
                    if (model.Categories.Count > 1) 
                    {
                        foreach (var category in model.Categories)
                        {
                            /*
                             	@licenceId  int,
	                            @categoryId int
                             */
                            context.Database.ExecuteSqlCommand(
                                $"exec [AddCategoryToLicence] @licenceId='{model.Id}', @categoryId='{category.Id}'");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DialogService.ShowErrorMessage("ERROR", ex.Message);
            }
        }

    }
}
