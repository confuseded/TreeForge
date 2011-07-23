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
        public Vector2 Req;
        public int points;
        private int mp;
        private bool available;
        private int t;
        private bool tierAvailable;
 

        public TreeNode(int tier,int maxPoints, Vector2 require)
        {
            Dim = new Vector2(1, 1);
            Pos = Vector2.Zero;
            points = 0;
            mp = maxPoints;
            t = tier;
            Req = require;
            tierAvailable = false;
        }

        public RectangleF GetWorldRect()
        {
            return new RectangleF(new Vector2(Pos.X - Dim.X, Pos.Y + Dim.Y), new Vector2(Pos.X + Dim.X, Pos.Y - Dim.Y));
        }

        public bool CheckMouseClick(Vector2 mouse)
        {
            RectangleF bounds = GetWorldRect();
            if (mouse.X >= bounds.UpperLeft.X & mouse.X <= bounds.BottomRight.X & mouse.Y >= bounds.BottomRight.Y & mouse.Y <= bounds.UpperLeft.Y)
            {
                return true;
            }
            else
                return false;
        }

        public void AddPoint()
        {
            if (available & points != mp)
                ++points;
        }

        public int GetMaximumPointsAllowed()
        {
            return mp;
        }


        public void Update(GameTime g, int totalPoints, bool requirementsMet)
        {
            if (totalPoints == ((t * 5)-5))
                tierAvailable = true;
            if (requirementsMet & tierAvailable)
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
                                   Color.DarkOrange);
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
