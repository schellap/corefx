// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace System.Security.Cryptography.X509Certificates
{
    public struct X509ChainStatus
    {
        public X509ChainStatusFlags Status { get; set; }

        public string StatusInformation
        {
            get
            {
                if (_statusInformation == null)
                    return string.Empty;
                return _statusInformation;
            }
            set
            {
                _statusInformation = value;
            }
        }

        private string _statusInformation;
    }
}

