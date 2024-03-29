﻿using NHibernate.Engine;
using NHibernate.Id;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tam.Models
{
    public class GuidStringGenerator : IIdentifierGenerator
    {
        public object Generate(ISessionImplementor session, object obj)
        {
            return new GuidCombGenerator().Generate(session, obj).ToString();
        }

    }
}
