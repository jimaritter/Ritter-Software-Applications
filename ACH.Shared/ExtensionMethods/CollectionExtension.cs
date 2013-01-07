#region Using Statements

using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

#endregion

namespace ACH.Shared.ExtensionMethods
{
    public static class CollectionExtension
    {
        #region Class Methods

        /// <summary>
        /// Adds the selected enum list items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="listItemCollection">The list item collection.</param>
        public static void AddSelectedEnumListItems<T>(this ICollection<T> collection, ListItemCollection listItemCollection)
        {
            listItemCollection.Cast<ListItem>().Where(item => item.Selected).ForEach(item => collection.Add(EnumerationParser.Parse<T>(item.Value)));
        }

        #endregion
    }
}