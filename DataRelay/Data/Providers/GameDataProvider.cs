// ************************************************************************
// Assembly         : DataRelay
// 
// Author           : Nicholas Tyler
// Created          : 07-20-2018
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-20-2018
// 
// License          : MIT License
// ***********************************************************************

using DataRelay.Common.Containers;
using DataRelay.Data.Interfaces;
using DataRelay.Data.Relayers;

namespace DataRelay.Data.Providers
{
    public class GameDataProvider : ScenarioModule, IDataProvider<GameContainer>
    {
        public void Start()
        {

        }

        public void FixedUpdate()
        {
            
        }

        public void OnDisable()
        {

        }

        /// <summary>
        /// Gets the data associated with this provider.
        /// </summary>
        public GameContainer GetData()
        {
            var container = new GameContainer
            {
                UniversalTime = HighLogic.CurrentGame.UniversalTime
            };

            return container;
        }
    }
}