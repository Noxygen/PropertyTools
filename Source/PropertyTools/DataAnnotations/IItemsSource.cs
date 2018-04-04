namespace PropertyTools.Wpf
{
    using System.Collections.Generic;

    public interface IItemsSource
    {
        /// <summary>
        /// Returns a list of elements as pairs of Displaymember and Value.
        /// </summary>
        Dictionary<object, object> GetValues();
    }
}
