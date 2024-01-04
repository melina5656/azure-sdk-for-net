// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The image analysis response. </summary>
    public partial class AnalyzeImageResult
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeImageResult"/>. </summary>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="categoriesAnalysis"/> is null. </exception>
        internal AnalyzeImageResult(IEnumerable<ImageCategoriesAnalysis> categoriesAnalysis)
        {
            Argument.AssertNotNull(categoriesAnalysis, nameof(categoriesAnalysis));

            CategoriesAnalysis = categoriesAnalysis.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageResult"/>. </summary>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        internal AnalyzeImageResult(IReadOnlyList<ImageCategoriesAnalysis> categoriesAnalysis)
        {
            CategoriesAnalysis = categoriesAnalysis;
        }

        /// <summary> Analysis result for categories. </summary>
        public IReadOnlyList<ImageCategoriesAnalysis> CategoriesAnalysis { get; }
    }
}
