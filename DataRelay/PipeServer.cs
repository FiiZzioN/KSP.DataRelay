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
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace DataRelay
{
    public class PipeServer : IDisposable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PipeStream"/> object is connected.
        /// </summary>
        public bool IsConnected { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PipeStream"/> object is created.
        /// </summary>
        public bool IsCreated { get; protected set; }

        /// <summary>
        /// Gets the pipe.
        /// </summary>
        public NamedPipeServerStream Pipe { get; }

        //public NamedPipeServerStream CreatePipeServer(string pipeName, PipeDirection direction)
        //{
        //    var pipe = new NamedPipeServerStream();
        //}

        #region IDisposable Members

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}