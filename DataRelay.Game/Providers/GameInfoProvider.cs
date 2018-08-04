// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-28-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-30-2018
//
// License          : MIT License
// ***********************************************************************

using DataRelay.Common.DataContainers;
using DataRelay.Game.Interfaces;

namespace DataRelay.Game.Providers
{
    /// <summary>
    /// Providers get the data for the relayers.
    /// </summary>
    /// <seealso cref="ScenarioModule" />
    /// <seealso cref="GameInfoContainer" />
    public class GameInfoProvider : IDataProvider<GameInfoContainer>
    {
        /// <summary>
        /// The container that's holding this provider's data.
        /// </summary>
        public GameInfoContainer DataContainer { get; private set; }

        /// <summary>
        /// Gets the data associated with this provider.
        /// </summary>
        public GameInfoContainer GetData()
        {
            var currentGame = HighLogic.CurrentGame;

            DataContainer = new GameInfoContainer
            {
                UniversalTime = currentGame.UniversalTime,
                LoadedScene   =  HighLogic.LoadedScene.ToString()
            };

            return DataContainer;
        }
    }
}