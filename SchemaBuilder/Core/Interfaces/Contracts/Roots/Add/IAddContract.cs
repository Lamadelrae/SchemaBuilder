﻿using SchemaBuilder.Core.Interfaces.Contracts.Operations.Add;
using SchemaBuilder.Models;

namespace SchemaBuilder.Core.Interfaces.Contracts.Roots.Add
{
    public interface IAddContract
    {
        IAddColumnContract Column(string columnName, Func<ColumnInfo, ColumnInfo> func);

        IAddTableContract Table(string tableName);
    }
}