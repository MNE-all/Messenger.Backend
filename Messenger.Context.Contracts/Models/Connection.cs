using System.ComponentModel.DataAnnotations;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Подключения для SignalR
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Подкюлчение устройства 
        /// </summary>
        [Key]
        public string ConnectionID { get; set; } = null!;
        /// <summary>
        /// Состояние подключения
        /// </summary>
        public bool Connected { get; set; }

        /// <summary>
        /// Пользователь, владелец подключения
        /// </summary>
        public User User { get; set; } = null!;
        public Guid? UserId { get; set; }   // Связь один ко многим
    }
}
