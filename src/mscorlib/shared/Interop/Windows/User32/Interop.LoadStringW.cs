﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

internal partial class Interop
{
	internal partial class User32
	{
		[DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode)]
		internal static extern int LoadStringW(SafeLibraryHandle handle, int id, [Out] StringBuilder buffer, int bufferLength);
	}
}
