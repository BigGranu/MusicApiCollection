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

namespace MusicApiCollection.Data
{
    /// <summary>
    ///     Global Artist
    /// </summary>
    public class Artist
    {
        /// <summary>
        ///     FanartTv Data
        /// </summary>
        public Sites.FanartTv.Data.Artist FanartTv { get; set; } = new Sites.FanartTv.Data.Artist();

        /// <summary>
        ///     MucicBrainz Data
        /// </summary>
        public Sites.MusicBrainz.Data.Artist MusicBrainz { get; set; } = new Sites.MusicBrainz.Data.Artist();

        /// <summary>
        ///     TheAudioDb Data
        /// </summary>
        public Sites.TheAudioDB.Data.Artist TheAudioDB { get; set; } = new Sites.TheAudioDB.Data.Artist();
    }
}