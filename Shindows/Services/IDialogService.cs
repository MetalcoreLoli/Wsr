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

        /// <summary>
        /// Открывает диалоговое окно открытия файлов
        /// </summary>
        /// <param name="fileName">елси откно открылось, то fileName будет помещен путь к файлу</param>
        /// <returns>вернет true, если в диалоговом окне была нажата кнопка OK</returns>
        bool OpenFileDiolog(out string fileName);
    }
}
