/*=============================================================================
**
** Class: GeometricException
**
**
** Purpose: Exception class for bad geometric conditions!
**
**
=============================================================================*/
namespace GeometryLib
{
    using System;
    public class GeometricException : Exception
    {
        public GeometricException()
            :base()
        {}
        
        public GeometricException(string message)
            :base(message)
        {}
    }
}