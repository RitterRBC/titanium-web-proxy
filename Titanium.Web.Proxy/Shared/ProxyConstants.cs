﻿using System.Text;

namespace Titanium.Web.Proxy.Shared
{
    /// <summary>
    /// Literals shared by Proxy Server
    /// </summary>
    internal class ProxyConstants
    {
        internal static readonly char DotSplit = '.';

        internal static readonly char[] SpaceSplit = { ' ' };
        internal static readonly char[] ColonSplit = { ':' };
        internal static readonly char[] SemiColonSplit = { ';' };
        internal static readonly char[] EqualSplit = { '=' };

        internal const string NewLine = "\r\n";
    }
}
