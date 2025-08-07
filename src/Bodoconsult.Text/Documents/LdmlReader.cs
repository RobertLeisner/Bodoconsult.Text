// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private DocumentElement _textElement;

        private readonly Type _popertyElementTpye = typeof(PropertyAsAttributeElement);

        /// <summary>
        /// Read-only access to current <see cref="DocumentElement"/> instance
        /// </summary>
        public DocumentElement TextElement => _textElement;

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


        /// <summary>
        /// Parse the LDML to a <see cref="Document"/> instance
        /// </summary>
        public void ParseLdml()
        {
            var xmlDoc = XDocument.Parse(Ldml);

            var root = xmlDoc.Descendants().FirstOrDefault();

            if (root == null)
            {
                return;
            }

            var name = root.Name.ToString();

            _textElement = GetDocumentElement(name, root, null);

            var sb = new StringBuilder();
            _textElement.ToLdmlString(sb, string.Empty);

            Debug.Print(sb.ToString());
        }

        private DocumentElement GetDocumentElement(string elementName, XElement node, DocumentElement parent)
        {
            var type = Type.GetType($"Bodoconsult.Text.Documents.{elementName}");

            //Debug.Print($"Bodoconsult.Text.Documents.{elementName}");

            if (type == null)
            {
                var pis = DocumentReflectionHelper.GetPropertiesForBlocks(parent.GetType());

                var pi = pis.FirstOrDefault(x => x.Name == elementName);

                if (pi == null)
                {
                    return null;
                }

                GetPropertyAsBlockElement(parent, node, pi);
                return null;
            }


            object obj;

            try
            {
                obj = Activator.CreateInstance(type);
            }
            catch //(Exception e)
            {
                return null;
            }

            if (obj is PropertyAsBlockElement propertyAsBlock)
            {
                LoadProperties(propertyAsBlock, node);
                return propertyAsBlock;
            }

            return obj is not TextElement textElement ? null : GetTextElement(elementName, node, textElement);
        }

        private void GetPropertyAsBlockElement(DocumentElement parent,  XElement node, PropertyInfo pi)
        {
            // Check child nodes
            var childs = node.Nodes().ToList();

            foreach (var childNode in childs)
            {
                if (childNode is XElement element)
                {

                    Debug.Print($"{pi.Name}: child {element.Name}");


                    var child = GetDocumentElement(element.Name.ToString(), element, null);
                    pi.SetValue(parent, child);
                }
                else
                {
                    Debug.Print(childNode.ToString());
                }
            }
        }

        private TextElement GetTextElement(string elementName, XElement node, TextElement textElement)
        {
            // Load properties
            LoadProperties(textElement, node);

            // Check child nodes
            var childs = node.Nodes().ToList();


            if (textElement is Block block)
            {
                foreach (var childNode in childs)
                {
                    if (childNode is XElement element)
                    {

                        Debug.Print($"{elementName}: child {element.Name}");


                        var child = GetDocumentElement(element.Name.ToString(), element, textElement);

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

            if (textElement is Inline inline)
            {
                //if (obj is Span)
                //{
                //    Debug.Print("Blubb");
                //}


                foreach (var childNode in childs)
                {

                    if (childNode is XElement element)
                    {
                        var child = GetDocumentElement(element.Name.ToString(), element, textElement);

                        if (child is Inline childInline)
                        {
                            inline.AddInline(childInline);
                        }


                    }

                    else if (childNode is XText text)
                    {
                        if (TextElement is Span parentInline)
                        {
                            parentInline.Content = text.Value;
                        }
                        Debug.Print(childNode.ToString());
                    }
                }
            }

            return textElement;
        }

        private void LoadProperties(DocumentElement element, XElement node)
        {
            if (!node.HasAttributes)
            {
                return;
            }

            var attributes = node.Attributes().ToList();

            var pis = DocumentReflectionHelper.GetPropertiesForAttributes(element.GetType());


            foreach (var prop in pis)
            {

                var propType = prop.PropertyType;

                var attr = attributes.FirstOrDefault(x => x.Name == prop.Name);

                if (attr == null)
                {
                    continue;
                }

                // Object as property based on PropertyElement
                if (_popertyElementTpye.IsAssignableFrom(propType))
                {
                    var objValue = Activator.CreateInstance(propType, attr.Value);
                    prop.SetValue(element, objValue);
                    continue;
                }



                // Normal property

                //// Prop Name
                //if (prop.PropertyType.IsEnum)
                //{
                //    var value = Enum.Parse(prop.PropertyType, attr.Value);
                //    prop.SetValue(element, value);
                //}
                //else
                //{
                prop.SetValue(element, attr.Value.Convert(prop.PropertyType));
                //}

            }
        }
    }
}
