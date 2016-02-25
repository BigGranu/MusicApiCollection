#region Copyright (C) 2015-2016 BigGranu
/*
    Copyright (C) 2015-2016 BigGranu

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
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection
{
    /// <summary>
    ///     Xml Functions
    /// </summary>
    internal class Xml
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Deserialize a xml string as Object
        /// </summary>
        /// <param name="xml">xml string</param>
        /// <typeparam name="T">Objecttype</typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string xml)
        {
            try
            {
                dynamic xs = new XmlSerializer(typeof (T));
                using (TextReader reader = new StringReader(xml))
                {
                    return xs.Deserialize(reader);
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