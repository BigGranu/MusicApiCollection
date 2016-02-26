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

using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks />
    public class Work
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public WorkResult Data = new WorkResult();

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
        ///     Create new Work and clear the log
        /// </summary>
        public Work()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Work with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Work(WorkResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class WorkMetadata
    {
        /// <remarks />
        [XmlElement("work-list")]
        public WorkResult Worklist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class WorkResult
    {
        /// <remarks />
        [XmlElement("work")]
        public List<WorkData> Data { get; set; } = new List<WorkData> {new WorkData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class WorkData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("language")]
        public string Language { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("iswc-list")]
        public WorkIswclist Iswclist { get; set; } = new WorkIswclist();

        /// <remarks />
        [XmlElement("disambiguation")]
        public string Disambiguation { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("alias-list")]
        public WorkAliaslist Aliaslist { get; set; } = new WorkAliaslist();

        /// <remarks />
        [XmlElement("relation-list")]
        public WorkRelationlist Relationlist { get; set; } = new WorkRelationlist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;
    }

    /// <remarks />
    public class WorkIswclist
    {
        /// <remarks />
        [XmlElement("iswc")]
        public string Iswc { get; set; } = string.Empty;
    }

    /// <remarks />
    public class WorkAliaslist
    {
        /// <remarks />
        [XmlElement("alias")]
        public Alias Alias { get; set; } = new Alias();
    }

    /// <remarks />
    public class WorkRelationlist
    {
        /// <remarks />
        [XmlElement("relation")]
        public List<WorkRelation> Relation { get; set; } = new List<WorkRelation> {new WorkRelation()};

        /// <remarks />
        [XmlAttribute("target-type")]
        public string Targettype { get; set; } = string.Empty;
    }

    /// <remarks />
    public class WorkRelation
    {
        /// <remarks />
        [XmlElement("direction")]
        public string Direction { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("attribute-list")]
        public WorkAttributelist Attributelist { get; set; } = new WorkAttributelist();

        /// <remarks />
        [XmlElement("artist")]
        public WorkRelationArtist Artist { get; set; } = new WorkRelationArtist();

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;
    }

    /// <remarks />
    public class WorkAttributelist
    {
        /// <remarks />
        [XmlElement("attribute")]
        public string Attribute { get; set; } = string.Empty;
    }

    /// <remarks />
    public class WorkRelationArtist
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }
}
