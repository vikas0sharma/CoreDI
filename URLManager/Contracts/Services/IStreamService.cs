﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IStreamService
    {
        IEnumerable<string> GetNames();
    }
}
