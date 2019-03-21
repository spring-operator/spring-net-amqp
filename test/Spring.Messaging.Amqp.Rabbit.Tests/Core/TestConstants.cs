// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestConstants.cs" company="The original author or authors.">
//   Copyright 2002-2012 the original author or authors.
//   
//   Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
//   the License. You may obtain a copy of the License at
//   
//   https://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
//   an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
//   specific language governing permissions and limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Spring.Messaging.Amqp.Rabbit.Tests.Core
{
    /// <summary>
    /// Test constants. 
    /// </summary>
    /// <author>Mark Pollack</author>
    public static class TestConstants
    {
        /// <summary>
        /// Exchange Name.
        /// </summary>
        public const string EXCHANGE_NAME = "";

        /// <summary>
        /// Queue Name.
        /// </summary>
        public const string QUEUE_NAME = "foo";

        /// <summary>
        /// Routing Key.
        /// </summary>
        public const string ROUTING_KEY = "foo";

        /// <summary>
        /// Number of Messages.
        /// </summary>
        public const int NUM_MESSAGES = 500;
    }
}
