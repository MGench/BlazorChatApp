namespace BlazorChatApp.Models
{
    public class ChatMessage
    {
        public int Id { get; set; } // Primary key for storing each chat message.
        public string User { get; set; } // Stores the sender's name.
        public string Message { get; set; } // Stores the chat message text.
        public DateTime Timestamp { get; set; } // Stores the time the message was sent.
    }

}
