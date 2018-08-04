// ***********************************************************************
// Assembly         : DataRelay.Common
//
// Author           : Nicholas Tyler
// Created          : 07-28-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-28-2018
//
// License          : MIT License
// ***********************************************************************

using System;
using System.Runtime.InteropServices;

namespace DataRelay.Common.DataContainers
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GameInfoContainer
    {
        public double UniversalTime { get; set; }

        public string LoadedScene { get; set; }

    }
}