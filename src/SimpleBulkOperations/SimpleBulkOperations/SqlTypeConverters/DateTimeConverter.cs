﻿using System;

namespace SimpleBulkOperations.SqlTypeConverters
{
    public class DateTimeConverter : ISqlTypeConvertible
    {
        public bool CanConvert(Type type)
        {
            return type == typeof(DateTime);
        }

        public string Convert(Type type)
        {
            return "datetime";
        }
    }
}
