﻿namespace MyTested.Mvc.Builders.Contracts.ActionResults.Forbid
{
    using System;
    using System.Collections.Generic;
    using Authentication;
    using Base;
    using Microsoft.AspNetCore.Http.Authentication;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Used for testing forbid result.
    /// </summary>
    public interface IForbidTestBuilder : IBaseTestBuilderWithActionResult<ForbidResult>
    {
        /// <summary>
        /// Tests whether forbid result contains specific authentication scheme provided by string.
        /// </summary>
        /// <param name="authenticationScheme">Expected authentication scheme as string.</param>
        /// <returns>The same <see cref="IAndForbidTestBuilder"/>.</returns>
        IAndForbidTestBuilder ContainingAuthenticationScheme(string authenticationScheme);

        /// <summary>
        /// Tests whether forbid result has the provided enumerable of authentication schemes.
        /// </summary>
        /// <param name="authenticationSchemes">Expected authentication schemes as enumerable.</param>
        /// <returns>The same <see cref="IAndForbidTestBuilder"/>.</returns>
        IAndForbidTestBuilder ContainingAuthenticationSchemes(IEnumerable<string> authenticationSchemes);

        /// <summary>
        /// Tests whether forbid result has the provided parameters of authentication schemes.
        /// </summary>
        /// <param name="authenticationSchemes">Expected authentication schemes as string parameters.</param>
        /// <returns>The same <see cref="IAndForbidTestBuilder"/>.</returns>
        IAndForbidTestBuilder ContainingAuthenticationSchemes(params string[] authenticationSchemes);

        /// <summary>
        /// Tests whether forbid result has the provided <see cref="AuthenticationProperties"/>.
        /// </summary>
        /// <param name="properties">Expected <see cref="AuthenticationProperties"/>.</param>
        /// <returns>The same <see cref="IAndForbidTestBuilder"/>.</returns>
        IAndForbidTestBuilder WithAuthenticationProperties(AuthenticationProperties properties);

        /// <summary>
        /// Tests whether forbid result has the given <see cref="AuthenticationProperties"/> provided as builder.
        /// </summary>
        /// <param name="authenticationPropertiesBuilder">Expected <see cref="AuthenticationProperties"/> builder.</param>
        /// <returns>The same <see cref="IAndForbidTestBuilder"/>.</returns>
        IAndForbidTestBuilder WithAuthenticationProperties(Action<IAuthenticationPropertiesTestBuilder> authenticationPropertiesBuilder);
    }
}
