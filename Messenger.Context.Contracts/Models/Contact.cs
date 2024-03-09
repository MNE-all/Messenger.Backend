using Messenger.Context.Contracts.Enums;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Контакт
    /// </summary>
    /// <remarks>Добаление пользователя в контакты позволит быстро создавать чат</remarks>
    public class Contact
    {
        /// <summary>
        /// Пользователь на которго подписываются
        /// </summary>
        public User User { get; set; } = null!;
        public Guid? UserId { get; set; }   // Связь один ко многим

        /// <summary>
        /// Пользователь который добавляет в список контактов
        /// </summary>
        public User Subscriber { get; set; } = null!;
        public Guid? SubscriberId { get; set; } // Связь один ко многим

        /// <summary>
        /// <inheritdoc cref="Enums.Relationship"/>
        /// </summary>
        /// <remarks>
        /// По умолчанию принимает <seealso cref="Relationship.Friend"/>
        /// </remarks>
        public Relationship Relationship { get; set; } = Relationship.Friend;
    }
}
