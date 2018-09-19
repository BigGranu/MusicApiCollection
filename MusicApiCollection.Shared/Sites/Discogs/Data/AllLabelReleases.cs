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
    public class AllLabelReleases
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AllLabelReleasesResult Data { get; set; }

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
        ///     Create new AllLabelReleases and clear the log
        /// </summary>
        public AllLabelReleases()
        {
        }

        /// <summary>
        ///     Create new AllLabelReleases with Result
        /// </summary>
        /// <param name="data">Result</param>
        public AllLabelReleases(AllLabelReleasesResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class AllLabelReleasesResult
    {
        /// <remarks />
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; }

        /// <remarks />
        [DataMember(Name = "releases")]
        public List<LabelRelease> Releases { get; set; }
    }

    /// <remarks />
    [DataContract]
    public class LabelRelease
    {
        /// <remarks />
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <remarks />
        [DataMember(Name = "thumb")]
        public string Thumb { get; set; }

        /// <remarks />
        [DataMember(Name = "format")]
        public string Format { get; set; }

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <remarks />
        [DataMember(Name = "catno")]
        public string Catno { get; set; }

        /// <remarks />
        [DataMember(Name = "year")]
        public int Year { get; set; }

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; }

        /// <remarks />
        [DataMember(Name = "artist")]
        public string Artist { get; set; }

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}