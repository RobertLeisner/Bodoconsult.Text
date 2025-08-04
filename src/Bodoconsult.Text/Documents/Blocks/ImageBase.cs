// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Base class for image blocks
/// </summary>
public abstract class ImageBase: ParagraphBase
{

    /// <summary>
    /// URL of the image. Local file path, UNC path or a web link
    /// </summary>
    public string Uri { get; set; }

}