using System;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         * DONE
         */
        private float _discount;

        public override string Info =>
            "Клиент " + ((IPerson)this).Name.FullName + " имеет скидку " + _discount * 100 + "%";

           

        float IClient.Discount
        {
            get
            {
                
                return _discount;
            }
            set
            {
                _discount = value;
                DiscountChange?.Invoke(this, new ValueChangeEventArgs<float>(_discount));
            }
        }

        public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;

    }
}
