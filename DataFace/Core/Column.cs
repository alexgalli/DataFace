﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFace.Core {
    public class Column {
        public string Name { get; set; }

        public Column(string name) {
            this.Name = name;
        }
    }
}
