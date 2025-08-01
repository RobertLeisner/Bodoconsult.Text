// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Documents
{

    /// <summary>
    /// Root element for documents
    /// </summary>
    public abstract class TextElement
    {

        /// <summary>
        /// Describing name of the element. This property is not used in the document itself
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Is the element is a singleton element to be added only once to another element. Default false
        /// </summary>
        [DoNotSerialize]
        public bool IsSingleton { get; set; }

        /// <summary>
        /// Parent element
        /// </summary>
        public TextElement Parent { get; set; }

        /// <summary>
        /// Current indenttation for LDML creation
        /// </summary>
        [DoNotSerialize]
        public string Indentation { get; set; } = "    ";

        /// <summary>
        /// Add the current element to a document defined in LDML (Logical document markup language)
        /// </summary>
        /// <param name="document">StringBuilder instance to create the LDML in</param>
        /// <param name="indent">Current indent</param>
        public virtual void ToLdmlString(StringBuilder document, string indent)
        {
            throw new NotSupportedException("Create an override for method ToLdmlString()");
        }

        /// <summary>
        /// Add the opening tag with properties if available
        /// </summary>
        /// <param name="indent">Current indent</param>
        /// <param name="tag">Tag to use</param>
        /// <param name="stringBuilder">Content to add the opening tag</param>
        /// <param name="newLine">Add a new line at the end: Default: true</param>
        public void AddTagWithAttributes(string indent, string tag, StringBuilder stringBuilder, bool newLine = true)
        {
            var sb = GetPropertiesAsAttributes();

            if (sb.Length > 0)
            {
                stringBuilder.Append($"{indent}<{tag}{sb.ToString().TrimEnd()}>");
            }
            else
            {
                stringBuilder.Append($"{indent}<{tag}>");
            }

            if (newLine)
            {
                stringBuilder.Append($"{Environment.NewLine}");
            }
        }

        /// <summary>
        /// Get all properties of an TextElement as XML attributes
        /// </summary>
        /// <returns>XML string with attributes only or empty string</returns>
        public StringBuilder GetPropertiesAsAttributes()
        {
            var pis = DocumentReflectionHelper.GetProperties(GetType());

            var sb = new StringBuilder();

            if (pis.Length == 0)
            {
                return sb;
            }

            sb.Append(' ');
            foreach (var p in pis)
            {
                var value = p.GetValue(this);

                if (value == null)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    sb.Append($"{p.Name}=\"{value}\" ");
                }
            }

            return sb;
        }
    }
}
