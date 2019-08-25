// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class: SerializableAttribute
**
**
** Purpose: Used to mark a class as being serializable
**
**
============================================================*/
namespace System {

    using System;
    using System.Reflection;

    public sealed class SerializableAttribute : Serializable2
    {
        public SerializableAttribute() {
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class Serializable2 : Attribute //  SerializableAttribute : Attribute 
    {
        internal static Attribute GetCustomAttribute(RuntimeType type) 
        { 
            return (type.Attributes & TypeAttributes.Serializable) == TypeAttributes.Serializable ? new SerializableAttribute() : null; 
        }
        internal static bool IsDefined(RuntimeType type) 
        { 
            return type.IsSerializable; 
        }

        public Serializable2() {
        }
    }
}
