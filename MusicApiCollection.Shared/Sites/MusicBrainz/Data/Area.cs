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
    public partial class Area
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AreaResult Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new Area and clear the log
        /// </summary>
        public Area()
        {
        }

        /// <summary>
        ///     Create new Area with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Area(AreaResult data)
        {
            if (data.Data == null || data.Data.Count == 0)
                data.Data = new List<AreaData> { new AreaData() };

            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class AreaMetadata
    {
        /// <remarks />
        [XmlElement("area-list")]
        public AreaResult Arealist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks/>
    public class AreaResult
    {
        /// <remarks />
        [XmlElement("area")]
        public List<AreaData> Data { get; set; }

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class AreaData
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("iso-3166-3-code-list")]
        public Iso31663Codelist Iso31663 { get; set; } = new Iso31663Codelist();

        /// <remarks />
        [XmlElement("iso-3166-1-code-list")]
        public Iso31661Codelist Iso31661 { get; set; } = new Iso31661Codelist();

        /// <remarks />
        [XmlElement("life-span")]
        public Lifespan Lifespan { get; set; } = new Lifespan();

        /// <remarks />
        [XmlArray("alias-list")]
        [XmlArrayItem("alias", IsNullable = false)]
        public List<AreaAlias> Aliaslist { get; set; } = new List<AreaAlias> {new AreaAlias()};

        /// <remarks />
        [XmlElement("relation-list")]
        public AreaRelationlist Relationlist { get; set; } = new AreaRelationlist();

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

    /// <remarks />
    public class AreaAlias
    {
        /// <remarks />
        [XmlAttribute("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }

    /// <remarks />
    public class AreaRelationlist
    {
        /// <remarks />
        [XmlElement("relation")]
        public AreaRelation Relation { get; set; } = new AreaRelation();

        /// <remarks />
        [XmlAttribute("target-type")]
        public string Targettype { get; set; } = string.Empty;
    }

    /// <remarks />
    public class AreaRelation
    {
        /// <remarks />
        [XmlElement("target")]
        public string Target { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("direction")]
        public string Direction { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("area")]
        public GArea Area { get; set; } = new GArea();

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type-id")]
        public string Typeid { get; set; } = string.Empty;
    }

    /// <remarks />
    public class AreaRelationAreaLifespan
    {
        /// <remarks />
        [XmlElement("ended")]
        public bool Ended { get; set; }
    }
}
