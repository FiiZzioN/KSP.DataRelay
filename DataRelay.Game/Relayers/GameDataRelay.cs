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

using UnityEngine;

namespace DataRelay.Game.Relayers
{
    //[KSPScenario(ScenarioCreationOptions.None, GameScenes.FLIGHT, GameScenes.SPACECENTER, GameScenes.TRACKSTATION)]
    [KSPAddon(KSPAddon.Startup.FlightAndKSC, false)]
    public class GameDataRelay : MonoBehaviour
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
    }
}