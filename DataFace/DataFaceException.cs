﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFace {
    public class DataFaceException : Exception {
        public DataFaceException(string message) : base(message) {
        }
    }
}
