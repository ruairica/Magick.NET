﻿// Copyright 2013-2020 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using System;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    /// <summary>
    /// Interface that represents a color.
    /// </summary>
    public interface IMagickColor : IEquatable<IMagickColor>, IComparable<IMagickColor>
    {
        /// <summary>
        /// Gets or sets the alpha component value of this color.
        /// </summary>
        QuantumType A { get; set; }

        /// <summary>
        /// Gets or sets the blue component value of this color.
        /// </summary>
        QuantumType B { get; set; }

        /// <summary>
        /// Gets or sets the green component value of this color.
        /// </summary>
        QuantumType G { get; set; }

        /// <summary>
        /// Gets a value indicating whether the color is a CMYK color.
        /// </summary>
        bool IsCmyk { get; }

        /// <summary>
        /// Gets or sets the key (black) component value of this color.
        /// </summary>
        QuantumType K { get; set; }

        /// <summary>
        /// Gets or sets the red component value of this color.
        /// </summary>
        QuantumType R { get; set; }

        /// <summary>
        /// Determines whether the specified color is fuzzy equal to the current color.
        /// </summary>
        /// <param name="other">The color to compare this color with.</param>
        /// <param name="fuzz">The fuzz factor.</param>
        /// <returns>True when the specified color is fuzzy equal to the current instance.</returns>
        bool FuzzyEquals(IMagickColor other, Percentage fuzz);

        /// <summary>
        /// Initializes the color with the specified bytes.
        /// </summary>
        /// <param name="red">Red component value of this color.</param>
        /// <param name="green">Green component value of this color.</param>
        /// <param name="blue">Blue component value of this color.</param>
        /// <param name="alpha">Alpha component value of this color.</param>
        void SetFromBytes(byte red, byte green, byte blue, byte alpha);

        /// <summary>
        /// Converts the value of this instance to a short hexadecimal string.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string ToShortString();

        /// <summary>
        /// Converts the value of this instance to a hexadecimal string.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string ToString();
    }
}