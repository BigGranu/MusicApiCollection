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
    public class ArtistRelease
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ArtistReleaseResult Data { get; set; }

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
        /// Create new ArtistRelease and clear the log
        /// </summary>
        public ArtistRelease()
        {
        }

        /// <summary>
        ///     Create new ArtistRelease with Result
        /// </summary>
        /// <param name="data">Result</param>
        public ArtistRelease(ArtistReleaseResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class ArtistReleaseResult
    {
        /// <remarks />
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; } = new Pagination();

        /// <remarks />
        [DataMember(Name = "releases")]
        public List<ArtistReleases> Releases { get; set; } = new List<ArtistReleases> {new ArtistReleases()};
    }

    /// <remarks />
    [DataContract]
    public class ArtistReleases
    {
        /// <remarks />
        [DataMember(Name = "status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "thumb")]
        public string Thumb { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "format")]
        public string Format { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "label")]
        public string Label { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "role")]
        public string Role { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "year")]
        public int Year { get; set; }

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "artist")]
        public string Artist { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "main_release")]
        public int MainRelease { get; set; }
    }
}
