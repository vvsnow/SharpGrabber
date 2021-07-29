﻿namespace DotNetTools.SharpGrabber
{
    /// <summary>
    /// Describes size of a rectangle - width, and height.
    /// </summary>
    public class Size
    {
        #region Properties
        /// <summary>
        /// Size width
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Size height
        /// </summary>
        public int Height { get; }
        #endregion

        #region Constructor

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

        #endregion

        #region Methods
        /// <inheritdoc />
        public override string ToString()
        {
            return $"{Width}x{Height}";
        }
        #endregion
    }
}