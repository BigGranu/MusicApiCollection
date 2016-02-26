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
using System.Xml.Schema;
using System.Xml.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.MusicBrainz.Data
{
    /// <remarks />
    public class Annotation
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AnnotationResult Data = new AnnotationResult();

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
        ///     Create new Annotation and clear the log
        /// </summary>
        public Annotation()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Annotation with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Annotation(AnnotationResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class AnnotationMetadata
    {
        /// <remarks />
        [XmlElement("annotation-list")]
        public AnnotationResult Annotationlist { get; set; }

        /// <remarks/>
        [XmlAttribute("Created")]
        public System.DateTime Created { get; set; }
    }

    /// <remarks />
    public class AnnotationResult
    {
        /// <remarks />
        [XmlElement("annotation")]
        public List<AnnotationData> Data { get; set; } = new List<AnnotationData> {new AnnotationData()};

        /// <remarks />
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <remarks />
        [XmlAttribute("offset")]
        public int Offset { get; set; }
    }

    /// <remarks />
    public class AnnotationData
    {
        /// <summary>
        /// </summary>
        [XmlElement("entity")]
        public string Entity { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [XmlElement("Text")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// </summary>
        [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
        public int Score { get; set; }
    }
}
