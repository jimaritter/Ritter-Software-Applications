#region Using Statements

using System.Collections.Generic;
using System.Text;
using ACH.FileGeneration.RollingGenerator;
using StructureMap;

#endregion

namespace ACH.FileGeneration.Converters
{
    public class RollingConverter
    {
        #region Instance Methods

        public string Render<TMappable, TMap>(IEnumerable<TMappable> renderableList) where TMap : RollingMap<TMappable>
        {
            var map = ObjectFactory.GetInstance<TMap>();

            var sb = new StringBuilder();

            foreach (var mappable in renderableList)
            {
                sb.AppendLine(map.Write(mappable));
            }

            return sb.ToString();
        }

        public string Render<TMappable, TMap>(TMappable singleItem) where TMap : RollingMap<TMappable>
        {
            var map = ObjectFactory.GetInstance<TMap>();
            return map.Write(singleItem);
        }

        #endregion
    }
}