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
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.Discogs.Data
{
    /// <remarks />
    [DataContract]
    public class Artist
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ArtistResult Data { get; set; }

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
        /// Create new Artist and clear the log
        /// </summary>
        public Artist()
        {
        }

        /// <summary>
        ///     Create new Artist with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Artist(ArtistResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class ArtistResult
    {
        /// <remarks />
        [DataMember(Name = "profile")]
        public string Profile { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "releases_url")]
        public string ReleasesUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "namevariations")]
        public List<string> Namevariations { get; set; }

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; } = new List<Image> {new Image()};

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "aliases")]
        public List<Alias> Aliases { get; set; } = new List<Alias> {new Alias()};

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "data_quality")]
        public string DataQuality { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "realname")]
        public string Realname { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Alias
    {
        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;
    }
}
