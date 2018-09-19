using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FanartTv.Data
{
    /// <remarks />
    [DataContract]
    public class Album
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AlbumResult Data { get; set; }

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
        ///     Create new Album and clear the log
        /// </summary>
        public Album()
        {
        }

        /// <summary>
        ///     Create new Album with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Album(AlbumResult data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
    }

    /// <remarks />
    [DataContract]
    public class AlbumResult
    {
        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "mbid_id")]
        public string MbidId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "albums")]
        public Dictionary<string, Albums> Albums { get; set; } = new Dictionary<string, Albums>();
    }

    /// <remarks />
    [DataContract]
    public class Albums
    {
        /// <remarks />
        [DataMember(Name = "cdart")]
        public List<Art> Cdart { get; set; } = new List<Art>();

        /// <remarks />
        [DataMember(Name = "albumcover")]
        public List<ArtistImage> Albumcover { get; set; } = new List<ArtistImage> { new ArtistImage() };
    }
}