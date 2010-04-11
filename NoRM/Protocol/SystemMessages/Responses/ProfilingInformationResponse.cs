﻿using System;

namespace Norm.Responses
{
    /// <summary>
    /// The profiling information response.
    /// </summary>
    public class ProfilingInformationResponse
    {
        /// <summary>TODO::Description.</summary>
        /// <value></value>
        public DateTime? Ts { get; private set; }

        /// <summary>TODO::Description.</summary>
        /// <value></value>
        public string Info { get; private set; }

        /// <summary>TODO::Description.</summary>
        /// <value></value>
        public double? Millis { get; private set; }
    }
}