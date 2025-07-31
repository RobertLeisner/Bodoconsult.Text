// Copyright (c) Bodoconsult EDV-Dienstleistungen. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Bodoconsult.Text.Documents
{
    /// <summary>
    /// Base class for block document elements
    /// </summary>
    public abstract class Block: TextElement
    {
        /// <summary>
        /// Allowed child block types
        /// </summary>
        protected List<Type> AllowedBlocks = new();

        /// <summary>
        /// All child blocks of the element
        /// </summary>
        protected List<Block> Blocks = new();

        /// <summary>
        /// All child blocks of the element
        /// </summary>
        public List<Block> ChildBlocks => Blocks.ToList();

        /// <summary>
        /// Allowed child inline types
        /// </summary>
        protected List<Type> AllowedInlines = new();

        /// <summary>
        /// All child inlines of the element
        /// </summary>
        protected List<Inline> Inlines = new();

        /// <summary>
        /// All child blocks of the element
        /// </summary>
        public List<Inline> ChildInlines => Inlines.ToList();

        /// <summary>
        /// Name of the style to apply to the block
        /// </summary>
        public string StyleName { get; set; }

        /// <summary>
        /// The name of the tag for the block element
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// Add a block element
        /// </summary>
        /// <param name="block">Block element to add</param>
        public virtual void AddBlock(Block block)
        {
            var type = block.GetType();

            if (!AllowedBlocks.Contains(type))
            {
                throw new ArgumentException($"Type {type.Name} not allowed to add for the current element of type {this.GetType().Name}");
            }

            if (block.IsSingleton && Blocks.Exists(x=> x.GetType() == type))
            {
                throw new ArgumentException($"Type {type.Name} not allowed to add for the current element of type {this.GetType().Name} if there is already an existing one (singleton)");
            }

            Blocks.Add(block);
            block.Parent = this;
        }

        /// <summary>
        /// Add an inline element
        /// </summary>
        /// <param name="inline">Inline element to add</param>
        public virtual void AddInline(Inline inline)
        {
            var type = inline.GetType();

            if (!AllowedInlines.Contains(type))
            {
                throw new ArgumentException($"Type {type.Name} not allowed to add for the current element of type {this.GetType().Name}");
            }

            Inlines.Add(inline);
            inline.Parent = this;
        }

    }
}
