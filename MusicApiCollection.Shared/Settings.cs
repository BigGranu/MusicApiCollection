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

namespace MusicApiCollection
{
    /// <summary>
    ///     Global settings and Infos
    /// </summary>
    public class Settings
    {
        /// <summary>
        ///     Error Message
        /// </summary>
        public static string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public static bool ErrorOccurred = false;

        /// <summary>
        ///     Settings for the Webclient
        /// </summary>
        public class Http
        {
            /// <summary>
            ///     Timeout for HttpWebRequest
            /// </summary>
            public static int HttpWebRequestTimeout { get; set; } = 5000;

            /// <summary>
            ///     UserAgent for WebRequest
            /// </summary>
            public static string UserAgent { get; set; } =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/6.0;)";
        }

        /// <summary>
        ///     Settings for AcoustId
        /// </summary>
        public class AcoustId
        {
            /// <summary>
            ///     ClientKey for AcoustId
            /// </summary>
            public static string ClientKey { get; set; } = "VpSn30ms";
        }

        /// <summary>
        ///     Settings for TheAudioDb
        /// </summary>
        public class TheAudioDb
        {
            /// <summary>
            ///     ApiKey for TheAudoDB
            /// </summary>
            public static string ApiKey { get; set; } = "";
        }

        /// <summary>
        ///     Settings for FanartTv
        /// </summary>
        public class FanartTv
        {
            /// <summary>
            ///     ApiKey for FanartTv
            /// </summary>
            public static string ApiKey { get; set; } = "91b020d36e832bf14efc3a33c165994e";

            /// <summary>
            ///     ClientKey for FanartTv
            /// </summary>
            public static string ClientKey { get; set; } = "";

            /// <summary>
            ///     The current Server
            /// </summary>
            public static string Server { get; set; } = "http://webservice.fanart.tv/v3/";


            /// <summary>
            ///     Transparent Proxy
            /// </summary>
            public static bool Proxy
            {
                set { Server = value ? "http://fanarttv.apiary-proxy.com/v3/" : "http://webservice.fanart.tv/v3/"; }
            }
        }

        /// <summary>
        ///     Settings for FreeDb
        /// </summary>
        public class FreeDb
        {
            /// <summary>
            ///     The FreeDb Server as Full string. <br />
            ///     Example: http://freedb.freedb.org/~cddb/cddb.cgi
            /// </summary>
            public static string ServerUrl { get; set; } = "http://freedb.freedb.org/~cddb/cddb.cgi";

            /// <summary>
            ///     Login name of user. <br />
            ///     Example: johndoe
            /// </summary>
            public static string Username { get; set; } = "BigGranu";

            /// <summary>
            ///     Host name of client. <br />
            ///     Example: abc.fubar.com
            /// </summary>
            public static string Hostname { get; set; } = "MyPC";

            /// <summary>
            ///     The name of the connecting client. <br />
            ///     Example: xmcd, cda, EasyCD, et cetera. <br />
            ///     Do not use the name of another client which already exists
            /// </summary>
            public static string Clientname { get; set; } = "mInfo";

            /// <summary>
            ///     Version number of client software. <br />
            ///     Example: v1.0PL0
            /// </summary>
            public static string Version { get; set; } = "1.0";

            /// <summary>
            ///     Protocol level 5 + 6 specification by freedb developer team
            /// </summary>
            public static string Level { get; set; } = "4";
        }

        /// <summary>
        ///     Settings for GraceNote
        /// </summary>
        public class GraceNote
        {
            /// <summary>
            ///     User ID
            /// </summary>
            public static string UserId = "27396436067419940-9AEAE469D6BF0ECF8418602699BAC230";

            /// <summary>
            ///     Client ID
            /// </summary>
            public static string ClientId = "8038400-D6D9583FE60EA28CE621BC0EAD6ED8A0";

            /// <summary>
            ///     Server Url
            /// </summary>
            public static string ServerUrl { get; set; } = "https://c11451648.web.cddbp.net/webapi/xml/1.0/";

            /// <summary>
            ///     A query can include an optional LANG element to specify a preferred natural language in which to receive response
            ///     metadata. <br />
            ///     The body of the LANG element should be a three-character language code as defined by the ISO 639-2 standard. <br />
            ///     When possible, the Gracenote Media Recognition Service returns localized metadata in the language requested. <br />
            ///     If no metadata is available in the requested language, or if there is no language preference, metadata is returned
            ///     in English(eng) by default. <br />
            ///     Contact your Gracenote Global Services + Support representative for a list of supported languages.
            /// </summary>
            public static string ResponseLanguage { get; set; } = "eng";
        }

        /// <summary>
        ///     Settings for Discogs
        /// </summary>
        public class Discogs
        {
            /// <summary>
            ///     User Key
            /// </summary>
            public static string Key { get; set; } = "lvGHliBqYzdOLarMLnOx";

            /// <summary>
            ///     User Secret Key
            /// </summary>
            public static string SecretKey { get; set; } = "VxSChxKcJmeSPiZeMXSBuCEyZtuwxoyB";
        }
    }
}