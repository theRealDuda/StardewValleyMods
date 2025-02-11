﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

namespace SARDIS.CustomObjects
{
    public class SardisObject : SObject
    {
        public SardisObject()
        {
            this.Name = "The SARDIS";
            this.DisplayName = "The SARDIS";
            this.boundingBox.Value = new Microsoft.Xna.Framework.Rectangle((int)this.tileLocation.X * 64,
                (int)this.tileLocation.Y * 64, 64, 64);
            this.Fragility = 2;
        }

        public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
        {
            // if (base.placementAction(location, x, y, who))
            // {
            //     if (location.Objects.ContainsKey(new Vector2(x, y)))
            //     {
            //         location.Objects[new Vector2(x, y)].fragility.Value = 2;
            //     }
            //
            //     return true;
            // }
            x /= 64;
            y /= 64;

            if (!location.Objects.ContainsKey(new Vector2(x, y)))
            {
                SardisObject sardis = new SardisObject();
                sardis.TileLocation = new Vector2(x, y);
                location.Objects.Add(sardis.TileLocation, sardis);
                Game1.player.reduceActiveItemByOne();

                return true;
            }

            return false;
        }

        public override bool canBePlacedHere(GameLocation l, Vector2 tile)
        {
            return true;
        }

        public override bool isPlaceable()
        {
            return true;
        }

        public override void draw(SpriteBatch spriteBatch, int xNonTile, int yNonTile, float layerDepth,
            float alpha = 1)
        {
            // spriteBatch.Draw(
            //     ModEntry.SardisExterior,
            //     new Vector2(xNonTile, yNonTile),
            //     Color.White
            // );
        }

        public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1)
        {
            // spriteBatch.Draw(
            //     ModEntry.SardisExterior,
            //     Game1.GlobalToLocal(Game1.viewport, new Vector2(x * 64 + 23, y * 64 + 23)),
            //     Color.White
            //     );

            spriteBatch.Draw(
                ModEntry.SardisExterior,
                Game1.GlobalToLocal(Game1.viewport, new Vector2(x * 64, y * 64 - 64)),
                ModEntry.SardisExterior.Bounds,
                Color.White,
                0f,
                Vector2.Zero,
                4f,
                SpriteEffects.None,
                0f
            );
        }

        public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency,
            float layerDepth,
            StackDrawType drawStackNumber, Color color, bool drawShadow)
        {
            // spriteBatch.Draw(
            //     ModEntry.SardisExterior,
            //     location,
            //     Color.White
            //     );
            spriteBatch.Draw(
                ModEntry.SardisExterior,
                location + new Vector2(24, 16),
                null,
                Color.White,
                0f,
                new Vector2(0, 0),
                1f,
                SpriteEffects.None,
                1f
            );
        }

        public override void farmerAdjacentAction(GameLocation location)
        {
        }

        public override bool clicked(Farmer who)
        {
            return false;
        }
    }
}
