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
    public class Freedb
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public FreedbResult Data = new FreedbResult();

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
        ///     Create new Freedb and clear the log
        /// </summary>
        public Freedb()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Freedb with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Freedb(FreedbResult data)
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
    public class FreedbMetadata
    {
        /// <remarks />
        [XmlElement("freedb-disc-list")]
        public FreedbResult Freedbdisclist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class FreedbResult
    {
        /// <remarks />
        [XmlElement("freedb-disc")]
        public List<FreedbData> Data { get; set; } = new List<FreedbData> {new FreedbData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class FreedbData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("artist")]
        public string Artist { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("category")]
        public string Category { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("year")]
        public string Year { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("track-list")]
        public GTracklist Tracklist { get; set; } = new GTracklist();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }
    }
}
