using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.Services
{
    /// <summary>
    /// Сервис для диалоговых окон
    /// </summary>
   public interface IDialogService
   {
        /// <summary>
        /// Вывод сообщения
        /// </summary>
        /// <param name="tile">Заголовок сообщения</param>
        /// <param name="message">текст сообщения</param>
        /// <returns></returns>
        DialogResult ShowMessage(string tile, string message);

        /// <summary>
        /// Вывод сообщения об ошибке
        /// </summary>
        /// <param name="tile">Заголовок сообщения</param>
        /// <param name="message">текст сообщения</param>
        /// <returns></returns>
        DialogResult ShowErrorMessage(string tile, string message);
    }
}
