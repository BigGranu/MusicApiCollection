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

namespace MusicApiCollection.Sites.FanartTv.Data
{
    /// <remarks />
    [DataContract]
    public class TvShow
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public TvShowResult Data = new TvShowResult();

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
        ///     Create new TvShow and clear the log
        /// </summary>
        public TvShow()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new TvShow with Result
        /// </summary>
        /// <param name="data">Result</param>
        public TvShow(TvShowResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class TvShowResult
    {
        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "thetvdb_id")]
        public string TheTvdbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "clearlogo")]
        public List<TvArt> Clearlogo { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "tvthumb")]
        public List<TvArt> Tvthumb { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "hdtvlogo")]
        public List<TvArt> HdTListvlogo { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "clearart")]
        public List<TvArt> Clearart { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "showbackground")]
        public List<TvImage> Showbackground { get; set; } = new List<TvImage>();

        /// <remarks />
        [DataMember(Name = "seasonposter")]
        public List<TvImage> Seasonposter { get; set; } = new List<TvImage>();

        /// <remarks />
        [DataMember(Name = "seasonthumb")]
        public List<TvImage> Seasonthumb { get; set; } = new List<TvImage>();

        /// <remarks />
        [DataMember(Name = "hdclearart")]
        public List<TvArt> Hdclearart { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "tvbanner")]
        public List<TvArt> Tvbanner { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "tvposter")]
        public List<TvArt> Tvposter { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "characterart")]
        public List<TvArt> Characterart { get; set; } = new List<TvArt>();

        /// <remarks />
        [DataMember(Name = "seasonbanner")]
        public List<TvImage> Seasonbanner { get; set; } = new List<TvImage>();
    }

    /// <remarks />
    [DataContract]
    public class TvArt
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "lang")]
        public string Lang { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class TvImage
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "lang")]
        public string Lang { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "season")]
        public string Season { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class TvLatest
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public List<TvLatestResult> Data { get; set; } = new List<TvLatestResult>();

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
        ///     Create new TvLatest and clear the log
        /// </summary>
        public TvLatest()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new TvLatest with Result
        /// </summary>
        /// <param name="data">Result</param>
        public TvLatest(List<TvLatestResult> data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class TvLatestResult
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "new_images")]
        public string NewImages { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "total_images")]
        public string TotalImages { get; set; } = string.Empty;
    }

}
