// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Compute Management API includes operations for managing the load
    /// balancers for your subscription.
    /// </summary>
    public partial interface ILoadBalancerOperations
    {
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginCreatingAsync(string serviceName, string deploymentName, LoadBalancerCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the load balancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginDeletingAsync(string serviceName, string deploymentName, string loadBalancerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginUpdatingAsync(string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> CreateAsync(string serviceName, string deploymentName, LoadBalancerCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the load balancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string serviceName, string deploymentName, string loadBalancerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> UpdateAsync(string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
