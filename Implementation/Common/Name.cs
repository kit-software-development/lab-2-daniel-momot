using System;

namespace Practice.Common
{

    internal static class NameExtensions
    {
        public static string toName(this string str)
     => str[0].ToString().ToUpper() + str.Substring(1).ToLower();

    }



    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         * DONE
         */

        public string _short;
        public string _full;

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }

        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }

        bool IName.IsInvalid
        {
            get
            {
                bool b1 = string.IsNullOrEmpty(FirstName);
                bool b2 = string.IsNullOrEmpty(Surname);
                bool b3 = string.IsNullOrEmpty(Patronymic);
                return b1 || b2 || b3;
            }
        }

        public string FullName
        {
            get => _full;
            private set
            {
                _full = value;
            }
        }
        public string ShortName
        {
            get => _short;
            private set
            {
                _short = value;
            }
        }

        public Name(string s_name, string f_name, string patr)
        {
            FirstName = f_name.toName();
            Surname = s_name.toName();
            Patronymic = patr.toName();
            _short = Surname + " " + FirstName[0] + ". " + Patronymic[0] + ".";
            _full = Surname + " " + FirstName + " " + Patronymic;
        }

    }
}
