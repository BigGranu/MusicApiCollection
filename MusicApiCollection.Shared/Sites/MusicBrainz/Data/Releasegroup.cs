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
    public class Releasegroup
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ReleasegroupResult Data { get; set; }

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
        ///     Create new Releasegroup and clear the log
        /// </summary>
        public Releasegroup()
        {
        }

        /// <summary>
        ///     Create new Releasegroup with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Releasegroup(ReleasegroupResult data)
        {
            if (data.Data == null || data.Data.Count == 0)
                data.Data = new List<ReleasegroupData> { new ReleasegroupData() };

            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class ReleasegroupMetadata
    {
        /// <remarks />
        [XmlElement("release-group-list")]
        public ReleasegroupResult Releasegrouplist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class ReleasegroupResult
    {
        /// <remarks />
        [XmlElement("release-group")]
        public List<ReleasegroupData> Data { get; set; }

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class ReleasegroupData
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("primary-type")]
        public string Primarytype { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("artist-credit")]
        public ReleasegroupArtistcredit Artistcredit { get; set; } = new ReleasegroupArtistcredit();

        /// <remarks />
        [XmlElement("release-list")]
        public ReleasegroupReleaselist Releaselist { get; set; } = new ReleasegroupReleaselist();

        /// <remarks/>
        [XmlElement("first-release-date", DataType = "date")]
        public System.DateTime Firstreleasedate { get; set; }

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
    public class ReleasegroupArtistcredit
    {
        /// <remarks />
        [XmlElement("name-credit")]
        public ReleasegroupNamecredit Namecredit { get; set; } = new ReleasegroupNamecredit();
    }

    /// <remarks />
    public class ReleasegroupNamecredit
    {
        /// <remarks />
        [XmlElement("artist")]
        public ReleasegroupArtist Artist { get; set; } = new ReleasegroupArtist();
    }

    /// <remarks />
    public class ReleasegroupArtist
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("disambiguation")]
        public string Disambiguation { get; set; } = string.Empty;

        /// <remarks />
        [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
        public List<Alias> Aliaslist { get; set; } = new List<Alias> {new Alias()};

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks />
    public class ReleasegroupReleaselist
    {
        /// <remarks />
        [XmlElement("release")]
        public List<ReleasegroupRelease> Release { get; set; } = new List<ReleasegroupRelease> {new ReleasegroupRelease()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }
    }

    /// <remarks />
    public class ReleasegroupRelease
    {
        /// <remarks />
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }
}
