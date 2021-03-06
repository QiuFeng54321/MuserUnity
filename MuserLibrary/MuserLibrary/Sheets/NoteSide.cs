﻿//   MuserLibrary
//   Copyright (C) 2020  Ye William
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
using System;
using System.Collections.Generic;
using System.Text;

namespace Muser.Sheets.Notes {
    /// <summary>
    /// The note side indexes
    /// </summary>
    public enum NoteSide : int {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        LEFT = 0,
        RIGHT = 1,
        UP = 2,
        DOWN = 3,
        UNKNOWN = 4
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
