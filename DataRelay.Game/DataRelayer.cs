// ************************************************************************
// Assembly         : DataRelay.Game
// 
// Author           : Nicholas Tyler
// Created          : 08-01-2018
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 08-01-2018
// 
// License          : MIT License
// ***********************************************************************

namespace DataRelay.Game
{
    public static class DataRelayer<T>
    {
        public static void RelayData(T Container)
        {
            var pipe = PipeServer.Pipe;

            if (pipe.IsConnected && pipe.CanWrite)
            {
                PipeServer.Write<T>(Container);
            }
        }
    }
}