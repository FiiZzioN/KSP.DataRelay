// ************************************************************************
// Assembly         : DataRelay.Common
// 
// Author           : Nicholas Tyler
// Created          : 07-26-2018
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 07-26-2018
// 
// License          : MIT License
// ***********************************************************************

using System;
using System.Collections.Generic;

namespace DataRelay.Common
{
    /// <summary>
    /// A class built to extend switch-statement like functionality to Types.
    /// </summary>
    public class TypeSwitch
    {
        public TypeSwitch()
        {
            Cases = new Dictionary<Type, Action>();
        }

        private Dictionary<Type, Action> _cases;

        /// <summary>
        /// Gets or sets the case sections for this statement.
        /// </summary>
        public Dictionary<Type, Action> Cases
        {
            get { return _cases ?? (_cases = new Dictionary<Type, Action>()); }

            set
            {
                if (_cases == null)
                {
                    return;
                }

                _cases = value;                 
            }
        }

        /// <summary>
        /// Adds a case section to the switch statement for the specified type, and the action to perform should it be matched.
        /// </summary>
        /// <param name="type">The type to watch for.</param>
        /// <param name="action">The action to perform if the type is matched.</param>
        /// <exception cref="System.InvalidOperationException">An action for that type has already been defined.</exception>
        public void AddCase(Type type, Action action)
        {
            if (Cases.ContainsKey(type))
            {
                throw new InvalidOperationException("An action for that type has already been defined.");
            }

            Cases.Add(type, action);
        }

        /// <summary>
        /// Goes through the cases trying to find a match for type specified. If no match is found, "defaultAction" will be invoked.
        /// </summary>
        /// <param name="type">The type to watch for.</param>
        /// <param name="defaultAction">The action to perform if the type remains unmatched.</param>
        public Action Case(Type type, Action defaultAction)
        {
            return Cases.ContainsKey(type) ? Cases[type] : defaultAction;
        }
    }
}