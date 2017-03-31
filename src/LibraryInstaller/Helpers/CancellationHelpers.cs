﻿using System.Threading;
using System.Threading.Tasks;

namespace LibraryInstaller
{
    internal static class CancellationHelpers
    {
        public static Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
        {
            var src = new TaskCompletionSource<T>();
            cancellationToken.Register(() => src.SetCanceled());
            return Task.WhenAny(task, src.Task).Unwrap();
        }
    }
}