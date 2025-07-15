// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


namespace Bodoconsult.Test.TestDocumentation
{
    /// <summary>
    /// The priority of a test as importance for the whole
    /// </summary>
    public enum TestPriority
    {
        Normal = 1,
        Low = 0,
        High = 2,
        Ignore = -1,
        IgnoreIfError = -2
    }
}