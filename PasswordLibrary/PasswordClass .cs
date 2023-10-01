using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibrary
{
    public class PasswordClass
    {
        /// <summary>
        /// Проверку правильности формирования  пароля
        /// </summary>
        /// <param name="password">Входное значение </param>
        /// <returns>True - если строка удовлетворяет условиям:
        /// строка имеет правильную длину;
        ///     содержать цифры;
        /// содержит латинские буквы в нижнем регистре;
        /// содержит латинские буквы в верхнем регистре;
        /// содержит спец.символы;
        /// не содержит кириллические символы</returns>
        /// <exception cref="Exception"></exception>
        public bool CheckPassword(string password)
        {
            string regex = @"^(?=.{8,15}$)((?=.*\d)(?=.*[a-z])(?=.*[A-Z]))";

            if (Regex.Match(password, regex).Success && Regex.Match(password, @"[(\!\@\#\$\%\^\&\*\(\)\{\}\;\.\,\[\]\+\=\-\>\<]").Success && !Regex.Match(password, @"(?=.*[а-я])|(?=.*[А-Я])").Success)
            {
                return true;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
