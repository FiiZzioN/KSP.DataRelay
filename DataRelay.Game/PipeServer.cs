// ************************************************************************
// Assembly         : DataRelay
// 
// Author           : Nicholas Tyler
// Created          : 07-26-2018
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-26-2018
// 
// License          : MIT License
// ***********************************************************************

using System;
using System.IO.Pipes;

namespace DataRelay.Game
{
    public class PipeServer : IDisposable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PipeStream"/> object is created.
        /// </summary>
        public bool IsCreated { get; protected set; }

        /// <summary>
        /// Gets the pipe.
        /// </summary>
        public NamedPipeServerStream Pipe { get; protected set; }

        public virtual NamedPipeServerStream CreatePipeServer(string pipeName)
        {
            return CreatePipeServer(pipeName, PipeDirection.InOut, 2, PipeTransmissionMode.Message);
        }

        public virtual NamedPipeServerStream CreatePipeServer
            (string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode)
        {
            Pipe = new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode);

            IsCreated = true;
            return Pipe;
        }



        #region IDisposable Members

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            Pipe.Flush();
            Pipe.Dispose();
            
            IsCreated = false;
        }

        #endregion
    }
}