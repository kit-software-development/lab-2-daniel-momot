using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактное прердставление о человеке.
    /// </summary>
    public interface IPerson
    {
        
        /// <summary>
        ///     Имя человека.
        /// </summary>
        IName Name { get; set; }
        
        /// <summary>
        ///     Событие изменения имени челока.
        /// </summary>
        event EventHandler<ValueChangeEventArgs<IName>> NameChange;
    }
}
