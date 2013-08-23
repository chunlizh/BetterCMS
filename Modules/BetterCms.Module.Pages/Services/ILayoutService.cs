﻿using System.Collections.Generic;

using BetterCms.Module.Pages.ViewModels.Page;
using BetterCms.Module.Root.ViewModels.Option;

namespace BetterCms.Module.Pages.Services
{
    public interface ILayoutService
    {
        /// <summary>
        /// Gets the list of layout view models.
        /// </summary>
        /// <returns>The list of layout view models</returns>
        IList<TemplateViewModel> GetLayouts();

        /// <summary>
        /// Gets the list of layout option view models.
        /// </summary>
        /// <param name="id">The layout id.</param>
        /// <returns>
        /// The list of layout option view models
        /// </returns>
        IList<OptionViewModel> GetLayoutOptions(System.Guid id);

        /// <summary>
        /// Gets the list of layout option values.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>
        /// The list of layout option values.
        /// </returns>
        IList<OptionValueEditViewModel> GetLayoutOptionValues(System.Guid id);
    }
}