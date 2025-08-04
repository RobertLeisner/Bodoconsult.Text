// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

/*
 *
 *
 * System.Windows.Media is part of the WPF environment by Microsoft.

 * System.Windows.Media is released as open source under the MIT license

 * License-Url: https://github.com/dotnet/wpf/blob/main/LICENSE.TXT

 * Project-Url: https://github.com/dotnet/wpf

 * The MIT License (MIT)

 * Copyright (c) .NET Foundation and Contributors

 * All rights reserved.

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System.Text;
using Bodoconsult.Text.Extensions;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Color defined in ARGB mode
/// </summary>
public class Color: DocumentElement
{
    /// <summary>
    /// A
    /// </summary>
    public byte A { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public byte R { get; set; }

    /// <summary>
    /// G
    /// </summary>
    public byte G { get; set; }

    /// <summary>
    /// B
    /// </summary>
    public byte B { get; set; }

    ///<summary>
    /// Color - sRgb legacy interface, assumes Rgb values are sRgb
    /// Source: System.Windows.Media by Microsoft
    ///</summary>
    public static Color FromUInt32(uint argb)// internal legacy sRGB interface
    {
        var c1 = new Color
        {
            A = (byte)((argb & 0xff000000) >> 24),
            R = (byte)((argb & 0x00ff0000) >> 16),
            G = (byte)((argb & 0x0000ff00) >> 8),
            B = (byte)(argb & 0x000000ff)
        };
        return c1;
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.Append(this.ToHtml());
    }
}