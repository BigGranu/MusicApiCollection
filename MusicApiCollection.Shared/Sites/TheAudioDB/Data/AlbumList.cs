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
    public class AlbumList
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AlbumListResult Data = new AlbumListResult();

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
        ///     Create new AlbumList and clear the log
        /// </summary>
        public AlbumList()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new AlbumList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public AlbumList(AlbumListResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Album
    /// </summary>
    [DataContract]
    public class AlbumListResult
    {
        /// <summary>
        ///     List of Album
        /// </summary>
        [DataMember(Name = "album")]
        public List<Album> List { get; set; } = new List<Album>();
    }

    /// <summary>
    ///     Data for a Album
    /// </summary>
    [DataContract]
    public class Album
    {
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
        [DataMember(Name = "strAlbum")]
        public string StrAlbum { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtist")]
        public string StrArtist { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intYearReleased")]
        public string IntYearReleased { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strGenre")]
        public string StrGenre { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strSubGenre")]
        public string StrSubGenre { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strReleaseFormat")]
        public string StrReleaseFormat { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intSales")]
        public string IntSales { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strAlbumThumb")]
        public string StrAlbumThumb { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strAlbumCDart")]
        public string StrAlbumCDart { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionEN")]
        public string StrDescriptionEn { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionDE")]
        public string StrDescriptionDe { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionFR")]
        public string StrDescriptionFr { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionCN")]
        public string StrDescriptionCn { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionIT")]
        public string StrDescriptionIt { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionJP")]
        public string StrDescriptionJp { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionRU")]
        public string StrDescriptionRu { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionES")]
        public string StrDescriptionEs { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionPT")]
        public string StrDescriptionPt { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionSE")]
        public string StrDescriptionSe { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionNL")]
        public string StrDescriptionNl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionHU")]
        public string StrDescriptionHu { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionNO")]
        public string StrDescriptionNo { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionIL")]
        public string StrDescriptionIl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescriptionPL")]
        public string StrDescriptionPl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intLoved")]
        public string IntLoved { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intScore")]
        public string IntScore { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strReview")]
        public string StrReview { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMood")]
        public string StrMood { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTheme")]
        public string StrTheme { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strSpeed")]
        public string StrSpeed { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strLocation")]
        public string StrLocation { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzID")]
        public string StrMusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzArtistID")]
        public string StrMusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strItunesID")]
        public string StrItunesId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strAmazonID")]
        public string StrAmazonId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strLocked")]
        public string StrLocked { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDescription")]
        public string StrDescription { get; set; } = string.Empty;
    }
}
