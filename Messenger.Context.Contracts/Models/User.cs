using System.ComponentModel.DataAnnotations;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        /// <remarks>
        /// Уникальное свойтсво
        /// </remarks>
        [Required]
        public string Username { get; set; } = null!;
        /// <summary>
        /// Пароль (в хешированном виде)
        /// </summary>
        [Required]
        public string Password { get; set; } = null!;
        /// <summary>
        /// Статус пользователя
        /// </summary>
        /// <remarks>
        /// Назначается самим пользователем
        /// </remarks>
        public string? Status { get; set; }
    }
}
