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
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.CoverArtArchive.Data
{
    /// <summary>
    ///     Result
    /// </summary>
    public class Covers
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Data for the Request
        /// </summary>
        public CoversResult Data = new CoversResult();

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage = string.Empty;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response = string.Empty;

        /// <summary>
        ///     Create new Covers and clear the log
        /// </summary>
        public Covers()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Covers with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Covers(CoversResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Covers
    /// </summary>
    [DataContract]
    public class CoversResult
    {
        /// <summary>
        ///     List of Coverimages
        /// </summary>
        [DataMember(Name = "images")]
        public List<Cover> Images { get; set; } = new List<Cover> {new Cover()};

        /// <summary>
        ///     Release
        /// </summary>
        [DataMember(Name = "release")]
        public string Release { get; set; } = string.Empty;
    }

    /// <summary>
    ///     All Data of a Cover
    /// </summary>
    [DataContract]
    public class Cover
    {
        /// <summary>
        ///     List of Imagetypes
        /// </summary>
        [DataMember(Name = "types")]
        public List<string> Types { get; set; } = new List<string> {""};

        /// <summary>
        ///     Frontimage
        /// </summary>
        [DataMember(Name = "front")]
        public bool Front { get; set; }

        /// <summary>
        ///     Backimage
        /// </summary>
        [DataMember(Name = "back")]
        public bool Back { get; set; }

        /// <summary>
        ///     Edit?
        /// </summary>
        [DataMember(Name = "edit")]
        public int Edit { get; set; }

        /// <summary>
        ///     Image
        /// </summary>
        [DataMember(Name = "image")]
        public string Image { get; set; } = string.Empty;

        /// <summary>
        ///     Comment
        /// </summary>
        [DataMember(Name = "comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        ///     Approved?
        /// </summary>
        [DataMember(Name = "approved")]
        public bool Approved { get; set; }

        /// <summary>
        ///     ArchiveId
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     List of Thumbnails
        /// </summary>
        [DataMember(Name = "thumbnails")]
        public Thumbnails Thumbnails { get; set; } = new Thumbnails();
    }

    /// <summary>
    ///     Url for the Thumbnail
    /// </summary>
    [DataContract]
    public class Thumbnails
    {
        /// <summary>
        ///     Url for the large Thumbnail
        /// </summary>
        [DataMember(Name = "large")]
        public string Large { get; set; } = string.Empty;

        /// <summary>
        ///     Url for the small Thumbnail
        /// </summary>
        [DataMember(Name = "small")]
        public string Small { get; set; } = string.Empty;
    }
}