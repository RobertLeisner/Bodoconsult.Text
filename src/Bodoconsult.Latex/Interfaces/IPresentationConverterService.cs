// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Model;

namespace Bodoconsult.Latex.Interfaces;

/// <summary>
/// Interface for presentation to LaTex converter services
/// </summary>
public interface IPresentationConverterService
{

    /// <summary>
    /// Current presentation job
    /// </summary>
    PresentationJob PresentationJob { get; }


    /// <summary>
    /// Convert the presentation to LaTex
    /// </summary>
    void ConvertPresentation();

}