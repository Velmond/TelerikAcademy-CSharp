//-----------------------------------------------------------------------
// <copyright file="FileUtils.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Utilities
{
    using System;

    /// <summary>
    /// Provides with methods for working with file names
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        /// Gets the extension of the file
        /// </summary>
        /// <param name="fileName">Name of the file of which the extension is to be gotten</param>
        /// <returns>The extension</returns>
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new NullReferenceException();
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Gets the name of the file without its extension
        /// </summary>
        /// <param name="fileName">Name of the file with the extension of which the extension should be removed</param>
        /// <returns>The name of the file without its extension</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new NullReferenceException();
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
