using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_end.DB.DTO;
using Back_end.DB.Entities;

namespace Back_end.Utilities
{
    public static class Utility
    {
        public static CategoryDTO CategoryEntityToDTO(this Category entity)
        {
            return new CategoryDTO()
            {
                Name = entity.Name,
                Perfix = entity.Perfix,
            };
        }
        public static Category CategoryDTOToEntity(this CategoryDTO category)
        {
            return new Category()
            {
                Name = category.Name,
                Perfix = category.Perfix,
            };
        }        public static AssetDTO AssetEntityToDTO(this Asset entity)
        {
            return new AssetDTO()
            {
                Name = entity.Name,
                AssetStatus = entity.AssetStatus,
                AssetState = entity.AssetState,
            };
        }
        public static Asset AssetDTOToEntity(this AssetDTO asset)
        {
            return new Asset()
            {
                Name = asset.Name,
                AssetStatus = asset.AssetStatus,
                AssetState = asset.AssetState,
            };
        }

    }
}