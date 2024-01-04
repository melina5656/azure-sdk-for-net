// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Column definition. </summary>
    public partial class DataTableResponseColumn
    {
        /// <summary> Initializes a new instance of <see cref="DataTableResponseColumn"/>. </summary>
        public DataTableResponseColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataTableResponseColumn"/>. </summary>
        /// <param name="columnName"> Name of the column. </param>
        /// <param name="dataType"> Data type which looks like 'String' or 'Int32'. </param>
        /// <param name="columnType"> Column Type. </param>
        internal DataTableResponseColumn(string columnName, string dataType, string columnType)
        {
            ColumnName = columnName;
            DataType = dataType;
            ColumnType = columnType;
        }

        /// <summary> Name of the column. </summary>
        public string ColumnName { get; set; }
        /// <summary> Data type which looks like 'String' or 'Int32'. </summary>
        public string DataType { get; set; }
        /// <summary> Column Type. </summary>
        public string ColumnType { get; set; }
    }
}
