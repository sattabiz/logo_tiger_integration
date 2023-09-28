﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.Core
{
    public class BaseClass
    {
        public void TryCatchKullan(Action _action)
        {
            try
            {
                _action();
            }
            catch (Exception ex)
            {
                // Loglama işlemleri burada olsun .
            }
        }
    }
}
