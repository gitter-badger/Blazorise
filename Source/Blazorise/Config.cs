﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Blazorise.Providers;
#endregion

namespace Blazorise
{
    public static class Config
    {
        /// <summary>
        /// Registers a custom class provider.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="classProviderFactory"></param>
        /// <returns></returns>
        public static IServiceCollection AddClassProvider( this IServiceCollection serviceCollection, Func<IStyleProvider> classProviderFactory )
        {
            serviceCollection.AddSingleton( ( p ) => classProviderFactory() );

            return serviceCollection;
        }

        /// <summary>
        /// Registers a custom style provider.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="styleProviderFactory"></param>
        /// <returns></returns>
        public static IServiceCollection AddStyleProvider( this IServiceCollection serviceCollection, Func<IStyleProvider> styleProviderFactory )
        {
            serviceCollection.AddSingleton( ( p ) => styleProviderFactory() );

            return serviceCollection;
        }

        /// <summary>
        /// Registers a predefined icon provider.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="iconProvider"></param>
        public static IServiceCollection AddIconProvider( this IServiceCollection serviceCollection, IconProvider iconProvider )
        {
            if ( iconProvider == IconProvider.FontAwesome )
                serviceCollection.AddSingleton<IIconProvider, FontAwesomeIconProvider>();
            else if ( iconProvider == IconProvider.Material )
                serviceCollection.AddSingleton<IIconProvider, MaterialIconProvider>();
            else
                throw new NotImplementedException( "Icon provider is not supported." );

            return serviceCollection;
        }

        /// <summary>
        /// Registers a custom icon provider.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="iconProviderFactory"></param>
        public static IServiceCollection AddIconProvider( this IServiceCollection serviceCollection, Func<IIconProvider> iconProviderFactory )
        {
            serviceCollection.AddSingleton( ( p ) => iconProviderFactory() );

            return serviceCollection;
        }
    }
}
