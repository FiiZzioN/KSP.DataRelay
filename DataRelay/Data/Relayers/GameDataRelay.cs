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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace DataRelay.Data.Relayers
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