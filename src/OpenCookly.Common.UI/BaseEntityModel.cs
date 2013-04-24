using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Entities;
using System.Collections.Generic;

namespace OpenCookly.Common.UI
{
    public class BaseEntityModel<TEntity> : Model<TEntity>
        where TEntity: BaseEntity, new()
    {
        protected override Func<TEntity, TEntity, bool> IsSameItem
        {
            get
            {
                return (entity1, entity2) => entity1.Id == entity2.Id;
            }
        }
    }
}

