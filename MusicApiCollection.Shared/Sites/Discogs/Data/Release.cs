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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.Discogs.Data
{
    /// <remarks />
    [DataContract]
    public class Release
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ReleaseResult Data = new ReleaseResult();

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
        /// Create new Release and clear the log
        /// </summary>
        public Release()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Release with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Release(ReleaseResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class ReleaseResult
    {
        /// <remarks />
        [DataMember(Name = "status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "styles")]
        public List<string> Styles { get; set; } = new List<string>();

        /// <remarks />
        [DataMember(Name = "videos")]
        public List<Video> Videos { get; set; } = new List<Video>();

        /// <remarks />
        [DataMember(Name = "series")]
        public List<object> Series { get; set; } = new List<object>();

        /// <remarks />
        [DataMember(Name = "released_formatted")]
        public string ReleasedFormatted { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "labels")]
        public List<ReleaseLabel> Labels { get; set; } = new List<ReleaseLabel>();

        /// <remarks />
        [DataMember(Name = "estimated_weight")]
        public int EstimatedWeight { get; set; }

        /// <remarks />
        [DataMember(Name = "community")]
        public Community Community { get; set; }

        /// <remarks />
        [DataMember(Name = "released")]
        public string Released { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "master_url")]
        public string MasterUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "year")]
        public int Year { get; set; }

        /// <remarks />
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }

        /// <remarks />
        [DataMember(Name = "date_added")]
        public DateTime DateAdded { get; set; }

        /// <remarks />
        [DataMember(Name = "format_quantity")]
        public int FormatQuantity { get; set; }

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "genres")]
        public List<string> Genres { get; set; }

        /// <remarks />
        [DataMember(Name = "thumb")]
        public string Thumb { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "extraartists")]
        public List<Extraartist> Extraartists { get; set; }

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "country")]
        public string Country { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "notes")]
        public string Notes { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "identifiers")]
        public List<Identifier> Identifiers { get; set; }

        /// <remarks />
        [DataMember(Name = "companies")]
        public List<Company> Companies { get; set; }

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "artists")]
        public List<ReleaseArtist> Artists { get; set; }

        /// <remarks />
        [DataMember(Name = "formats")]
        public List<Format> Formats { get; set; }

        /// <remarks />
        [DataMember(Name = "date_changed")]
        public DateTime DateChanged { get; set; }

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "master_id")]
        public int MasterId { get; set; }

        /// <remarks />
        [DataMember(Name = "tracklist")]
        public List<Tracklist> Tracklist { get; set; }

        /// <remarks />
        [DataMember(Name = "data_quality")]
        public string DataQuality { get; set; } = string.Empty;
    }

     /// <remarks />
    [DataContract]
    public class Rating
    {
        /// <remarks />
        [DataMember(Name = "count")]
        public int Count { get; set; }

        /// <remarks />
        [DataMember(Name = "average")]
        public string Average { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Submitter
    {
        /// <remarks />
        [DataMember(Name = "username")]
        public string Username { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Contributor
    {
        /// <remarks />
        [DataMember(Name = "username")]
        public string Username { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class ReleaseLabel
    {
        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "entity_type")]
        public string EntityType { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "catno")]
        public string Catno { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "entity_type_name")]
        public string EntityTypeName { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Identifier
    {
        /// <remarks />
        [DataMember(Name = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "value")]
        public string Value { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "description")]
        public string Description { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Company
    {
        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "entity_type")]
        public string EntityType { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "catno")]
        public string Catno { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "entity_type_name")]
        public string EntityTypeName { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Format
    {
        /// <remarks />
        [DataMember(Name = "descriptions")]
        public List<string> Descriptions { get; set; } = new List<string>();

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "qty")]
        public string Qty { get; set; } = string.Empty;
    }
}
