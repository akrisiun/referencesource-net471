// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Class: InvalidCastException
**
**
** Purpose: Exception class for bad cast conditions!
**
**
=============================================================================*/

namespace System {
    
    using System;
    using System.Runtime.Serialization;
[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class InvalidCastException2 : SystemException2 {
        public InvalidCastException2() 
            : base(Environment2.GetResourceString("Arg_InvalidCastException")) {
            SetErrorCode(__HResults.COR_E_INVALIDCAST);
        }
    
        public InvalidCastException2(string message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_INVALIDCAST);
        }

        public InvalidCastException2(string message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_INVALIDCAST);
        }

        protected InvalidCastException2(SerializationInfo info, StreamingContext context) : base(info, context) {
        }

        public InvalidCastException2(string message, int errorCode) 
            : base(message) {
            SetErrorCode(errorCode);
        }

    }

}
