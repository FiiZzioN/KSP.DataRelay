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

namespace DataRelay.Game.Interfaces
{
    /// <summary>
    /// Signifies that an <see cref="object"/> holds and provides a certain type of data.
    /// </summary>
    /// <typeparam name="T">The type of container that'll be provided.</typeparam>
    public interface IDataProvider<T> where T : struct
    {
        void Start();

        /// <summary>
        /// Gets the data associated with this provider.
        /// </summary>
        T GetData();
    }
}