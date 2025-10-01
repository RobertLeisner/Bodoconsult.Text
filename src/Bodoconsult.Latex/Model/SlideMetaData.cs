// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Collections.Generic;
using Bodoconsult.Latex.Enums;
using Bodoconsult.Latex.Interfaces;

namespace Bodoconsult.Latex.Model;

/// <summary>
/// Meta data of a presentation slide
/// </summary>
public class SlideMetaData
{

    /// <summary>
    /// The type of the current slide
    /// </summary>
    public SlideType SlideType { get; set; } = SlideType.Content;


    /// <summary>
    /// The title of the slide
    /// </summary>
    public string Title { get; set; }


    /// <summary>
    /// All paragraphs on the slide (with exception of slide title)
    /// </summary>
    public IList<ILaTexItem> Items { get; } = new List<ILaTexItem>();


}