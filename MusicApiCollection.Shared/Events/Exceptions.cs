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

namespace MusicApiCollection.Events
{
    /// <summary>
    ///     Handler for Exceptions
    /// </summary>
    public class Exceptions
    {
        /// <remarks />
        public delegate void EventHandler(object sender, EventArg e);
       
        /// <summary>
        ///     EventHandler for Exceptions
        /// </summary>
        public event EventHandler Call;

        /// <remarks />
        private static Exceptions Instance { get; set; }

        /// <summary>
        ///     Current Exception
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Create new Exceptions
        /// </summary>
        public Exceptions()
        {
            Instance = this;
        }

        /// <summary>
        ///     Instance of the Exceptions
        /// </summary>
        /// <returns>The Instance</returns>
        public static Exceptions GetInstance()
        {
            return Instance ?? new Exceptions();
        }

        /// <summary>
        ///     Rise a new Exception
        /// </summary>
        /// <param name="ex">The Exception</param>
        public void NewException(Exception ex)
        {
            Message = ex.Message;
            ErrorOccurred = true;
            var log = new EventArg { Exception = ex, Message = ex.Message};
            Call?.Invoke(new object(), log);
        }
    }

    /// <summary>
    ///     Exception Eventargument
    /// </summary>
    public class EventArg : EventArgs
    {
        /// <summary>
        ///     The Exceptionmessage
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        ///  The Full Exception
        /// </summary>
        public Exception Exception { get; set; } = new Exception();
    }
}