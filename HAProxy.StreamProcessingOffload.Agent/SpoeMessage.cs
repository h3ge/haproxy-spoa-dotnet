//-----------------------------------------------------------------------
// <copyright file="SpoeMessage.cs" company="HAProxy Technologies">
//     The contents of this file are Copyright (c) 2019. HAProxy Technologies. 
//     All rights reserved. This file is subject to the terms and conditions
//     defined in file 'LICENSE', which is part of this source code package.
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace HAProxy.StreamProcessingOffload.Agent
{
    public class SpoeMessage
    {
        /// <summary>
        /// Initializes a new instance of the SpoeMessage class.
        /// HAProxy sends agents streaming data in the form of messages that contain arguments.
        /// </summary>
        /// <param name="name">The name of the message</param>
        public SpoeMessage(string name)
        {
            this.Name = name;
            this.Args = new Dictionary<string, TypedData>();
        }

        /// <summary>
        /// Gets the name of the message.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets a collection of key-value arguments for the message.
        /// </summary>
        public IDictionary<string, TypedData> Args { get; private set; }
    }
}