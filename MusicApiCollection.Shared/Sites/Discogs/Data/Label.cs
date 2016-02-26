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
    public class Label
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public LabelResult Data = new LabelResult();

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
        /// Create new Label and clear the log
        /// </summary>
        public Label()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Label with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Label(LabelResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class LabelResult
    {
        /// <remarks />
        [DataMember(Name = "profile")]
        public string Profile { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "releases_url")]
        public string ReleasesUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "parent_label")]
        public ParentLabel ParentLabel { get; set; } = new ParentLabel();

        /// <remarks />
        [DataMember(Name = "uri")]
        public string Uri { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; } = new List<Image> {new Image()};

        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "data_quality")]
        public string DataQuality { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class ParentLabel
    {
        /// <remarks />
        [DataMember(Name = "resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;
    }
}
