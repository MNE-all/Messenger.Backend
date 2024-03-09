using System.ComponentModel.DataAnnotations;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public class Message
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        [Required]
        public string Data { get; set; } = null!;
        /// <summary>
        /// Дата отправления
        /// </summary>
        public DateTimeOffset SentTime { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// Отправитель
        /// </summary>
        public User User { get; set; } = null!;
        public Guid? UserId { get; set; }   // Связь один ко многим
    }
}
