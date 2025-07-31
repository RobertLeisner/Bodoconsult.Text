// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Bodoconsult.Text.Extensions;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Documents
{

    /// <summary>
    /// Reads a LDML file and parses it
    /// </summary>
    public class LdmlReader
    {

        private TextElement _textElement;


        public TextElement TextElement => _textElement;

        /// <summary>
        /// LDML string to parse. Public only for unit testing
        /// </summary>
        public string Ldml;

        /// <summary>
        /// Default ctor. Used together with <see cref="LoadLdmlFile"/> to load a LDML file from disk
        /// </summary>
        public LdmlReader()
        {

        }

        /// <summary>
        /// Ctor loading a LDML string
        /// </summary>
        /// <param name="ldml">LDML string</param>
        public LdmlReader(string ldml)
        {
            Ldml = ldml;
        }

        /// <summary>
        /// Load the LDML string fom a utf-8 text file
        /// </summary>
        /// <param name="filePath">Full path to the LDML file</param>
        public void LoadLdmlFile(string filePath)
        {
            Ldml = File.ReadAllText(filePath);
        }



        public void ParseLdml()
        {
            XDocument xmlDoc = XDocument.Parse(Ldml);

            var root = xmlDoc.Descendants().FirstOrDefault();

            if (root == null)
            {
                return;
            }

            var name = root.Name.ToString();

            _textElement = GetTextElement(name, root);

            var sb = new StringBuilder();
            _textElement.ToLdmlString(sb, string.Empty);

            Debug.Print(sb.ToString());
        }

        private TextElement GetTextElement(string elementName, XElement node)
        {
            var type = Type.GetType($"Bodoconsult.Text.Documents.{elementName}");

            //Debug.Print($"Bodoconsult.Text.Documents.{elementName}");

            if (type == null)
            {
                return null;
            }

            TextElement obj;

            try
            {
                obj = (TextElement)Activator.CreateInstance(type);
            }
            catch //(Exception e)
            {
                return null;
            }

            // Load properties
            LoadProperties(obj, node);

            // Check child nodes
            var childs = node.Nodes().ToList();


            if (obj is Block block)
            {
                foreach (var childNode in childs)
                {
                    if (childNode is XElement element)
                    {

                        Debug.Print($"{elementName}: child {element.Name.ToString()}");


                        var child = GetTextElement(element.Name.ToString(), element);

                        if (child is Block childBlock)
                        {
                            block.AddBlock(childBlock);
                        }

                        if (child is Inline childInline)
                        {
                            block.AddInline(childInline);
                        }
                    }
                    else
                    {
                        Debug.Print(childNode.ToString());
                    }



                }
            }

            if (obj is Inline inline)
            {
                //if (obj is Span)
                //{
                //    Debug.Print("Blubb");
                //}


                foreach (var childNode in childs)
                {

                    if (childNode is XElement element)
                    {
                        var child = GetTextElement(element.Name.ToString(), element);

                        if (child is Inline childInline)
                        {
                            inline.AddInline(childInline);
                        }
                    }

                    else if (childNode is XText text)
                    {
                        if (obj is Span parentInline)
                        {
                            parentInline.Content = text.Value;
                        }
                        Debug.Print(childNode.ToString());
                    }
                }
            }

            return obj;
        }

        private void LoadProperties(TextElement element, XElement node)
        {
            if (!node.HasAttributes)
            {
                return;
            }

            var attributes = node.Attributes().ToList();

            var pis = DocumentReflectionHelper.GetProperties(element.GetType());


            foreach (var prop in pis)
            {
                // Prop Name
                var attr = attributes.FirstOrDefault(x => x.Name == prop.Name);

                if (attr != null)
                {
                    prop.SetValue(element, attr.Value.Convert(prop.PropertyType));
                }
            }
        }
    }
}
