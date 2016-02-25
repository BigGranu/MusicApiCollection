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
    public class Artist
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ArtistResult Data = new ArtistResult();

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
        ///     Create new Artist and clear the log
        /// </summary>
        public Artist()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Artist with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Artist(ArtistResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <summary>
    ///     List of Artist
    /// </summary>
    [DataContract]
    public class ArtistList
    {
        /// <summary>
        ///     List of Artist
        /// </summary>
        [DataMember(Name = "artists")]
        public List<ArtistResult> List { get; set; } = new List<ArtistResult>();
    }

    /// <summary>
    ///     Data for a Artist
    /// </summary>
    [DataContract]
    public class ArtistResult
    {
        /// <summary>
        /// </summary>
        [DataMember(Name = "idArtist")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtist")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistAlternate")]
        public string NameAlternate { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "idLabel")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intFormedYear")]
        public string FormedYear { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intBornYear")]
        public string BornYear { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intDiedYear")]
        public string DiedYear { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strDisbanded")]
        public string Disbanded { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strGenre")]
        public string Genre { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strSubGenre")]
        public string SubGenre { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMood")]
        public string Mood { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strWebsite")]
        public string Website { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strFacebook")]
        public string Facebook { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strTwitter")]
        public string Twitter { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyEN")]
        public string BiographyEn { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyDE")]
        public string BiographyDe { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyFR")]
        public string BiographyFr { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyCN")]
        public string BiographyCn { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyIT")]
        public string BiographyIt { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyJP")]
        public string BiographyJp { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyRU")]
        public string BiographyRu { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyES")]
        public string BiographyEs { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyPT")]
        public string BiographyPt { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographySE")]
        public string BiographySe { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyNL")]
        public string BiographyNl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyHU")]
        public string BiographyHu { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyNO")]
        public string BiographyNo { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyIL")]
        public string BiographyIl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strBiographyPL")]
        public string BiographyPl { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strGender")]
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "intMembers")]
        public string Members { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strCountry")]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strCountryCode")]
        public string Countrycode { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistThumb")]
        public string ArtistThumb { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistLogo")]
        public string ArtistLogo { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistFanart")]
        public string ArtistFanart1 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistFanart2")]
        public string ArtistFanart2 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistFanart3")]
        public string ArtistFanart3 { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strArtistBanner")]
        public string ArtistBanner { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strMusicBrainzID")]
        public string MusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strLastFMChart")]
        public string LastFmChart { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [DataMember(Name = "strLocked")]
        public string Locked { get; set; } = string.Empty;
    }
}
