// Copyright (c) Bodoconsult EDV-Dienstleistungen. All rights reserved.

using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using System.Runtime.Versioning;

namespace Bodoconsult.Pdf.PdfSharp
{
    [SupportedOSPlatform("windows")]
    public class WindowsFontResolver : IFontResolver
    {

        public readonly Dictionary<string, string> InstalledFonts = new();

        /// <summary>
        /// Default ctor
        /// </summary>
        public WindowsFontResolver()
        {
            var localMachineKey = Registry.LocalMachine;
            var localMachineKeySub = localMachineKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", false);

            if (localMachineKeySub == null)
            {
                localMachineKey.Close();
                return;
            }

            var mynames = localMachineKeySub.GetValueNames();

            foreach (var name in mynames)
            {
                var value = localMachineKeySub.GetValue(name);

                if (value == null)
                {
                    continue;
                }

                var myvalue = value.ToString() ?? "";

                if (string.IsNullOrEmpty(myvalue) || myvalue.Length < 5)
                {
                    continue;
                }


                if (myvalue[^4..].ToUpper() != ".TTF" ||
                    myvalue.Substring(1, 2).ToUpper() == @":")
                {
                    continue;
                }

                var val = name[..^11].ToUpperInvariant();
                InstalledFonts[val] = myvalue;
            }

            localMachineKey.Close();
            localMachineKeySub.Close();

        }

        public FontResolverInfo ResolveTypeface(string familyName, bool bold, bool italic)
        {
            // Ignore case of font names.
            var name = familyName.ToUpperInvariant();

            var fonts = InstalledFonts.Keys.Where(x => x.StartsWith(name));


            if (!fonts.Any())
            {
                return new FontResolverInfo("ARIAL");
            }


            string fontName = null;
            bool success;
            string key;

            if (bold)
            {
                if (italic)
                {
                    key = $"{name} BOLD ITALIC";
                    success = InstalledFonts.TryGetValue(key, out fontName);
                    if (success)
                    {
                        return new FontResolverInfo(key);
                    }
                }
                else
                {
                    key = $"{name} BOLD";
                    success = InstalledFonts.TryGetValue(key, out fontName);
                    if (success)
                    {
                        return new FontResolverInfo(key);
                    }
                }
            }

            if (italic)
            {
                key = $"{name} ITALIC";
                success = InstalledFonts.TryGetValue(key, out fontName);
                if (success)
                {
                    return new FontResolverInfo(key);
                }
            }

            key = $"{name}";
            success = InstalledFonts.TryGetValue(key, out fontName);
            return success ? new FontResolverInfo(key) : new FontResolverInfo("ARIAL");
        }

        public byte[] GetFont(string faceName)
        {
            var fName = faceName.ToUpperInvariant();

            if (!InstalledFonts.ContainsKey(fName))
            {
                throw new ArgumentException($"Font {faceName} not installed");
            }

            var font = InstalledFonts[fName];

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), font);

            var data = File.ReadAllBytes(fileName);

            return data;
        }
    }
}
