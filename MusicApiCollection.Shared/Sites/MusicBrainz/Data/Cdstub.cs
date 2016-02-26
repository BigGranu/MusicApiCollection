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
    public class Cdstub
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public CdstubResult Data = new CdstubResult();

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
        ///     Create new Cdstub and clear the log
        /// </summary>
        public Cdstub()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Cdstub with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Cdstub(CdstubResult data)
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
    public class CdstubMetadata
    {
        /// <remarks />
        [XmlElement("cdstub-list")]
        public CdstubResult Cdstublist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class CdstubResult
    {
        /// <remarks />
        [XmlElement("cdstub")]
        public List<CdstubData> Data { get; set; } = new List<CdstubData> {new CdstubData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class CdstubData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("artist")]
        public string Artist { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("barcode")]
        public string Barcode { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("comment")]
        public string Comment { get; set; } = string.Empty;

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
