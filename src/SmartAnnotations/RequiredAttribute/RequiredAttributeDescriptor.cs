﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAnnotations
{
    public class RequiredAttributeDescriptor : ValidationAttributeDescriptor
    {
        internal RequiredAttributeDescriptor(Type? resourceType = null, Type? modelResourceType = null)
            : base(resourceType, modelResourceType)
        {
        }

        internal bool? AllowEmptyStrings { get; set; }
    }
}
