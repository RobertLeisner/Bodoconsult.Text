﻿// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Text;

namespace Bodoconsult.Test.TestDocumentation
{
    public interface IHtmlCreator
    {
        /// <summary>
        /// Create a partial string with HTML
        /// </summary>
        /// <returns>A string with HTML code</returns>
        StringBuilder ToHtmlString();
    }
}