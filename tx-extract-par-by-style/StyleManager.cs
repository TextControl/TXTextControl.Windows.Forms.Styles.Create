using System;
using System.Diagnostics;
using System.Linq;
using TXTextControl;

// **************************************************************
// *                                                            *
// *  This example demonstrates how to extract styles from      *
// *  paragraphs and how to apply them to other paragraphs.     *
// *                                                            *
// **************************************************************

public class StyleManager
{
	// The TextControl instance to work with
	private TextControl _textControl;
	// A list of properties to compare
	private string[] _positiveListParagraphFormat = { "Alignment", "ForeColor", "BottomDistance", "TopDistance", "LeftIndent", "RightIndent" };
	private string[] _positiveListCharacterFormat = { "Bold", "Italic", "FontName", "FontSize", "ForeColor", "Strikeout", "Underline" };

	// A counter to create unique style names
	private int styleNameCounter;

	public string[] PositiveListParagraphFormat { get => _positiveListParagraphFormat; set => _positiveListParagraphFormat = value; }
	public string[] PositiveListCharacterFormat { get => _positiveListCharacterFormat; set => _positiveListCharacterFormat = value; }

	// The constructor requires a TextControl instance
	public StyleManager(TextControl control)
	{
		_textControl = control;
		styleNameCounter = 1;
	}

	// This method applies the styles to all paragraphs
	public void ApplyStyles()
	{
		foreach (Paragraph paragraph in _textControl.Paragraphs)
		{
			if (IsCommonFormatting(paragraph))
			{
				var style = FindOrCreateStyle(paragraph);
				paragraph.FormattingStyle = style.Name;
			}
		}
	}

	// This method creates a new style or returns an existing one
	private ParagraphStyle FindOrCreateStyle(Paragraph paragraph)
	{
		var existingStyle = FindStyle(paragraph);
		if (existingStyle == null)
		{
			existingStyle = CreateStyle(paragraph);
		}
		return existingStyle;
	}

	// This method searches for an existing style
	private ParagraphStyle FindStyle(Paragraph paragraph)
	{
		foreach (ParagraphStyle paragraphStyle in _textControl.ParagraphStyles)
		{
			// compare paragraph format
			if (IsParagraphFormatEqual(paragraph.Format, paragraphStyle.ParagraphFormat))
			{
				// compare character format
				if (IsCharacterFormatEqual(paragraph, paragraphStyle))
				{
					return paragraphStyle;
				}
			}
		}

		return null;
	}

	// This method creates a new style
	private ParagraphStyle CreateStyle(Paragraph paragraph)
	{
		ParagraphStyle paragraphStyle = new ParagraphStyle("Style" + styleNameCounter, "[Normal]");

		CopyCharacterFormat(paragraph, paragraphStyle);
		CopyParagraphFormat(paragraph.Format, paragraphStyle.ParagraphFormat);

		// add the style to the collection
		_textControl.ParagraphStyles.Add(paragraphStyle);
		styleNameCounter++; // increase the counter
		return paragraphStyle; // return the new style
	}

	// This method compares the character format of a paragraph with a style using Reflection
	private bool IsCharacterFormatEqual(Paragraph paragraph, ParagraphStyle paragraphStyle)
	{
		paragraph.Select();
		var selection = _textControl.Selection;

		foreach (var property in typeof(Selection).GetProperties())
		{
			if (!_positiveListCharacterFormat.Contains(property.Name))
			{
				continue;
			}

			object value1 = property.GetValue(selection);
			var paragraphStyleProperty = typeof(ParagraphStyle).GetProperty(property.Name)?.GetValue(paragraphStyle);

			// compare the values
			if (!object.Equals(value1, paragraphStyleProperty))
			{
				return false;
			}
		}

		return true;
	}

	// This method compares the paragraph format of a paragraph with a style using Reflection
	private bool IsParagraphFormatEqual(ParagraphFormat format1, ParagraphFormat format2)
	{
		foreach (var property in typeof(ParagraphFormat).GetProperties())
		{
			if (_positiveListParagraphFormat.Contains(property.Name))
			{
				object value1 = property.GetValue(format1);
				object value2 = property.GetValue(format2);

				if (!object.Equals(value1, value2))
				{
					return false;
				}
			}
		}

		return true;
	}

	// This method copies the character format of a paragraph to a style using Reflection
	private void CopyCharacterFormat(Paragraph paragraph, ParagraphStyle style)
	{
		paragraph.Select();
		var selection = _textControl.Selection;
		var styleType = style.GetType();

		foreach (var property in styleType.GetProperties())
		{
			var selectionProperty = typeof(Selection).GetProperty(property.Name);

			if (selectionProperty != null && selectionProperty.PropertyType == property.PropertyType)
			{
				property.SetValue(style, selectionProperty.GetValue(selection));
			}
		}
	}

	// This method copies the paragraph format of a paragraph to a style using Reflection
	private void CopyParagraphFormat(ParagraphFormat source, ParagraphFormat destination)
	{
		foreach (var property in typeof(ParagraphFormat).GetProperties())
		{
			object value = property.GetValue(source);
			if (value != null && _positiveListParagraphFormat.Contains(property.Name))
			{
				property.SetValue(destination, value);
			}
		}
	}

	// This method checks if the paragraph has common formatting
	private bool IsCommonFormatting(Paragraph paragraph)
	{
		paragraph.Select();
		return _textControl.Selection.IsCommonValueSelected(Selection.Attribute.All);
	}

}
