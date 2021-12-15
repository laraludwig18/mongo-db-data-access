﻿
namespace MongoDB.QueryBuilder.Abstractions
{
    public interface IMongoDbPaging
    {
        int? PageIndex { get; }
        int? PageSize { get; }
        int TotalCount { get; }
        bool IsEnabled { get; }
    }
}
