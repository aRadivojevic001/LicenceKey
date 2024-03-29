﻿using MongoDB.Entities;

namespace LicenceKey.Domain.Entities;

public class BaseEntity : Entity, ICreatedOn, IModifiedOn
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public bool Active { get; set; }
}
