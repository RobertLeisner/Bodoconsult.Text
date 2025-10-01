// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


namespace Bodoconsult.Latex.Model;

/// <summary>
/// Job for converting a presentation into a LaTex file
/// </summary>
public class PresentationJob
{

    /// <summary>
    /// File path of the source presentation file
    /// </summary>
    public string PresentationFilePath { get; set; }

    /// <summary>
    /// File path of the target LaTex file
    /// </summary>
    public string LaTexFilePath { get; set; }

}