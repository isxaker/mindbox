using System;
using System.ComponentModel;

namespace ShapeLib.Errors
{
    public static class Verifiers
    {
        public static void ArgVerify(bool b, [param: Localizable(true)] string message, string paramName)
        {
            if (!b)
                throw new ArgumentException(message, paramName);
        }
    }
}