/*

This file is part of the iText (R) project.
Copyright (c) 1998-2016 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
namespace iTextSharp.Layout.Property
{
    /// <summary>
    /// An enum of property names that are used for graphical properties of layout
    /// elements.
    /// </summary>
    /// <remarks>
    /// An enum of property names that are used for graphical properties of layout
    /// elements. The
    /// <see cref="iTextSharp.Layout.IPropertyContainer"/>
    /// performs the same function as an
    /// <see cref="System.Collections.IDictionary{K, V}"/>
    /// , with the values of
    /// <see cref="Property"/>
    /// as its potential keys.
    /// </remarks>
    public sealed class Property
    {
        private Property()
        {
        }

        public const int ACTION = 1;

        public const int AREA_BREAK_TYPE = 2;

        public const int AUTO_SCALE = 3;

        public const int AUTO_SCALE_HEIGHT = 4;

        public const int AUTO_SCALE_WIDTH = 5;

        public const int BACKGROUND = 6;

        public const int BASE_DIRECTION = 7;

        public const int BOLD_SIMULATION = 8;

        public const int BORDER = 9;

        public const int BORDER_BOTTOM = 10;

        public const int BORDER_LEFT = 11;

        public const int BORDER_RIGHT = 12;

        public const int BORDER_TOP = 13;

        public const int BOTTOM = 14;

        public const int CHARACTER_SPACING = 15;

        public const int COLSPAN = 16;

        public const int DESTINATION = 17;

        public const int FIRST_LINE_INDENT = 18;

        public const int FLUSH_ON_DRAW = 19;

        public const int FONT = 20;

        public const int FONT_COLOR = 21;

        public const int FONT_KERNING = 22;

        public const int FONT_SCRIPT = 23;

        public const int FONT_SIZE = 24;

        public const int FULL = 25;

        public const int FORCED_PLACEMENT = 26;

        public const int HEIGHT = 27;

        public const int HORIZONTAL_ALIGNMENT = 28;

        /// <summary>Value of 1 is equivalent to no scaling</summary>
        public const int HORIZONTAL_SCALING = 29;

        public const int HYPHENATION = 30;

        public const int ITALIC_SIMULATION = 31;

        public const int KEEP_TOGETHER = 32;

        public const int LEADING = 33;

        public const int LEFT = 34;

        public const int LINE_DRAWER = 35;

        public const int LIST_START = 36;

        public const int LIST_SYMBOL = 37;

        public const int LIST_SYMBOL_ALIGNMENT = 38;

        public const int LIST_SYMBOL_INDENT = 39;

        public const int LIST_SYMBOLS_INITIALIZED = 40;

        public const int LIST_SYMBOL_PRE_TEXT = 41;

        public const int LIST_SYMBOL_POST_TEXT = 42;

        public const int MARGIN_BOTTOM = 43;

        public const int MARGIN_LEFT = 44;

        public const int MARGIN_RIGHT = 45;

        public const int MARGIN_TOP = 46;

        public const int PADDING_BOTTOM = 47;

        public const int PADDING_LEFT = 48;

        public const int PADDING_RIGHT = 49;

        public const int PADDING_TOP = 50;

        public const int PAGE_NUMBER = 51;

        public const int POSITION = 52;

        public const int REVERSED = 53;

        public const int RIGHT = 54;

        public const int ROTATION_ANGLE = 55;

        public const int ROTATION_INITIAL_HEIGHT = 56;

        public const int ROTATION_INITIAL_WIDTH = 57;

        public const int ROTATION_POINT_X = 58;

        public const int ROTATION_POINT_Y = 59;

        public const int ROWSPAN = 60;

        public const int SPACING_RATIO = 61;

        public const int SPLIT_CHARACTERS = 62;

        public const int STROKE_COLOR = 63;

        public const int STROKE_WIDTH = 64;

        public const int SKEW = 65;

        public const int TAB_ANCHOR = 66;

        public const int TAB_DEFAULT = 67;

        public const int TAB_LEADER = 68;

        public const int TAB_STOPS = 69;

        public const int TEXT_ALIGNMENT = 70;

        /// <summary>Use values from .</summary>
        public const int TEXT_RENDERING_MODE = 71;

        public const int TEXT_RISE = 72;

        public const int TOP = 73;

        public const int UNDERLINE = 74;

        /// <summary>Value of 1 is equivalent to no scaling</summary>
        public const int VERTICAL_ALIGNMENT = 75;

        public const int VERTICAL_SCALING = 76;

        public const int WIDTH = 77;

        public const int WORD_SPACING = 78;

        public const int X = 79;

        public const int Y = 80;

        /// <summary>
        /// Some properties must be passed to
        /// <see cref="iTextSharp.Layout.IPropertyContainer"/>
        /// objects that
        /// are lower in the document's hierarchy. Most inherited properties are
        /// related to textual operations. Indicates whether or not this type of property is inheritable.
        /// </summary>
        private static readonly bool[] INHERITED_PROPERTIES;

        private const int MAX_INHERITED_PROPERTY_ID = 80;

        static Property()
        {
            INHERITED_PROPERTIES = new bool[MAX_INHERITED_PROPERTY_ID + 1];
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.BASE_DIRECTION] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.BOLD_SIMULATION] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.CHARACTER_SPACING] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FIRST_LINE_INDENT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FONT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FONT_COLOR] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FONT_KERNING] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FONT_SCRIPT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FONT_SIZE] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.FORCED_PLACEMENT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.HYPHENATION] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.ITALIC_SIMULATION] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.KEEP_TOGETHER] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.LIST_SYMBOL] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.LIST_SYMBOL_PRE_TEXT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.LIST_SYMBOL_POST_TEXT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.SPACING_RATIO] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.SPLIT_CHARACTERS] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.STROKE_COLOR] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.STROKE_WIDTH] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.TEXT_ALIGNMENT] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.TEXT_RENDERING_MODE] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.TEXT_RISE] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.UNDERLINE] = true;
            INHERITED_PROPERTIES[iTextSharp.Layout.Property.Property.WORD_SPACING] = true;
        }

        public static bool IsPropertyInherited(int property)
        {
            return property >= 0 && property < MAX_INHERITED_PROPERTY_ID && INHERITED_PROPERTIES[property];
        }
    }
}