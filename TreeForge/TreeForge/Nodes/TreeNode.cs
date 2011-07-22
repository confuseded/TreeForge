using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TreeForge.Graphics;

namespace TreeForge.Nodes
{
    public class TreeNode
    {
        public Vector2 Dim;
        public Vector2 Pos;

        public TreeNode()
        {
            Dim = new Vector2(1, 1);
            Pos = Vector2.Zero;
        }

        public RectangleF GetWorldRect()
        {
            return new RectangleF(new Vector2(Pos.X - Dim.X, Pos.Y + Dim.Y), new Vector2(Pos.X + Dim.X, Pos.Y - Dim.Y));
        }

        public void Update(GameTime g)
        {
 
        }

        public void Draw(GameTime g, SpriteBatch spriteBatch, PrimitiveBatch2D primBatch)
        {
            primBatch.FillQuad(new Vector3(Pos.X - Dim.X, Pos.Y + Dim.Y, 0),
                               new Vector3(Pos.X + Dim.X, Pos.Y + Dim.Y, 0),
                               new Vector3(Pos.X + Dim.X, Pos.Y - Dim.Y, 0),
                               new Vector3(Pos.X - Dim.X, Pos.Y - Dim.Y, 0),
                               Color.Red);
        }


    }

}
