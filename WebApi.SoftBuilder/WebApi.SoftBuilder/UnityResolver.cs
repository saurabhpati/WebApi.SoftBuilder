using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace WebApi.SoftBuilder
{
    #region Documentation

    /*
     * Need for Dependency Resolver:
     * 
     * The application doesn't create the controller directly. Web API creates the controller when it routes the request, and Web API 
     * doesn't know anything about the dependencies of the controller.This is where the Web API dependency resolver comes in.
     * 
     * The IDependencyScope interface has two methods:
     *      GetService creates one instance of a type.
     *      GetServices creates a collection of objects of a specified type.
     *      
     * The IDependencyResolver method inherits IDependencyScope and adds the BeginScope method.
     * 
     * GetService(s) Contract:
     * 
     * When Web API creates a controller instance, it first calls IDependencyResolver.GetService, passing in the controller type. 
     * We can use this extensibility hook to create the controller, resolving any dependencies. 
     * If GetService returns null, Web API looks for a parameterless constructor on the controller class.
     * 
     * Note: 
     * 
     * 1. If the GetService method cannot resolve a type, it should return null. 
     * 2. If the GetServices method cannot resolve a type, it should return an empty collection object. 
     * 3. Don't throw exceptions for unknown types.
     */

    #endregion

    /// <summary>
    /// Implementation of IDependencyResolver for resolving dependencies for Web Apis.
    /// </summary>
    public class UnityResolver : IDependencyResolver
    {
        #region Properties

        /// <summary>
        /// Gets the unity container object and is set in UnityResolver class privately.
        /// </summary>
        protected IUnityContainer container { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize the UnityResolver class
        /// </summary>
        /// <param name="container">The unity container containing all registrations</param>
        public UnityResolver(IUnityContainer container)
        {
            this.container = container ?? throw new ArgumentNullException(nameof(container));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the scope of the dependencies to be resolved.
        /// </summary>
        /// <returns>IDependency Scope.</returns>
        public IDependencyScope BeginScope()
        {
            IUnityContainer child = this.container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <summary>
        /// Implementation to place the container object in the GC collection queue to dispose the container object.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Gets the controller instance initialized through the implementations of IOC container in the application
        /// </summary>
        /// <param name="serviceType">The type of service to be resolved</param>
        /// <returns>Resolved and initialized service.</returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the collection of instances initialized through the implementations of IOC container in the application.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns>Resolved and initialized service enumerables.</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Places the container object in the GC queue to be collected for garbage collection.
        /// </summary>
        /// <param name="disposing">Whether dispose is being processed</param>
        protected virtual void Dispose(bool disposing)
        {
            container.Dispose();
        }

        #endregion
    }
}