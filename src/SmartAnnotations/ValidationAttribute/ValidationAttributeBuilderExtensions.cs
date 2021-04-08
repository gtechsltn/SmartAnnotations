﻿using SmartAnnotations.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAnnotations
{
    public static class ValidationAttributeBuilderExtensions
    {
        public static IAnnotationBuilder<TProperty> Message<TProperty, TDescriptor>(
            this IValidationAttributeBuilder<TProperty, TDescriptor> source,
            string message) where TDescriptor : ValidationAttributeDescriptor
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentNullException(nameof(message));

            var attributeDescriptor = source.Descriptor.Get<TDescriptor>();
            _ = attributeDescriptor ?? throw new ArgumentNullException(nameof(ValidationAttributeDescriptor));

            attributeDescriptor.ErrorMessage = message;

            return source;
        }

        public static IAnnotationBuilder<TProperty> Key<TProperty, TDescriptor>(
            this IValidationAttributeBuilder<TProperty, TDescriptor> source,
            string resourceKey) where TDescriptor : ValidationAttributeDescriptor
        {
            if (string.IsNullOrEmpty(resourceKey)) throw new ArgumentNullException(nameof(resourceKey));
            
            var attributeDescriptor = source.Descriptor.Get<TDescriptor>();
            _ = attributeDescriptor ?? throw new ArgumentNullException(nameof(ValidationAttributeDescriptor));

            attributeDescriptor.ErrorMessageResourceName = resourceKey;

            return source;
        }
    }
}
