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

namespace MusicApiCollection.Sites.Discogs.Data
{
    /// <remarks />
    [DataContract]
    public class MasterRelease
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public MasterReleaseResult Data = new MasterReleaseResult();

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
        /// Create new MasterRelease and clear the log
        /// </summary>
        public MasterRelease()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new MasterRelease with Result
        /// </summary>
        /// <param name="data">Result</param>
        public MasterRelease(MasterReleaseResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class MasterReleaseResult
    {
        /// <remarks />
        [DataMember(Name = "styles")]
        public List<string> Styles { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "genres")]
        public List<string> Genres { get; set; } = new List<string> {""};

        /// <remarks />
        [DataMember(Name = "videos")]
        public List<Video> Videos { get; set; } = new List<Video> {new Video()};

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "main_release")]
        public int MainRelease { get; set; }

        /// <remarks />
        [DataMember(Name = "main_release_url")]
        public string MainReleaseUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "artists")]
        public List<ReleaseArtist> Artists { get; set; } = new List<ReleaseArtist> {new ReleaseArtist()};

        /// <remarks />
        [DataMember(Name = "versions_url")]
        public string VersionsUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "year")]
        public int Year { get; set; }

        /// <remarks />
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; } = new List<Image> {new Image()};

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "tracklist")]
        public List<Tracklist> Tracklist { get; set; } = new List<Tracklist> {new Tracklist()};

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "data_quality")]
        public string DataQuality { get; set; } = string.Empty;
    }
}
