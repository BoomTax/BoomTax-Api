﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BoomTax.Api.SampleProject;
using BoomTax.Api.SampleProject.Models;
using Microsoft.Rest;

namespace BoomTax.Api.SampleProject
{
    public static partial class Form1094COperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the BoomTax.Api.SampleProject.IForm1094COperations.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Form1094C Get(this IForm1094COperations operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IForm1094COperations)s).GetAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the BoomTax.Api.SampleProject.IForm1094COperations.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Form1094C> GetAsync(this IForm1094COperations operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<BoomTax.Api.SampleProject.Models.Form1094C> result = await operations.GetWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the BoomTax.Api.SampleProject.IForm1094COperations.
        /// </param>
        /// <param name='filingId'>
        /// Required.
        /// </param>
        /// <param name='form1094C'>
        /// Required.
        /// </param>
        public static int Post(this IForm1094COperations operations, int filingId, Form1094C form1094C)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IForm1094COperations)s).PostAsync(filingId, form1094C);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the BoomTax.Api.SampleProject.IForm1094COperations.
        /// </param>
        /// <param name='filingId'>
        /// Required.
        /// </param>
        /// <param name='form1094C'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<int> PostAsync(this IForm1094COperations operations, int filingId, Form1094C form1094C, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<int> result = await operations.PostWithOperationResponseAsync(filingId, form1094C, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
