// ***********************************************************************
// Assembly         : DataRelay.Containers
//
// Author           : Nicholas Tyler
// Created          : 07-26-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-26-2018
//
// License          : MIT License
// ***********************************************************************

using System.Runtime.InteropServices;

namespace DataRelay.Containers
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GameContainer
    {
        public double UniversalTime { get; set; }
    }
}