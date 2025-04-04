// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;

namespace System.Windows.Controls
{
    /// <summary>
    /// This class is the base class for all exceptions that are
    /// thrown by the PrintDialog and all internal classes.
    /// </summary>
    [Serializable]
    public class PrintDialogException : Exception
    {
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public
        PrintDialogException(
            )
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public
        PrintDialogException(
            string              message
            )
            : base(message)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public
        PrintDialogException(
            string              message,
            Exception           innerException
            )
            : base(message, innerException)
        {
        }
#pragma warning disable SYSLIB0051 // Type or member is obsolete
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected
        PrintDialogException(
            SerializationInfo   info,
            StreamingContext    context
            )
            : base(info, context)
        {
        }
#pragma warning restore SYSLIB0051 // Type or member is obsolete
        #endregion Constructors
    }
}