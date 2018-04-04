namespace PropertyTools.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using Wpf;

    /// <summary>
    /// Specifies an <see cref="IItemsSource" /> type that returns values for the attributed property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ItemsSourceProviderAttribute : Attribute
    {
        private readonly Dictionary<object, object> _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsSourceProviderAttribute" /> class.
        /// </summary>
        /// <param name="itemsSourceClass">A class that inherits from <see cref="IItemsSource" />.</param>
        public ItemsSourceProviderAttribute(Type itemsSourceClass)
        {
            var instance = Activator.CreateInstance(itemsSourceClass) as IItemsSource;
            if (instance == null) throw new ArgumentException($"ItemsSourceProvider must be of {nameof(IItemsSource)} type.");

            _values = instance.GetValues();
        }

        public Dictionary<object, object> GetValues()
        {
            return _values;
        }
    }
}
