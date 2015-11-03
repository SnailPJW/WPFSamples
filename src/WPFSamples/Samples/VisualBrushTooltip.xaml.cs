﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFSamples.Samples
{
    [Category("Misc")]
    [Description("The Window has a Tooltip which contains a VisualBrush that shows a \"screenshot\" of the Window.")]
    [RelatedUrl("http://stackoverflow.com/questions/15552797/what-is-the-equivalent-way-to-use-bitmap-graphics-picturebox-bitmapcopy-in-w", "What is the equivalent way to use Bitmap,Graphics,PictureBox & BitmapCopy() in WPF?")]
    public partial class VisualBrushTooltip : SampleWindow
    {
        public VisualBrushTooltip()
        {
            InitializeComponent();
        }

    }
}
