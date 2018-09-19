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

using System;
using System.Collections.Generic;

namespace MusicApiCollection.Events
{
    /// <summary>
    ///     Handler for Logging
    /// </summary>
    public class Logging
    {
        private static Logging _instance;

        /// <remarks />
        public delegate void EventHandler(object sender, LogEntry e);

        /// <summary>
        ///     Create new Logging
        /// </summary>
        public Logging()
        {
            _instance = this;
        }

        /// <remarks />
        public static Logging Instance => _instance ?? (_instance = new Logging());

        /// <summary>
        ///     EventHandler for Logging
        /// </summary>
        public event EventHandler Call;

        /// <summary>
        /// </summary>
        /// <param name="entry"></param>
        public void NewLogEntry(LogEntry entry)
        {
            Call?.Invoke(new object(), entry);
        }

        /// <summary>
        ///     Clear the Exception
        /// </summary>
        internal static void Clear()
        {
            var exc = Exceptions.Instance;
            exc.Message = string.Empty;
            exc.ErrorOccurred = false;
            Http.LastResponse = string.Empty;
        }
    }

    /// <summary>
    ///     Logentry
    /// </summary>
    public class LogEntry : EventArgs
    {
        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        public LogEntry(string namespaceValue, string classValue, string functionValue, List<Para> parameters)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = parameters;
        }

        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        public LogEntry(string namespaceValue, string classValue, string functionValue, Para para)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = new List<Para> {para};
        }

        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        public LogEntry(string namespaceValue, string classValue, string functionValue)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = new List<Para> {new Para("", "")};
        }

        /// <summary>
        ///     The Namespace of the Caller
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     The Class of the Caller
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///     The Method of the Caller
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        ///     The Parameters for the Function
        /// </summary>
        public List<Para> Parameters { get; set; }
    }

    /// <summary>
    ///     The parameter for the Function
    /// </summary>
    public class Para
    {
        /// <summary>
        ///     Create a new Parameter
        /// </summary>
        /// <param name="name">Parametername</param>
        /// <param name="value">Parametervalue</param>
        public Para(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        ///     Parametername
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Parametervalue
        /// </summary>
        public string Value { get; set; }
    }
}