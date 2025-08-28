// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Heading base class
/// </summary>
public class HeadingBase : ParagraphBase
{
    /// <summary>
    /// The current prefix calculated by TOC calculation
    /// </summary>
    public string CurrentPrefix { get; set; }

}