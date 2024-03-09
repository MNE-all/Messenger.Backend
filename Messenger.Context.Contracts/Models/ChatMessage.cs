using Messenger.Context.Contracts.Enums;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Промежуточная таблица
    /// </summary>
    /// <remarks>Удобна для реализации обмена сообщений между чатами</remarks>
    public class ChatMessage
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Чат
        /// </summary>
        public Chat Chat { get; set; } = null!;
        public Guid? ChatId { get; set; }   // Связь один ко многим

        /// <summary>
        /// Сообщение
        /// </summary>
        public Message Message { get; set; } = null!;
        public Guid? MessageId { get; set; }    // Связь один ко многим

        /// <summary>
        /// <inheritdoc cref="MessageType"/>
        /// </summary>
        public MessageType Type { get; set; } = MessageType.New;
    }
}
