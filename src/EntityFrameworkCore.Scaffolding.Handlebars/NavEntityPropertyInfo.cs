using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// 
    /// </summary>
    public class NavEntityPropertyInfo : EntityPropertyInfo
    {

        #region ctor's
        /// Constructor.
        /// </summary>
        public NavEntityPropertyInfo() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fieldName">field name (with ID).</param>
        /// <param name="foreginEntityName">Related table name.</param>
        /// <param name="entityName">Property type.</param>
        /// <param name="propertyType">Property type.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="propertyIsNullable">Property is nullable.</param>
        public NavEntityPropertyInfo(string fieldName, string foreginEntityName, string entityName, string propertyType, string propertyName, bool propertyIsNullable = false)
            :base(entityName, propertyType, propertyName, propertyIsNullable)
        {
            FieldName = fieldName;
            ForeginEntityName = foreginEntityName;
        }


        #endregion

        #region Properties
          /// <summary>
        /// 
        /// </summary>
        public string ForeginEntityName{get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string FieldName{get;set;}
        #endregion
    }
}
