﻿namespace Catalog.Models
{
    public class CatalogItem
    {
        public const string TableName = "CatalogItems";
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public decimal Price { get; private set; }
        public int AvailableStock { get; private set; }
        public string Slug { get; private set; } = null!;
        public int MaxStockThreshold { get; private set; }
        public CatalogItem Create(string name, string description, int maxStockThreshold, int brandId, decimal price = default)
            => new CatalogItem
            {
                Name = name,
                CatalogBrandId = brandId,
                Description = description,
                MaxStockThreshold = maxStockThreshold,
                Slug = name,
                Price = price
            };
        public CatalogBrand CatalogBrand { get; private set; } = null!;
        public int CatalogBrandId { get; private set; }
        public CatalogCategory CatalogCategory { get; private set; } = null!;
        public int CatalogCategoryId { get; private set; }

    }
}