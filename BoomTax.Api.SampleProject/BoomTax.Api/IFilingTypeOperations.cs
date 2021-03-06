﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BoomTax.Api.SampleProject.Models;
using Microsoft.Rest;

namespace BoomTax.Api.SampleProject
{
    public partial interface IFilingTypeOperations
    {
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<FilingType>>> GetFilingTypesWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
