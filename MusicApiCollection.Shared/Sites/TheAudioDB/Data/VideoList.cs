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

namespace MusicApiCollection.Sites.TheAudioDB.Data
{
    /// <remarks />
    [DataContract]
    public class VideoList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public VideoListResult Data = new VideoListResult();

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
        ///     Create new VideoList and clear the log
        /// </summary>
        public VideoList()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new VideoList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public VideoList(VideoListResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Video
    /// </summary>
    [DataContract]
    public class VideoListResult
    {
        /// <summary>
        ///     List of Video
        /// </summary>
        [DataMember(Name = "mvids")]
        public List<Mvid> List { get; set; } = new List<Mvid>();
    }

    /// <summary>
    ///     Data for a Video
    /// </summary>
    [DataContract]
    public class Mvid
    {
        /// <summary>
        /// </summary>
        [DataMember(Name = "idArtist")]
        public string ArtistId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzArtistID")]
        public string MusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "idAlbum")]
        public string AlbumId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "idTrack")]
        public string TrackId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTrack")]
        public string Track { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTrackThumb")]
        public string TrackThumb { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVid")]
        public string MusicVid { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescription")]
        public string Description { get; set; } = string.Empty;
    }
}
