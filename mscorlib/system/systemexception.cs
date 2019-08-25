// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
namespace System {
 
    using System;
    using System.Runtime.Serialization;
    // using Environment = System.Environment2;

    public class SystemException2 : SystemException
    { }

    [Serializable]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class SystemException : Exception
    {
        public SystemException() 
            : base(Environment.GetResourceString("Arg_SystemException")) {
            SetErrorCode(__HResults.COR_E_SYSTEM);
        }
        
        public SystemException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_SYSTEM);
        }
        
        public SystemException(String message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_SYSTEM);
        }

        protected SystemException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
