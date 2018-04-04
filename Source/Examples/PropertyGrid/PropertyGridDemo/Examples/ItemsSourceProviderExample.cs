using System;
using System.Collections.Generic;
using ExampleLibrary;
using PropertyTools.DataAnnotations;
using PropertyTools.Wpf;

namespace PropertyGridDemo
{
    [PropertyGridExample]
    public class ItemsSourceProviderExample : Example
    {
        [ItemsSourceProvider(typeof(TestItemsSource))]
        public string SelectedItem { get; set; }


        public class TestItemsSource : IItemsSource
        {
            public Dictionary<object, object> GetValues()
            {
                return new Dictionary<object, object>
                {
                    { "Key 1", 1 },
                    { "Key 2", 2 },
                    { 3, "Value 3" },
                    { 4, "Value 4" },
                    { 5, "Value 5" },
                };
            }
        }
    }
}
