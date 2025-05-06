using System;
using System.Collections;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace DisableMouseWheelZoom2022
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal class TextViewScrollDisabler : IWpfTextViewCreationListener
    {
        public void TextViewCreated(IWpfTextView textView)
        {
            textView.Options.SetOptionValue(DefaultWpfViewOptions.EnableMouseWheelZoomId, false);
        }
    }
}