// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-28-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-28-2018
//
// License          : MIT License
// ***********************************************************************

using DataRelay.Common.DataContainers;

namespace DataRelay.Game.Relayers
{
    /// <summary>
    /// Relayers send the data through the pipes.
    /// </summary>
    public class GameInfoRelay
    {
        public void RelayData(GameInfoContainer Container)
        {
            var pipe = PipeServer.Pipe;

            if (pipe.IsConnected && pipe.CanWrite)
            {
                PipeServer.Write(Container);
            }
        }
    }
}