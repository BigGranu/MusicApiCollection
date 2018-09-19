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

namespace MusicApiCollection.Sites.FanartTv.Data
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
        ///     Create new Artist and clear the log
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
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "mbid_id")]
        public string MbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "artistbackground")]
        public List<ArtistImage> AImagesrtistbackground { get; set; } = new List<ArtistImage> {new ArtistImage()};

        /// <remarks />
        [DataMember(Name = "artistthumb")]
        public List<ArtistImage> Artistthumb { get; set; } = new List<ArtistImage> { new ArtistImage() };

        /// <remarks />
        [DataMember(Name = "musiclogo")]
        public List<ArtistImage> Musiclogo { get; set; } = new List<ArtistImage> { new ArtistImage() };

        /// <remarks />
        [DataMember(Name = "hdmusiclogo")]
        public List<ArtistImage> Hdmusiclogo { get; set; } = new List<ArtistImage> { new ArtistImage() };

        /// <remarks />
        [DataMember(Name = "albums")]
        public Dictionary<string, Albums> Albums { get; set; } = new Dictionary<string, Albums>();

        /// <remarks />
        [DataMember(Name = "musicbanner")]
        public List<ArtistImage> Musicbanner { get; set; } = new List<ArtistImage> { new ArtistImage() };
    }

    /// <remarks />
    [DataContract]
    public class Art
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "disc")]
        public string Disc { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "size")]
        public string Size { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class ArtistImage
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;
    }
}