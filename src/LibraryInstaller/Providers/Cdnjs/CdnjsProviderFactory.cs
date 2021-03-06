﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Web.LibraryInstaller.Contracts;

#if NET45
using System.ComponentModel.Composition;
#endif

namespace Microsoft.Web.LibraryInstaller.Providers.Cdnjs
{
    /// <summary>Internal use only</summary>
#if NET45
    [Export(typeof(IProviderFactory))]
#endif
    public class CdnjsProviderFactory : IProviderFactory
    {
        /// <summary>
        /// Creates an <see cref="T:Microsoft.Web.LibraryInstaller.Contracts.IProvider" /> instance.
        /// </summary>
        /// <param name="hostInteraction">The <see cref="T:Microsoft.Web.LibraryInstaller.Contracts.IHostInteraction" /> provided by the host to handle file system writes etc.</param>
        /// <returns>
        /// A <see cref="T:Microsoft.Web.LibraryInstaller.Contracts.IProvider" /> instance.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">hostInteraction</exception>
        public IProvider CreateProvider(IHostInteraction hostInteraction)
        {
            if (hostInteraction == null)
            {
                throw new ArgumentNullException(nameof(hostInteraction));
            }

            return new CdnjsProvider(hostInteraction);
        }
    }
}
