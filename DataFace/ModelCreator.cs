﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFace {
    public class ModelCreator<T> {
        public T CreateFromScalar(object scalar) {
            return (T)Convert.ChangeType(scalar, typeof(T));
        }

        public object CreateFromRow(Column column, IRow row) {
            throw new NotImplementedException();
        }
    }
}