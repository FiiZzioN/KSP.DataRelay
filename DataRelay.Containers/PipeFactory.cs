// ************************************************************************
// Assembly         : DataRelay.Common
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
using DataRelay.Common.Containers;

namespace DataRelay.Common
{
    public static class PipeFactory
    {
        private static NamedPipeServerStream NamedPipeToReturn { get; set; }


        public static NamedPipeServerStream GetNamedPipeServerStream(Type type)
        {
            var typeSwitch = new TypeSwitch();

            typeSwitch.AddCase(typeof(GameContainer), GetPipeForGameContainer);

            typeSwitch.Case(type, DefaultAction);

            return NamedPipeToReturn;
        }


        private static void GetPipeForGameContainer()
        {
            NamedPipeToReturn = new NamedPipeServerStream("Test-Name");
        }

        private static void DefaultAction()
        {
            NamedPipeToReturn = new NamedPipeServerStream("Default");
        }
    }
}