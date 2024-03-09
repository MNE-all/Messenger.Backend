namespace Messenger.Context.Contracts.Enums
{
    /// <summary>
    /// Тип сообщения
    /// </summary>
    /// <remarks>
    /// При перессылке сообщения используется <seealso cref="MessageType.Forwarded"/>
    /// </remarks>
    public enum MessageType
    {
        /// <summary>
        /// Новоё сообщение
        /// </summary>
        New,
        /// <summary>
        /// Пересланное сообщение
        /// </summary>
        Forwarded
    }
}
