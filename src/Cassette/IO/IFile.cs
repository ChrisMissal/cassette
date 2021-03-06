﻿#region License
/*
Copyright 2011 Andrew Davey

This file is part of Cassette.

Cassette is free software: you can redistribute it and/or modify it under the 
terms of the GNU General Public License as published by the Free Software 
Foundation, either version 3 of the License, or (at your option) any later 
version.

Cassette is distributed in the hope that it will be useful, but WITHOUT ANY 
WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with 
Cassette. If not, see http://www.gnu.org/licenses/.
*/
#endregion

using System;
using System.IO;

namespace Cassette.IO
{
    public interface IFile
    {
        /// <summary>
        /// The directory containing the file.
        /// </summary>
        IDirectory Directory { get; }

        /// <summary>
        /// Gets if the file exists.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// Gets the last write time (UTC) of the file.
        /// </summary>
        DateTime LastWriteTimeUtc { get; }

        /// <summary>
        /// Gets the full application relative path of the file.
        /// </summary>
        string FullPath { get; }
     
        /// <summary>
        /// Opens a stream to the file.
        /// </summary>
        Stream Open(FileMode mode, FileAccess access, FileShare fileShare);

        /// <summary>
        /// Deletes the file.
        /// </summary>
        void Delete();
    }
}