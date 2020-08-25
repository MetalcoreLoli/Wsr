using Shindows.Enities;
using Shindows.Models;
using Shindows.Services;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Shindows.DomainLogic
{
    /// <summary>
    /// Класс содержащий логику форма авторизации
    /// </summary>
    public class AuthorizantionController
    {
        public IDialogService Dialog { get; }

        public AuthorizantionController(IDialogService service)
        {
            Dialog = service;
        }

        /// <summary>
        /// Метод проверяет наличие пользователя в базе данных
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Если пользователь был найдет вернет - true</returns>
        public async Task<bool> CheckUserAsync(UserModel user)
        {
            if (user == null)
                throw new System.ArgumentNullException(nameof(user));

            using (var context = new EnitityContext())
                return await context.Employee.FirstOrDefaultAsync(emp => emp.Login.Equals(user.Login) && emp.Password.Equals(user.Password)) != null;
        }
    }
}
