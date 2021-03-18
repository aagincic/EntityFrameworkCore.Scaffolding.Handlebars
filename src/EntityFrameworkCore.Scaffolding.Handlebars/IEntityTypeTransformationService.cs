using System.Collections.Generic;

namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// Service for transforming entity type definitions.
    /// </summary>
    public interface IEntityTypeTransformationService
    {
        /// <summary>
        /// Transform entity type name.
        /// </summary>
        /// <param name="entityName">Entity type name.</param>
        /// <returns>Transformed entity type name.</returns>
        string TransformTypeEntityName(string entityName);

        /// <summary>
        /// Transform entity file name.
        /// </summary>
        /// <param name="entityFileName">Entity file name.</param>
        /// <returns>Transformed entity file name.</returns>
        string TransformEntityFileName(string entityFileName);

        /// <summary>
        /// Transform single property name.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        /// <param name="propertyType">Property type</param>
        /// <returns>Transformed property name.</returns>
        string TransformPropertyName(string propertyName, string propertyType);

        /// <summary>
        /// Transform single navigation property name.
        /// </summary>
        /// <param name="fieldName">Database field name.</param>
        /// <param name="foreginEntityName">Foregin entity / or table name.</param>
        /// <param name="entityName">Current entity / table name.</dparam>
        /// <param name="propertyType">Property type.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="propertyIsNullable">Is property nullable.</param>
        /// <returns>Transformed property name.</returns>
        string TransformNavPropertyName(string fieldName, string foreginEntityName, string entityName, string propertyType, string propertyName, bool propertyIsNullable = false);

        /// <summary>
        /// Transform entity type constructor.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="lines">Constructor lines.</param>
        /// <returns>Transformed constructor lines.</returns>
        List<Dictionary<string, object>> TransformConstructor(string entityName, List<Dictionary<string, object>> lines);

        /// <summary>
        /// Transform entity type properties.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="properties">Entity type properties.</param>
        /// <returns>Transformed entity type properties.</returns>
        List<Dictionary<string, object>> TransformProperties(string entityName, List<Dictionary<string, object>> properties);

        /// <summary>
        /// Transform entity type navigation properties.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="navProperties">Entity type navigation properties.</param>
        /// <returns>Transformed entity type navigation properties.</returns>
        List<Dictionary<string, object>> TransformNavigationProperties(string entityName, List<Dictionary<string, object>> navProperties);
    }
}