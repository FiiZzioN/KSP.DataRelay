// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-28-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-29-2018
//
// License          : MIT License
// ***********************************************************************

using DataRelay.Common.DataContainers;
using DataRelay.Game.Interfaces;

namespace DataRelay.Game.Providers
{
    public class SpaceCenterProvider : IDataProvider<SpaceCenterContainer>
    {
        /// <summary>
        /// The container that's holding this provider's data.
        /// </summary>
        public SpaceCenterContainer DataContainer { get; private set; }

        public void Start()
        {
            //var test = FindObjectOfType<TrackingStationBuilding>().Facility.CurrentLevel;

        }

        /// <summary>
        /// Gets the data associated with this provider.
        /// </summary>
        public SpaceCenterContainer GetData()
        {
            DataContainer = new SpaceCenterContainer
            {

            };

            return DataContainer;
        }

    }
}