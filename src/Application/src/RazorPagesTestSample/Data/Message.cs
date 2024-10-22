using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

       
        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// The message text, limited to 200 characters.
        /// </value>
        /// <remarks>
        /// There's a 200 character limit on messages. Please shorten your message if it exceeds this limit.
        /// </remarks>
        /// /// /// /// /// /// /// /// /// [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
