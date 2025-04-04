// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
// 
// Description: Manage Input Method.
//
//

namespace System.Windows.Input
{
    //------------------------------------------------------
    //
    //  InputMethodStateChjangedEventArgs class
    //
    //------------------------------------------------------

    /// <summary>
    /// This InputMethodStateChangedEventArgs class is 
    /// </summary>
    public class InputMethodStateChangedEventArgs : EventArgs
    {
        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------
 
        internal InputMethodStateChangedEventArgs(InputMethodStateType statetype)
        {
            _statetype = statetype;
        }

        //------------------------------------------------------
        //
        //  Public Properties
        //
        //------------------------------------------------------
 
        /// <summary>
        /// IME (open/close) state is changed.
        /// </summary>
        public bool IsImeStateChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.ImeState); 
            }
        }

        /// <summary>
        /// Microphone state is changed.
        /// </summary>
        public bool IsMicrophoneStateChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.MicrophoneState); 
            }
        }

        /// <summary>
        /// Handwriting state is changed.
        /// </summary>
        public bool IsHandwritingStateChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.HandwritingState); 
            }
        }

        /// <summary>
        /// SpeechMode state is changed.
        /// </summary>
        public bool IsSpeechModeChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.SpeechMode); 
            }
        }

        /// <summary>
        /// ImeConversionMode state is changed.
        /// </summary>
        public bool IsImeConversionModeChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.ImeConversionModeValues); 
            }
        }

        /// <summary>
        /// ImeSentenceMode state is changed.
        /// </summary>
        public bool IsImeSentenceModeChanged
        {
            get  
            { 
                return (_statetype == InputMethodStateType.ImeSentenceModeValues); 
            }
        }

        //------------------------------------------------------
        //
        //  Private Fields
        //
        //------------------------------------------------------
                
        #region Private Fields

        private InputMethodStateType _statetype;

        #endregion Private Fields
    }
}
