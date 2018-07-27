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

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataRelay.Common
{
    public static class Utilities
    {
        /// <summary>
        /// Serializes the specified object to a byte array.
        /// </summary>
        /// <param name="obj">The object you want to serialize.</param>
        public static byte[] SerializeToByteArray(object obj)
        {
            var binaryFormatter = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);

                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// Deserializes the specified byte array into an object.
        /// </summary>
        /// <param name="array">The array to convert into an object.</param>
        private static object ByteArrayToObject(byte[] array)
        {
            using (var memoryStream = new MemoryStream(array))
            {
                var binaryFormatter = new BinaryFormatter();
                var obj = binaryFormatter.Deserialize(memoryStream);

                return obj;
            }
        }
    }
}