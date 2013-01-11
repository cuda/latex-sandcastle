/*
 * Copyright 2008 Marcus Cuda - http://marcuscuda.com
 *
 *  This file is part of LaTeX Build Component.
 *
 *  LaTeX Build Component is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  LaTeX Build Component is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with LaTeX Build Component.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Runtime.InteropServices;

namespace LatexBuildComponent
{
    public static class SafeNativeMethods
    {
        [DllImport("mimetex.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)] 
        public static extern void CreateGifFromEq([MarshalAs(UnmanagedType.LPStr)] string expression, [MarshalAs(UnmanagedType.LPStr)] string gifFileName, [MarshalAs(UnmanagedType.LPStr)] string defaultSize);
    }
}