using EntityFrameworkCore.Scaffolding.Handlebars.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// Resolving name service
    /// </summary>
    public class ResolvingNamesService
    {

        #region ctor's
        /// <summary>
        /// Ctor
        /// </summary>
        public ResolvingNamesService()
        {

        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="foreignKey"></param>
        /// <returns></returns>
        public NavEntityPropertyInfo ResolvingName(IEntityType entityType, IForeignKey foreignKey)
        {
            NavEntityPropertyInfo item = new NavEntityPropertyInfo();
            item.FieldName = foreignKey.Properties[0].Name;
            item.ForeginEntityName = foreignKey.PrincipalEntityType.Name;
            item.EntityName = entityType.Name;
            item.PropertyIsNullable = !foreignKey.IsRequired;
            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="navigation"></param>
        /// <returns></returns>
        public NavEntityPropertyInfo ResolvingName(INavigation navigation)
        {
            NavEntityPropertyInfo item = new NavEntityPropertyInfo();
            item.FieldName = navigation.ForeignKey.PrincipalEntityType.Name != navigation.DeclaringEntityType.Name ?
                navigation.ForeignKey.Properties[0].Name : "";
            item.ForeginEntityName =  navigation.ForeignKey.PrincipalEntityType.Name != navigation.DeclaringEntityType.Name ?
                navigation.ForeignKey.PrincipalEntityType.Name : navigation.ForeignKey.DeclaringEntityType.Name;
            item.EntityName = navigation.DeclaringEntityType.Name;
            item.PropertyIsNullable = navigation.ForeignKey.PrincipalEntityType.Name != navigation.DeclaringEntityType.Name ?
                !navigation.ForeignKey.IsRequired : true;
            return item;
        }
}
    }
