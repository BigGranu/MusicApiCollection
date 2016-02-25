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

namespace MusicApiCollection.Sites.TheAudioDB.Data
{
    /// <remarks />
    [DataContract]
    public class TrackList
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public TrackListResult Data = new TrackListResult();

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
        ///     Create new TrackList and clear the log
        /// </summary>
        public TrackList()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new TrackList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public TrackList(TrackListResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Track
    /// </summary>
    [DataContract]
    public class TrackListResult
    {
        /// <summary>
        ///     List of Track
        /// </summary>
        [DataMember(Name = "track")]
        public List<Track> List { get; set; } = new List<Track>();
    }

    /// <summary>
    ///     Data for a Track
    /// </summary>
    [DataContract]
    public class Track
    {
        /// <summary>
        /// </summary>
        [DataMember(Name = "idTrack")]
        public string IdTrack { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "idAlbum")]
        public string IdAlbum { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "idArtist")]
        public string IdArtist { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTrack")]
        public string StrTrack { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strAlbum")]
        public string StrAlbum { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtist")]
        public string StrArtist { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intCD")]
        public string IntCd { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intDuration")]
        public string IntDuration { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strGenre")]
        public string StrGenre { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionEN")]
        public string StrDescriptionEn { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTrackThumb")]
        public string StrTrackThumb { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTrackLyrics")]
        public string StrTrackLyrics { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVid")]
        public string StrMusicVid { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVidDirector")]
        public string StrMusicVidDirector { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVidCompany")]
        public string StrMusicVidCompany { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVidScreen1")]
        public string StrMusicVidScreen1 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVidScreen2")]
        public string StrMusicVidScreen2 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicVidScreen3")]
        public string StrMusicVidScreen3 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intTrackNumber")]
        public string IntTrackNumber { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intLoved")]
        public string IntLoved { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzID")]
        public string StrMusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzAlbumID")]
        public string StrMusicBrainzAlbumId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzArtistID")]
        public string StrMusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strLocked")]
        public string StrLocked { get; set; } = string.Empty;
    }
}
