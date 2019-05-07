using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        private IName _name;

        public abstract string Info { get; }

        IName IPerson.Name {
            get => _name;
            set
            {
                _name = value;
                NameChange?.Invoke(this, new ValueChangeEventArgs<IName>(_name));
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;


        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         * DONE
         */
    }
}
