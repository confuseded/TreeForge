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
        public int points;
        private int mp;
        private bool available;
        private int t;
 

        public TreeNode(int tier,int maxPoints)
        {
            Dim = new Vector2(1, 1);
            Pos = Vector2.Zero;
            points = 0;
            mp = maxPoints;
            t = tier;
        }

        public RectangleF GetWorldRect()
        {
            return new RectangleF(new Vector2(Pos.X - Dim.X, Pos.Y + Dim.Y), new Vector2(Pos.X + Dim.X, Pos.Y - Dim.Y));
        }


        public void Update(GameTime g, int totalPoints)
        {
            if (totalPoints == (t * 5)-5)
                available = true;
            
        }

        public void Draw(GameTime g, SpriteBatch spriteBatch, PrimitiveBatch2D primBatch)
        {
            if (available & points==0)
            {
                primBatch.FillQuad(new Vector3(Pos.X - Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y - Dim.Y, 0),
                                   new Vector3(Pos.X - Dim.X, Pos.Y - Dim.Y, 0),
                                   Color.White);
            }

            else if (available & points > 0 & points < mp)
            {
                primBatch.FillQuad(new Vector3(Pos.X - Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y - Dim.Y, 0),
                                   new Vector3(Pos.X - Dim.X, Pos.Y - Dim.Y, 0),
                                   Color.Yellow);
            }

            else if (available & points == mp)
            {
                primBatch.FillQuad(new Vector3(Pos.X - Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y - Dim.Y, 0),
                                   new Vector3(Pos.X - Dim.X, Pos.Y - Dim.Y, 0),
                                   Color.Gold);
            }

            else
            {
                primBatch.FillQuad(new Vector3(Pos.X - Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y + Dim.Y, 0),
                                   new Vector3(Pos.X + Dim.X, Pos.Y - Dim.Y, 0),
                                   new Vector3(Pos.X - Dim.X, Pos.Y - Dim.Y, 0),
                                   Color.Gray);
            }

        }


    }

}
