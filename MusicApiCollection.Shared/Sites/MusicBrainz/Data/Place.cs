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

using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks />
    public class Place
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public PlaceResult Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = Exceptions.Message;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; set; } = Exceptions.ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new Place and clear the log
        /// </summary>
        public Place()
        {
        }

        /// <summary>
        ///     Create new Place with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Place(PlaceResult data)
        {
            if (data.Data == null || data.Data.Count == 0)
                data.Data = new List<PlaceData> { new PlaceData() };

            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class PlaceMetadata
    {
        /// <remarks />
        [XmlElement("place-list")]
        public PlaceResult Placelist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class PlaceResult
    {
        /// <remarks />
        [XmlElement("place")]
        public List<PlaceData> Data { get; set; }

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class PlaceData
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("address")]
        public string Address { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("coordinates")]
        public Coordinates Coordinates { get; set; } = new Coordinates();

        /// <remarks />
        [XmlElement("area")]
        public GArea Area { get; set; } = new GArea();

        /// <remarks />
        [XmlElement("life-span")]
        public Lifespan Lifespan { get; set; } = new Lifespan();

        /// <remarks />
        [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
        public List<Alias> Aliaslist { get; set; } = new List<Alias> {new Alias()};

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }
    }
}
