// ***********************************************************************
// Assembly         : DataRelay
//
// Author           : Nicholas Tyler
// Created          : 07-28-2018
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-20-2018
//
// License          : MIT License
// ***********************************************************************

//using DataRelay.Game.Interfaces;
//using UnityEngine;

//namespace DataRelay.Game.Providers
//{
//    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
//    public class SpaceCenterDataProvider : MonoBehaviour, IDataProvider<SpaceCenterDataCapsule>
//    {
//        /// <summary>
//        /// The capsule that's holding this provider's data.
//        /// </summary>
//        protected SpaceCenterDataCapsule DataCapsule { get; set; }

//        public void Start()
//        {
//            DataCapsule = new SpaceCenterDataCapsule();
//        }

//        /// <summary>
//        /// Gets the data associated with this provider.
//        /// </summary>
//        public SpaceCenterDataCapsule GetData()
//        {
//            return DataCapsule;
//        }
//    }
//}