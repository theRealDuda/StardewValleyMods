﻿using DecidedlyShared.Constants;
using Microsoft.Xna.Framework;

namespace DecidedlyShared.Utilities;

public class Geometry
{
    public static Corners GetCornerPoints(Vector2 topLeftPoint, int width, int height)
    {
        Corners corners = new Corners();

        corners.topLeft = topLeftPoint;
        corners.topRight = topLeftPoint + new Vector2(width, 0);
        corners.bottomLeft = topLeftPoint + new Vector2(0, height);
        corners.bottomRight = topLeftPoint + new Vector2(width, height);

        return corners;
    }

    public static Corners GetCornerPoints(Rectangle boundingBox)
    {
        Corners corners = new Corners();

        corners.topLeft = new Vector2(boundingBox.Top, boundingBox.Left);
        corners.topRight = new Vector2(boundingBox.Top, boundingBox.Right);
        corners.bottomLeft = new Vector2(boundingBox.Bottom, boundingBox.Left);
        corners.bottomRight = new Vector2(boundingBox.Bottom, boundingBox.Right);

        return corners;
    }
}
