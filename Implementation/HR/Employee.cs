using System;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         * DONE
         */
        private IDepartment _dep;
        private string _info;

        public override string Info => "Сотрудник " + ((IPerson)this).Name.FullName + " работает в отделе " + _dep.Name;


        public IDepartment Department
        {
            get
            {
                return _dep;
            }

            set
            {
                _dep = value;
                DepartmentChange?.Invoke(this, new ValueChangeEventArgs<IDepartment>(_dep));
            }
        }


        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
