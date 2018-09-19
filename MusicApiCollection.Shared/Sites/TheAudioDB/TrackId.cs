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

namespace MusicApiCollection.Sites.TheAudioDB
{
    /// <summary>
    ///     TheAudioDb TrackID
    /// </summary>
    public class TrackId
    {
        /// <summary>
        ///     TrackID
        /// </summary>
        public string Id;

        /// <summary>
        ///     Create a new TrackID
        /// </summary>
        /// <param name="id">ID</param>
        public TrackId(string id)
        {
            Id = id;
        }
    }
}
