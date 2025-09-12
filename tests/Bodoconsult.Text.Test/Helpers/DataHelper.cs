// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System.Data;

namespace Bodoconsult.Text.Test.Helpers;

internal class DataHelper
{
    /// <summary>
    /// Get a test <see cref="DataTable"/>
    /// </summary>
    /// <returns></returns>
    public static DataTable GetData()
    {
        var dt = new DataTable();
        dt.Columns.Add("ShareId", typeof(int));
        dt.Columns.Add("ShareName", typeof(string));
        dt.Columns.Add("WKN", typeof(string));
        dt.Columns.Add("ISIN", typeof(string));
        dt.Rows.Add(1, "Testfirma AG", "900900", "DE123456789");
        dt.Rows.Add(2, "Blubb AG", "123456", "AT123456789");
        dt.Rows.Add(3, "Blabb AG", "234567", "GB123456789");
        dt.Rows.Add(4, "Lustig AG", "345678", "DE234567891");
        dt.Rows.Add(5, "Unsinn AG", "456789", "DE345678912");
        return dt;
    }
}