using Messenger.Context.Contracts.Models;
using Microsoft.EntityFrameworkCore;

namespace Messenger.Context.Contracts
{
    /// <summary>
    /// Интерфейс контекста для работы с сущностями
    /// </summary>
    public interface IMessengerContext
    {
        /// <summary> 
        /// Список <seealso cref="User"/> 
        /// </summary>
        DbSet<User> Users { get; }
        /// <summary> 
        /// Список <seealso cref="Message"/> 
        /// </summary>
        DbSet<Message> Messages { get; }
        /// <summary> 
        /// Список <seealso cref="Chat"/> 
        /// </summary>
        DbSet<Chat> Chats { get; }
        /// <summary> 
        /// Список <seealso cref="Contact"/> 
        /// </summary>
        DbSet<Contact> Contacts { get; }
        /// <summary> 
        /// Список <seealso cref="ChatMessage"/> 
        /// </summary>
        DbSet<ChatMessage> ChatMessages { get; }
        /// <summary> 
        /// Список <seealso cref="ChatUser"/> 
        /// </summary>
        DbSet<ChatUser> ChatUsers { get; }
        /// <summary> 
        /// Список <seealso cref="Connection"/> 
        /// </summary>
        DbSet<Connection> Connections { get; }

    }
}
