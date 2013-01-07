#region Using Statements

#endregion

#region Using Statements

using System.Collections.Generic;
using System.Text;
using ACH.FileGeneration.FixedLengthGenerator;
using StructureMap;

#endregion

namespace ACH.FileGeneration.Converters
{
    public class FixedLengthConverter
    {
        #region Instance Methods

        public string Render<TMappable, TMap>(IEnumerable<TMappable> renderableList) where TMap : FixedLengthMap<TMappable>
        {
            var map = ObjectFactory.GetInstance<TMap>();

            var sb = new StringBuilder();

            foreach (var mappable in renderableList)
            {
                sb.AppendLine(map.Write(mappable));
            }

            return sb.ToString();
        }

        public string Render<TMappable, TMap>(TMappable singleItem) where TMap : FixedLengthMap<TMappable>
        {
            var map = ObjectFactory.GetInstance<TMap>();
            return map.Write(singleItem);
        }

        #endregion
    }
}