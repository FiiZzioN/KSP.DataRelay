﻿// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-26-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-29-2018
//
// License          : MIT License
// ************************************************************************

using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using DataRelay.Common;

namespace DataRelay.Game
{
    public sealed class PipeServer : IDisposable
    {
        private static NamedPipeServerStream _pipe;

        /// <summary>
        /// Gets the pipe server.
        /// </summary>
        public static NamedPipeServerStream Pipe
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
        /// Creates and then returns the pipe server.
        /// </summary>
        public static NamedPipeServerStream CreatePipeServer()
        {
            return Pipe ?? (Pipe = new NamedPipeServerStream(PipeData.ServerName, PipeDirection.InOut,
                NamedPipeServerStream.MaxAllowedServerInstances, PipeTransmissionMode.Message));
        }

        /// <summary>
        /// Writes the specified object to the pipe.
        /// </summary>
        /// <param name="obj">The object to write to the pipe.</param>
        public static void Write<T>(T obj)
        {
            //var convertedObject = Utilities.SerializeToByteArray(obj);

            //if (Pipe.IsConnected && Pipe.CanWrite)
            //{
            //    Pipe.Write(convertedObject, 0, Marshal.SizeOf(typeof(T)));
            //}

            if (Pipe.IsConnected && Pipe.CanWrite)
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(Pipe, obj);
            }
        }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        public static string Read()
        {
            if (Pipe.IsConnected && Pipe.CanRead)
            {
                var formatter = new BinaryFormatter();
                return (string)formatter.Deserialize(Pipe);
            }

            return null;
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