using Messenger.Context.Contracts.Enums;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Промежуточная таблица
    /// </summary>
    /// <remarks>Позволяет безприпятственно добавлять пользователей в существующий чат</remarks>
    public class ChatUser
    {
        /// <summary>
        /// Чат
        /// </summary>
        public Chat Chat { get; set; } = null!;
        public Guid? ChatId { get; set; }   // Связь один ко многим

        /// <summary>
        /// Пользователь чата
        /// </summary>
        public User User { get; set; } = null!;
        public Guid? MessageId { get; set; }    // Связь один ко многим

        /// <summary>
        /// Роль пользователя в чате
        /// </summary>
        /// <remarks>Админы могут управлять добавлять и удалять пользователей</remarks>
        public ChatRole Role { get; set; }
        /// <summary>
        /// Дата добавления пользователя в чат
        /// </summary>
        public DateTimeOffset JoinedAt { get; set; } = DateTimeOffset.Now;
        /// <summary>
        /// Возможность просматривать историю сообщений до вступления в чат
        /// </summary>
        public bool ShowHistory { get; set; } = false;
    }
}
