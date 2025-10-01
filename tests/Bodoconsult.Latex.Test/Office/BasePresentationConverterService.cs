// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Interfaces;
using Bodoconsult.Latex.Model;

namespace Bodoconsult.Latex.Test.Office;

public abstract class BasePresentationConverterService
{

    /// <summary>
    /// Current presentation job
    /// </summary>
    public PresentationJob Job { get; set; }



    public IPresentationConverterService Service { get; set; }

}