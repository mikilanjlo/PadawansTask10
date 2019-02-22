using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            //Type[] types = new Type[] { Boolean, Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double, Decimal, Char };
            //foreach (Type type in types)
            //    if (variable is type)
            //        throw new ArgumentException();
            if (variable == null)
                return true;
            return false;
        }
    }
}
