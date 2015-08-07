﻿//-----------------------------------------------------------------------
// <copyright file="IDataService.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    /// <summary>
    /// Data Service for manipulating data
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// Gets today's data
        /// </summary>
        /// <returns>A string containing today's data</returns>
        string GetTodaysData();
    }
}
