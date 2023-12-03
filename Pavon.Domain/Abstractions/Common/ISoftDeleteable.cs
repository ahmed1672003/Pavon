﻿namespace Pavon.Domain.Abstractions.Common;
public interface ISoftDeleteable
{
    public bool IsDeleted { get; set; }

    Task SoftDeleteAsync() => Task.Run(() => IsDeleted = true);
}
