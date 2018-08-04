// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-27-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-28-2018
//
// License          : MIT License
// ***********************************************************************

using System;
using System.IO.Pipes;
using DataRelay.Common;
using DataRelay.Common.DataContainers;

namespace DataRelay.Game
{
    public static class PipeServerFactory
    {
        private static NamedPipeServerStream NamedPipeToReturn { get; set; }

        public static NamedPipeServerStream GetNamedPipeServerStream(Type type)
        {
            AllCases().Case(type, DefaultAction);

            if (NamedPipeToReturn == null)
            {
                throw new InvalidOperationException("The pipe being returned cannot be null.");
            }

            return NamedPipeToReturn;
        }

        /// <summary>
        /// Contains cases for each type of container that needs a pipe server.
        /// </summary>
        private static TypeSwitch AllCases()
        {
            var typeSwitch = new TypeSwitch();

            typeSwitch.AddCase(typeof(GameInfoContainer), GameContainer);
            typeSwitch.AddCase(typeof(SpaceCenterContainer), SpaceCenterContainer);

            return typeSwitch;
        }

        private static void GameContainer()
        {
            NamedPipeToReturn = new NamedPipeServerStream("Test-Name");
        }

        private static void SpaceCenterContainer()
        {
            NamedPipeToReturn = new NamedPipeServerStream("Test-Name");
        }

        private static void DefaultAction()
        {
            NamedPipeToReturn = null;
        }
    }
}