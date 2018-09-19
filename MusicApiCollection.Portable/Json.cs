#region Copyright (C) 2015-2018 BigGranu
/*
    Copyright (C) 2015-2018 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using MusicApiCollection.Events;

namespace MusicApiCollection
{
    /// <summary>
    ///     Json Functions
    /// </summary>
    internal class Json
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Deserialize a json string as Object
        /// </summary>
        /// <typeparam name="T">Objecttype</typeparam>
        /// <param name="json">Jsonstring</param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            try
            {
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };
                    var serializer = new DataContractJsonSerializer(typeof(T), settings);
                    return (T)serializer.ReadObject(ms);
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return (T) Activator.CreateInstance(typeof (T));
            }
        }
    }
}