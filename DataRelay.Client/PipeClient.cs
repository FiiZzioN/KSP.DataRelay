// ************************************************************************
// Assembly         : DataRelay.Client
// 
// Author           : Nicholas Tyler
// Created          : 08-01-2018
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 08-01-2018
// 
// License          : MIT License
// ***********************************************************************

using DataRelay.Common;
using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;

namespace DataRelay.Client
{
    public sealed class PipeClient : IDisposable
    {
        private static NamedPipeClientStream _pipe;

        /// <summary>
        /// Gets the pipe client.
        /// </summary>
        public static NamedPipeClientStream Pipe
        {
            get
            {
                return _pipe ?? CreatePipeServer();
            }
            private set
            {
                if (value == null)
                {
                    return;
                }

                _pipe = value;
            }
        }

        /// <summary>
        /// Creates and then returns the pipe client.
        /// </summary>
        public static NamedPipeClientStream CreatePipeServer()
        {
            return Pipe ?? (Pipe = new NamedPipeClientStream(PipeData.ServerName, PipeData.ClientName, PipeDirection.InOut,
                PipeOptions.None, TokenImpersonationLevel.Identification, HandleInheritability.Inheritable));
        }

        /// <summary>
        /// Writes the specified object to the pipe.
        /// </summary>
        /// <param name="obj">The object to write to the pipe.</param>
        public static void Write(object obj)
        {
            if (Pipe.IsConnected && Pipe.CanWrite)
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(Pipe, obj);
            }
        }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        public static T Read<T>()
        {
            if (Pipe.IsConnected && Pipe.CanRead)
            {
                var formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(Pipe);
            }

            return default(T);
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public static void DisposeServer()
        {
            Pipe.Flush();
            Pipe.Dispose();
        }

        #region IDisposable Members

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            DisposeServer();
        }

        #endregion
    }
}