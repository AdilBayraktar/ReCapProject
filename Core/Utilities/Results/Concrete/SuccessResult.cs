﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string massage):base(true,massage)
        {

        }

        public SuccessResult(): base(true)
        {

        }
    }
}
