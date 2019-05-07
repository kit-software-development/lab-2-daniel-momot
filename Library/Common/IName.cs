namespace Practice.Common
{
    /// <summary>
    ///     Абстрактное представление имени человека.
    ///     Тип, реализующий данный интерфейс, по возможности, должен быть значащим.
    /// </summary>
    public interface IName
    {
        /// <summary>
        ///     Полная форма имени.
        /// </summary>
        string FullName { get; }

        /// <summary>
        ///     Короткая форма имени.
        /// </summary>
        string ShortName { get; }
    }
}
