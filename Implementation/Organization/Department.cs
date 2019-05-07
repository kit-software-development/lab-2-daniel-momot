using System;

namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {
        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         * DONE
         */
         private string _department;
        string IDepartment.Name
        {
            get
            {
                return _department;
            }
        }

        public Department(string department)
        {
            _department = department;
        }
    }
}
