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
using System.Xml.Serialization;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks />
    public class Lifespan
    {
        /// <remarks />
        [XmlElement("begin")]
        public string Begin { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("end")]
        public string End { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("ended")]
        public bool Ended { get; set; }
    }

    /// <remarks />
    public class Alias
    {
        /// <remarks />
        [XmlAttribute("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;

        /// <remarks />
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }

    /// <remarks />
    public class Iso31661Codelist
    {
        /// <remarks />
        [XmlElement("iso-3166-1-code")]
        public string Iso31661Code { get; set; } = string.Empty;
    }

    /// <remarks />
    public class Iso31663Codelist
    {
        /// <remarks />
        [XmlElement("iso-3166-3-code")]
        public string Iso31663Code { get; set; } = string.Empty;
    }

    /// <remarks />
    public class GArea
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("sort-name")]
        public string Sortname { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;
    }

    /// <remarks />
    public class GTracklist
    {
        /// <remarks/>
        [XmlElement("track")]
        public List<GTrack> Track { get; set; } = new List<GTrack> {new GTrack()};

        /// <remarks />
        [XmlAttribute("offset")]
        public string Offset { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("count")]
        public string Count { get; set; } = string.Empty;
    }

    /// <remarks />
    public class GTrack
    {
        /// <remarks />
        [XmlElement("position")]
        public string Position { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("number")]
        public string Number { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("length")]
        public int Length { get; set; }

        /// <remarks />
        [XmlElement("recording")]
        public GRecording Recording { get; set; } = new GRecording();

        /// <remarks />
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Disclist
    {
        /// <remarks/>
        [XmlElement("disc")]
        public Disc Disc { get; set; } = new Disc();

        /// <remarks/>
        [XmlAttribute("count")]
        public byte Count { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Disc
    {
        /// <remarks/>
        [XmlElement("sectors")]
        public string Sectors { get; set; } = string.Empty;

        /// <remarks/>
        [XmlElement("offset-list")]
        public DiscOffsetlist Offsetlist { get; set; }

        /// <remarks/>
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class DiscOffsetlist
    {
        /// <remarks/>
        [XmlElement("offset")]
        public List<Offset> Offset { get; set; } = new List<Offset> {new Offset()};

        /// <remarks/>
        [XmlAttribute("count")]
        public byte Count { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Offset
    {
        /// <remarks/>
        [XmlAttribute("position")]
        public byte Position { get; set; }

        /// <remarks/>
        [XmlText()]
        public uint Value { get; set; }
    }

    /// <remarks />
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class GTag
    {
        /// <remarks />
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [XmlAttribute("count")]
        public byte Count { get; set; }
    }

    /// <remarks />
    public class Coordinates
    {
        /// <remarks />
        [XmlElement("latitude")]
        public string Latitude { get; set; } = string.Empty;

        /// <remarks />
        [XmlElement("longitude")]
        public string Longitude { get; set; } = string.Empty;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class GRecording
    {
        /// <remarks/>
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <remarks/>
        [XmlElement("length")]
        public string Length { get; set; } = string.Empty;

        /// <remarks/>
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit", IsNullable = false)]
        public List<Namecredit> Artistcredit { get; set; } = new List<Namecredit> {new Namecredit()};

        /// <remarks/>
        [XmlAttribute("id")]
        public string Id { get; set; } = string.Empty;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Namecredit
    {
        /// <remarks/>
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks/>
        [XmlElement("artist")]
        public ArtistData Artist { get; set; } = new ArtistData();

        /// <remarks/>
        [XmlAttribute("joinphrase")]
        public string Joinphrase { get; set; } = string.Empty;
    }
}
