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
    public class DriverCreatingController
    {
        private readonly IDialogService _dialog;
        private readonly DriverCreatingForm _form;

        public IDialogService DialogService => _dialog;
        public DriverCreatingController(IDialogService dialog, DriverCreatingForm form)
        {
            _dialog = dialog;
            _form = form;
        }

        public void BackToLogin()
        {
            new AuthonrizationForm().Show();
            _form.Close();
        }

        public IEnumerable<string> GetStreet()
        {
            using (var context = new EntityContext())
            {
                foreach (var street in context.Street)
                    yield return street.Street1;
            }
        }

        public IEnumerable<string> GetJobs()
        {
            using (var context = new EntityContext())
            {
                foreach (var street in context.Job)
                    yield return street.Name;
            }
        }

        public IEnumerable<string> GetCompanies()
        {
            using (var context = new EntityContext())
            {
                foreach (var street in context.Company)
                    yield return street.Name;
            }
        }

        public void Insert(DriverModel driver)
        {
            if (driver == null)
                throw new System.ArgumentNullException(nameof (driver));

            try
            {
                using (var context = new EntityContext())
                {
                    var street = context.Street.FirstOrDefault(st => st.Street1.Equals(driver.Address.Street.Name));
                    if (street == null)
                    {
                        context.Street.Add(new Street
                        {
                            Street1 = driver.Address.Street.Name
                        });
                        context.SaveChanges();
                    }

                    var address = context.Address.Add(
                        new Address
                        {
                            StreetId = street.Id,
                            Postcode = driver.Address.PostCode,
                            Number = driver.Address.HouseNumber
                        });
                    context.SaveChanges();

                    var passport = context.Passport.Add(
                        new Passport
                        {
                            Serial = driver.Passport.Serial,
                            Number = driver.Passport.Number
                        });
                    context.SaveChanges();

                    var person = context.Person.Add(
                        new Person
                        {
                            Name = driver.Name,
                            MiddleName = driver.MiddleName,
                            LastName = driver.LastName,
                            PassportId = passport.Id,
                            AddressId = address.Id,
                            Photo = driver.Image,
                            Phone = driver.Phone,
                            Email = driver.Email,
                            Description = driver.Description
                        });
                    context.SaveChanges();

                    var job = context.Job.FirstOrDefault(j => j.Name.Equals(driver.Job.Name));
                    if (job == null)
                    {
                        context.Job.Add(new Job
                        {
                            Name = driver.Name
                        });
                        context.SaveChanges();
                    }

                    var company = context.Company.FirstOrDefault(j => j.Name.Equals(driver.Company.Name));
                    if (company == null)
                    {
                        context.Company.Add(new Company
                        {
                            Name = driver.Name
                        });
                        context.SaveChanges();
                    }

                    context.Driver.Add(
                        new Driver
                        {
                            PersonId = person.Id,
                            JobId = job.Id,
                            CompanyId = company.Id,
                        });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _dialog.ShowErrorMessage("ERROR", ex.Message);
            }
            finally 
            {
                DialogService.ShowMessage("Успех", "Водитель был добавлен");
            }
        }
    }
}
