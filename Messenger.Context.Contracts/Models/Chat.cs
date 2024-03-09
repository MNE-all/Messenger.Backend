using Messenger.Context.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Messenger.Context.Contracts.Models
{
    /// <summary>
    /// Чат
    /// </summary>
    public class Chat
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Название чата
        /// </summary>
        /// /// <remarks>
        /// Поле принимает значение только при <seealso cref="Type"/> != <seealso cref="ChatType.Private"/>
        /// </remarks>
        public string? Name { get; set; }
        /// <summary>
        /// <inheritdoc cref="ChatType"/>
        /// </summary>
        /// <remarks>
        /// По умолчанию <seealso cref="ChatType.Private"/>
        /// </remarks>
        public ChatType Type { get; set; } = ChatType.Private;
        /// <summary>
        /// Уникальное значение для поиска чатов
        /// </summary>
        /// <remarks>
        /// Поле принимает значение только при <seealso cref="Type"/> != <seealso cref="ChatType.Private"/>
        /// </remarks>
        public string? Link { get; set; } = null;
    }
}
