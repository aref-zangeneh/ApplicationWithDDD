﻿
namespace ApplicationWithDDD.Shared.Abstraction.Queries
{
    public interface IQuery
    {
    }

    public interface IQuery<TResult> : IQuery
    {

    }
}
