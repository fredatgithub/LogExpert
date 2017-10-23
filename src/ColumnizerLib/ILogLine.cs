﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColumnizerLib
{
    public interface ILogLine : ITextValue
    {
        #region Properties

        string FullLine { get; }

        int LineNumber { get; }

        #endregion
    }
}