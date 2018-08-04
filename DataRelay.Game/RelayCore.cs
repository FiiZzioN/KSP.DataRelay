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
using DataRelay.Common.DataContainers;
using DataRelay.Game.Providers;
using System;
using UnityEngine;

namespace DataRelay.Game
{
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class RelayCore : MonoBehaviour
    {
        public void Start()
        {

        }

        public void Update()
        {

        }

        public void FixedUpdate()
        {
            CheckForRequests();
        }

        private void CheckForRequests()
        {
            var value = PipeServer.Read();

            if (!String.IsNullOrEmpty(value))
            {
                SendData(value);
            }
        }

        private void SendData(string requestedContainer)
        {
            var convertedValue = Int32.Parse(requestedContainer);           

            switch (convertedValue)
            {
                case 0:
                    var dataContainer = new GameInfoProvider().GetData();
                    DataRelayer<GameInfoContainer>.RelayData(dataContainer);
                    break;
            }
        }
    }
}