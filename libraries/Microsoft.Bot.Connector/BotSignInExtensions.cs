// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Microsoft.Bot.Schema;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BotSignIn.
    /// </summary>
    public static partial class BotSignInExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='state'>
            /// </param>
            /// <param name='codeChallenge'>
            /// </param>
            /// <param name='emulatorUrl'>
            /// </param>
            /// <param name='finalRedirect'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetSignInUrlAsync(this IBotSignIn operations, string state, string codeChallenge = default(string), string emulatorUrl = default(string), string finalRedirect = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSignInUrlWithHttpMessagesAsync(state, codeChallenge, emulatorUrl, finalRedirect, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
