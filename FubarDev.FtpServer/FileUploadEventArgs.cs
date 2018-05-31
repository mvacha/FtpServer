using System;

using JetBrains.Annotations;

namespace FubarDev.FtpServer
{
    /// <summary>
    /// Event arguments for a file upload event
    /// </summary>
    public class FileUploadEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadEventArgs"/> class.
        /// </summary>
        /// <param name="ipAddress">The ip adress of the current connection</param>
        /// <param name="fileName">The filename of the event</param>
        public FileUploadEventArgs([NotNull] string ipAddress, [NotNull] string fileName)
        {
            IpAddress = ipAddress;
            FileName = fileName;
        }

        /// <summary>
        /// Gets the connection for this event
        /// </summary>
        [NotNull]
        public string IpAddress { get; }

        /// <summary>
        /// Gets the filename for this event
        /// </summary>
        [NotNull]
        public string FileName { get; }
    }
}
