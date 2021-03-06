/*************************************************************************************
   
   Toolkit for WPF

   Copyright (C) 2007-2018 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at https://xceed.com/xceed-toolkit-plus-for-wpf/

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System;

namespace Xceed.Wpf.AvalonDock.Layout
{
  [Flags]
  public enum AnchorableShowStrategy : byte
  {
    Most = 0x0001,
    Left = 0x0002,
    Right = 0x0004,
    Top = 0x0010,
    Bottom = 0x0020,
  }
}
