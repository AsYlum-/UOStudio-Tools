﻿namespace UOStudio.TextureAtlasGenerator
{
    internal sealed class ItemUvwCalculator : IUvwCalculator
    {
        public Uvws CalculcateUvws(TextureAsset textureAsset, int atlasPageSize, int currentX, int currentY, int page)
        {
            var atlasX = currentX / (float) atlasPageSize;
            var atlasY = currentY / (float) atlasPageSize;
            var atlasTileWidth = textureAsset.Bitmap.Width / (float) atlasPageSize;
            var atlasTileHeight = textureAsset.Bitmap.Height / (float) atlasPageSize;

            var uvws = new Uvws
            {
                V1 = new Vertex
                {
                    U = atlasX,
                    V = atlasY,
                    W = 1.0f / page
                },
                V2 = new Vertex
                {
                    U = atlasX + atlasTileWidth,
                    V = atlasY,
                    W = 1.0f / page
                },
                V3 = new Vertex
                {
                    U = atlasX,
                    V = atlasY + atlasTileHeight,
                    W = 1.0f / page
                },
                V4 = new Vertex
                {
                    U = atlasX + atlasTileWidth,
                    V = atlasY + atlasTileHeight,
                    W = 1.0f / page
                }
            };
            return uvws;
        }

        public TileType TileType => TileType.Item;
    }
}