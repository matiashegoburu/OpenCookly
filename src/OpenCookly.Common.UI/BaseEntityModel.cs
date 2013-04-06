using System;
using Hegoburu.Presentation.Desktop.Core;
using OpenCookly.Entities;

namespace OpenCookly.Common.UI
{
    public class BaseEntityModel<TEntity> : Model<TEntity>
        where TEntity: BaseEntity
    {
        public BaseEntityModel(TEntity entity)
            : base(entity, (entity1, entity2) => entity1.Id == entity2.Id)
        {
            
        }

    }
}

