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

namespace MusicApiCollection.Sites.Discogs.Data
{
    /// <remarks />
    [DataContract]
    public class Video
    {
        /// <remarks />
        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        /// <remarks />
        [DataMember(Name = "description")]
        public string Description { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "embed")]
        public bool Embed { get; set; }

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Image
    {
        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <remarks />
        [DataMember(Name = "width")]
        public int Width { get; set; }

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "uri150")]
        public string Uri150 { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class ReleaseArtist
    {
        /// <remarks />
        [DataMember(Name = "join")]
        public string Join { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "anv")]
        public string Anv { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "tracks")]
        public string Tracks { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "role")]
        public string Role { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }

    /// <remarks />
    [DataContract]
    public class Extraartist
    {
        /// <remarks />
        [DataMember(Name = "join")]
        public string Join { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "anv")]
        public string Anv { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "tracks")]
        public string Tracks { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "role")]
        public string Role { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }

    /// <remarks />
    [DataContract]
    public class Tracklist
    {
        /// <remarks />
        [DataMember(Name = "duration")]
        public string Duration { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "position")]
        public string Position { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "type_")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "extraartists")]
        public List<Extraartist> Extraartists { get; set; } = new List<Extraartist> {new Extraartist()};
    }

    /// <remarks />
    [DataContract]
    public class Pagination
    {
        /// <remarks />
        [DataMember(Name = "per_page")]
        public int PerPage { get; set; }

        /// <remarks />
        [DataMember(Name = "items")]
        public int Items { get; set; }

        /// <remarks />
        [DataMember(Name = "page")]
        public int Page { get; set; }

        /// <remarks />
        [DataMember(Name = "urls")]
        public Urls Urls { get; set; } = new Urls();

        /// <remarks />
        [DataMember(Name = "pages")]
        public int Pages { get; set; }
    }

    /// <remarks />
    [DataContract]
    public class Urls
    {
        /// <remarks />
        [DataMember(Name = "last")]
        public string Last { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "next")]
        public string Next { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class Community
    {
        /// <remarks />
        [DataMember(Name = "status")]
        public string Status { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "rating")]
        public Rating Rating { get; set; } = new Rating();

        /// <remarks />
        [DataMember(Name = "have")]
        public int Have { get; set; }

        /// <remarks />
        [DataMember(Name = "contributors")]
        public List<Contributor> Contributors { get; set; } = new List<Contributor> {new Contributor()};

        /// <remarks />
        [DataMember(Name = "want")]
        public int Want { get; set; }

        /// <remarks />
        [DataMember(Name = "submitter")]
        public Submitter Submitter { get; set; } = new Submitter();

        /// <remarks />
        [DataMember(Name = "data_quality")]
        public string DataQuality { get; set; } = string.Empty;
    }
}
