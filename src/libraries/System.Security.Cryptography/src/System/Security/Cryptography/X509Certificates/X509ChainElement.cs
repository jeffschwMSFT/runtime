// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Internal.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public class X509ChainElement
    {
        internal X509ChainElement(X509Certificate2 certificate, X509ChainStatus[] chainElementStatus, string information)
        {
            Certificate = certificate;
            ChainElementStatus = chainElementStatus;
            Information = information;
        }

        public X509Certificate2 Certificate { get; }

        // For compat purposes, ChainElementStatus does *not* give each caller a private copy of the array.
        public X509ChainStatus[] ChainElementStatus { get; }

        public string Information { get; }
    }
}
