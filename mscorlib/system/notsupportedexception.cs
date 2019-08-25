// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Class: NotSupportedException
**
**
** Purpose: For methods that should be implemented on subclasses.
**
**
=============================================================================*/

namespace System {
    
    using System;
    using System.Runtime.Serialization;
[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class NotSupportedException2 : SystemException2
    {
        public NotSupportedException2() 
            : base(Environment2.GetResourceString("Arg_NotSupportedException")) {
            SetErrorCode(__HResults.COR_E_NOTSUPPORTED);
        }
    
        public NotSupportedException(string message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_NOTSUPPORTED);
        }
        
        public NotSupportedException2(string message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_NOTSUPPORTED);
        }

        protected NotSupportedException2(SerializationInfo info, StreamingContext context) : base(info, context) {
        }

    }
}
