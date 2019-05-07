using Practice.HR;
using System;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = Builders.ClientBuilder()
                .Name("иванов", "иван", "иванович")
                .Discount(.1f)
                .Build();

            IEmployee employee = Builders.EmployeeBuilder()
                .Name("сидоров", "григорий", "петрович")
                .Department("Бухгалтерия")
                .Build();

            Console.WriteLine(client.Info);
            Console.WriteLine(employee.Info);
            Console.ReadKey();
            
            /*
             * TODO #8: Собрать приложение. 
             * DONE
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             * DONE
             */
        }
    }
}
