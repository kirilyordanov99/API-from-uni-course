﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TextFileStatistcsWebApiClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;

    /// <summary>
    /// Extension methods for Methods.
    /// </summary>
    public static partial class MethodsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceStr'>
            /// </param>
            public static string WrapLines(this IMethods operations, string sourceStr)
            {
                return Task.Factory.StartNew(s => ((IMethods)s).WrapLinesAsync(sourceStr), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceStr'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> WrapLinesAsync(this IMethods operations, string sourceStr, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.WrapLinesWithHttpMessagesAsync(sourceStr, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='html'>
            /// </param>
            public static string GetTextFromHtml(this IMethods operations, string html)
            {
                return Task.Factory.StartNew(s => ((IMethods)s).GetTextFromHtmlAsync(html), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='html'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetTextFromHtmlAsync(this IMethods operations, string html, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTextFromHtmlWithHttpMessagesAsync(html, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
