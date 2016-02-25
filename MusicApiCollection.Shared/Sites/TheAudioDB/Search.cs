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
using System.Linq;
using MusicApiCollection.Events;
using MusicApiCollection.Sites.TheAudioDB.Data;

namespace MusicApiCollection.Sites.TheAudioDB
{
    /// <summary>
    ///     Search all Informations
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        #region Track

        /// <summary>
        ///     Return track details from artist/track name
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="trackName">Single</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList TrackList(string artistName, string trackName, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "TrackList");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("trackName", trackName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/searchtrack.php?s=" + artistName + "&t=" + trackName)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        /// <summary>
        ///     Return All Tracks for Album from known TADB_Track_ID
        /// </summary>
        /// <param name="tadbTrackId">TADB_Track_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList TrackList(TrackId tadbTrackId, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "TrackList");
            le.Parameters.Add(new Para("tadbTrackId", tadbTrackId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/track.php?h=" + tadbTrackId.Id)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        /// <summary>
        ///     Return All Tracks for Album from known TADB_Album_ID
        /// </summary>
        /// <param name="tadbAlbumId">TADB_Album_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList TrackList(AlbumId tadbAlbumId, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "TrackList");
            le.Parameters.Add(new Para("tadbAlbumId", tadbAlbumId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/track.php?m=" + tadbAlbumId.Id)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        /// <summary>
        ///     Return individual track info using a known MusicBrainz_Recording_ID
        /// </summary>
        /// <param name="mbid">MusicBrainz_Recording_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList TrackList(Guid mbid, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "TrackList");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>( Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/track-mb.php?i=" + mbid)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        /// <summary>
        ///     Return The top 10 Most Loved tracks for an Artist Name
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList Top10(string artistName, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Top10");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/track-top10.php?s=" + artistName)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        /// <summary>
        ///     Return The top 10 Most Loved tracks for an Artist Music Brainz ID
        /// </summary>
        /// <param name="mbid">Music_Brainz_Artist_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static TrackList Top10(Guid mbid, string apiKey = "")
        {
            var ret = new TrackList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Top10");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TrackListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/track-top10-mb.php?s=" + mbid)) ?? new TrackListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TrackList(ret.Data);
        }

        #endregion

        #region Artist

        /// <summary>
        ///     Return Artist details from artist name
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static Artist Artist(string artistName, string apiKey = "")
        {
            var ret = new Artist();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Artist");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<ArtistList>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/search.php?s=" + artistName)).List.FirstOrDefault() ?? new ArtistResult();               
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Artist(ret.Data);
        }

        /// <summary>
        ///     Return individual Artist info using a known MusicBrainz_Artist_ID
        /// </summary>
        /// <param name="mbid">MusicBrainz ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static Artist Artist(Guid mbid, string apiKey = "")
        {
            var ret = new Artist();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Artist");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<ArtistList>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/artist-mb.php?i=" + mbid)).List.FirstOrDefault() ?? new ArtistResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Artist(ret.Data);
        }

        /// <summary>
        ///     Return individual Artist info using a known TADB_Artist_ID
        /// </summary>
        /// <param name="tadbArtistId">TADB_Artist_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static Artist Artist(ArtistId tadbArtistId, string apiKey = "")
        {
            var ret = new Artist();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Artist");
            le.Parameters.Add(new Para("tadbArtistId", tadbArtistId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<ArtistList>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/artist.php?i=" + tadbArtistId.Id)).List.FirstOrDefault() ?? new ArtistResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Artist(ret.Data);
        }

        #endregion

        #region Discgraphy

        /// <summary>
        ///     Return Discography for an Artist with Album names and year only
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static DiscographyList Discography(string artistName, string apiKey = "")
        {
            var ret = new DiscographyList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Discography");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<DiscographyListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/discography.php?s=" + artistName)) ?? new DiscographyListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new DiscographyList(ret.Data);
        }

        /// <summary>
        ///     Return Discography for an Artist with Album names and year only using known MBID
        /// </summary>
        /// <param name="mbid">MusicBrainz ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static DiscographyList Discography(Guid mbid, string apiKey = "")
        {
            var ret = new DiscographyList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Discography");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<DiscographyListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/discography-mb.php?s=" + mbid)) ?? new DiscographyListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new DiscographyList(ret.Data);
        }

        #endregion

        #region Album

        /// <summary>
        ///     Return single album details from artist + album name
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="albumName">Album</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static AlbumList Album(string artistName, string albumName, string apiKey = "")
        {
            var ret = new AlbumList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Album");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("albumName", albumName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                if (artistName != "" & albumName != "")
                    ret.Data = Json.Deserialize<AlbumListResult>(
                            Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/searchalbum.php?s=" + artistName + "&a=" + albumName)) ?? new AlbumListResult();

                if (artistName != "" & albumName == "")
                    ret.Data = Json.Deserialize<AlbumListResult>(
                            Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/searchalbum.php?s=" + artistName)) ?? new AlbumListResult();

                if (artistName == "" & albumName != "")
                    ret.Data = Json.Deserialize<AlbumListResult>(
                            Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/searchalbum.php?a=" + albumName)) ?? new AlbumListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new AlbumList(ret.Data);
        }

        /// <summary>
        ///     Return All Albums for an Artist using known TADB_Artist_ID
        /// </summary>
        /// <param name="tadbArtistId">TADB_Artist_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static AlbumList Album(ArtistId tadbArtistId, string apiKey = "")
        {
            var ret = new AlbumList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Album");
            le.Parameters.Add(new Para("tadbArtistId", tadbArtistId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<AlbumListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/album.php?i=" + tadbArtistId.Id)) ?? new AlbumListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new AlbumList(ret.Data);
        }

        /// <summary>
        ///     Return All Albums for an Artist using known TADB_Album_ID
        /// </summary>
        /// <param name="tadbAlbumId">TADB_Album_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static AlbumList Album(AlbumId tadbAlbumId, string apiKey = "")
        {
            var ret = new AlbumList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Album");
            le.Parameters.Add(new Para("tadbAlbumId", tadbAlbumId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<AlbumListResult>( Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/album.php?m=" + tadbAlbumId.Id)) ?? new AlbumListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new AlbumList(ret.Data);
        }

        /// <summary>
        ///     Return All Albums for an Artist using known MusicBrainz_Release-Group_ID
        /// </summary>
        /// <param name="mbid">MusicBrainz_Release-Group_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static AlbumList Album(Guid mbid, string apiKey = "")
        {
            var ret = new AlbumList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Album");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<AlbumListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/album-mb.php?i=" + mbid)) ?? new AlbumListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new AlbumList(ret.Data);
        }

        #endregion

        #region Music Video

        /// <summary>
        ///     Return all the Music videos for a known TADB_Artist_ID
        /// </summary>
        /// <param name="tadbArtistId">TADB_Artist_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static VideoList Video(ArtistId tadbArtistId, string apiKey = "")
        {
            var ret = new VideoList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Video");
            le.Parameters.Add(new Para("tadbArtistId", tadbArtistId.Id));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<VideoListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/mvid.php?i=" + tadbArtistId.Id)) ?? new VideoListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new VideoList(ret.Data);
        }

        /// <summary>
        ///     Return all the Music videos for a known Music_Brainz_ID
        /// </summary>
        /// <param name="mbid">Music_Brainz_Artist_ID</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static VideoList Video(Guid mbid, string apiKey = "")
        {
            var ret = new VideoList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Video");
            le.Parameters.Add(new Para("mbid", mbid.ToString()));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<VideoListResult>( Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/mvid-mb.php?i=" + mbid)) ?? new VideoListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new VideoList(ret.Data);
        }

        /// <summary>
        ///     Return a Music DVD from artist/mdvd name
        /// </summary>
        /// <param name="artistName">Artist</param>
        /// <param name="dvdName">Music_Dvd_Name</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        public static VideoList Video(string artistName, string dvdName, string apiKey = "")
        {
            var ret = new VideoList();

            if (apiKey == "")
                apiKey = Settings.TheAudioDb.ApiKey;

            var le = new LogEntry("Sites.TheAudioDB", "Search", "Video");
            le.Parameters.Add(new Para("artistName", artistName));
            le.Parameters.Add(new Para("dvdName", dvdName));
            le.Parameters.Add(new Para("apiKey", apiKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<VideoListResult>(Http.Request("http://www.theaudiodb.com/api/v1/json/" + apiKey + "/searchmdvd.php?s=" + artistName + "&a=" + dvdName)) ?? new VideoListResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new VideoList(ret.Data);
        }

        #endregion
    }
}
