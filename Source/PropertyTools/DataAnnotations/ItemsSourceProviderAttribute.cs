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
        private readonly Type _itemsSourceClass;

        public bool SwapKeyAndValue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsSourceProviderAttribute" /> class.
        /// </summary>
        /// <param name="itemsSourceClass">A class that inherits from <see cref="IItemsSource" />.</param>
        /// <param name="swapKeyAndValue">Treat items as Value:Key instead of Key:Value.</param>
        public ItemsSourceProviderAttribute(Type itemsSourceClass, bool swapKeyAndValue = false)
        {
            _itemsSourceClass = itemsSourceClass;
            SwapKeyAndValue = swapKeyAndValue;
        }
        
        public Dictionary<object, object> GetValues() => (Activator.CreateInstance(_itemsSourceClass) as IItemsSource)?.GetValues();
    }
}
