using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {


        private class C_ClientBuilder : IClientBuilder
        {
            private IClient client;
            private bool discount_set = false;
            public C_ClientBuilder()
            {
                client = new Client();
               
            }

            IClient IBuilder<IClient>.Build()
            {
                if (isValid())
                    return client;
                else return null;
            }

            private bool isValid() => !client.Name.IsInvalid && discount_set;

            IClientBuilder IClientBuilder.Discount(float discount)
            {
                client.Discount = discount;
                discount_set = true;
                return this;
            }

            IClientBuilder IClientBuilder.Name(IName name)
            {
                client.Name = name;
                return this;
            }

            IClientBuilder IClientBuilder.Name(string name, string surname, string patronymic)
            {
                Name n = new Name(name, surname, patronymic);
                client.Name = n;
                return this;
            }
        }

        private class C_EmployeeBuilder : IEmployeeBuilder
        {
            private IEmployee employee;
            private bool department_set = false;
            public C_EmployeeBuilder()
            {
                employee = new Employee();
            }

            private bool isValid() => !employee.Name.IsInvalid && department_set;

            IEmployee IBuilder<IEmployee>.Build()
            {
                if (isValid())
                    return employee;
                else return null;
            }

            IEmployeeBuilder IEmployeeBuilder.Department(IDepartment department)
            {
                employee.Department = department;
                department_set = true;
                return this;
            }

            IEmployeeBuilder IEmployeeBuilder.Department(string department)
            {
                employee.Department = new Department(department);
                department_set = true;
                return this;
            }

            IEmployeeBuilder IEmployeeBuilder.Name(IName name)
            {
                employee.Name = name;
                return this;
            }

            IEmployeeBuilder IEmployeeBuilder.Name(string name, string surname, string patronymic)
            {
                employee.Name = new Name(name, surname, patronymic);
                return this;
            }
        }





        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>
        public static IClientBuilder ClientBuilder()
        {
            /*
             * TODO #6: Реализовать фабричный метод ClientBuilder класса Builders
             * DONE
             */


            IClientBuilder builder = new C_ClientBuilder();
            return builder;

        }

        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>
        public static IEmployeeBuilder EmployeeBuilder()
        {
            /*
             * TODO #7: Реализовать фабричный метод EmployeeBuilder класса Builders
             * DONE
             */
            IEmployeeBuilder builder = new C_EmployeeBuilder();
            return builder;
        }

    }
}
