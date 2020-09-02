using Shindows.Core;
using Shindows.Enities;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
                var context = EntityContextSingleton.Instance;

                /*
                    @driverId       int,
                    @serail         int,
                    @number         int,
                    @date           date,
                    @expitreDate    date,
                    @category       nvarchar (255)
                 */

                context.Database.ExecuteSqlCommand (
                    $"exec [AddLicence] @driverId='{model.Driver.Id}'," +
                                      $"@serail='{model.Serial}'," +
                                      $"@number='{model.Number}'," +
                                      $"@date='{model.Date}'," +
                                      $"@expitreDate='{model.ExpireDate}'," +
                                      $"@category='{model.Categories.First().Value}'");

                if (model.Categories.Count > 1)
                {
                    foreach (var category in model.Categories)
                    {
                        /*
                            @licenceId  int,
                            @categoryId int
                         */
                        int id = context.Database.SqlQuery<Category> (
                            $"select [Id] from [Category] where [Category].[Value] = '{category.Value}'").First().Id;
                        
                        context.Database.ExecuteSqlCommand (
                            $"exec [AddCategoryToLicence] @licenceId='{model.Id}', @categoryId='{id}'");
                    }
                }
            }
            catch (Exception ex)
            {
                DialogService.ShowErrorMessage("ERROR", ex.Message);
            }
            finally
            {
                DialogService.ShowMessage("Done", "ВУ было зарегистрированно");
            }
        }

        public async Task<int> GetLastLicenceSerialAsync()
        {
            var context = EntityContextSingleton.Instance;
            await context.Licence.LoadAsync().ConfigureAwait(false);
            return context.Licence.Local.Last().Serial;
        }

        public async Task<int> GetLastLicenceNumberAsync()
        {
            var context = EntityContextSingleton.Instance;
            await context.Licence.LoadAsync().ConfigureAwait(false);
            return context.Licence.Local.Last().Number;
        }

        public IEnumerable<string> GetCategories()
        {
            var context = EntityContextSingleton.Instance;
            return from item in context.Category.Select(cat => cat.Value).Distinct()
                   select item;
        }
    }
}
