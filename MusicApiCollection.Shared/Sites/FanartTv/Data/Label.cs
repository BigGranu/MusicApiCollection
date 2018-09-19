using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FanartTv.Data
{
    /// <remarks />
    [DataContract]
    public class Label
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public LabelResult Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = Exceptions.Message;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; set; } = Exceptions.ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new Label and clear the log
        /// </summary>
        public Label()
        {
        }

        /// <summary>
        ///     Create new Label with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Label(LabelResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class LabelResult
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "musiclabel")]
        public List<Musiclabel> Labels { get; set; } = new List<Musiclabel> { new Musiclabel() };
    }

    /// <remarks />
    [DataContract]
    public class Musiclabel
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "colour")]
        public string Colour { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;
    }
}