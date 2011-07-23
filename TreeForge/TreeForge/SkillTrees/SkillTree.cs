using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using TreeForge.Input;
using TreeForge.Nodes;
using TreeForge.Graphics;

namespace TreeForge.SkillTrees
{
    public class SkillTree
    {
        protected List<TreeNode[]> tiers;
        private float horizontalSpacing = 0.8f;
        private float verticalSpacing = 0.8f;
        public int MaxTotalPoints = 51;

        public SkillTree()
        {
            tiers = new List<TreeNode[]>();

            SetUpTiers();
            PositionNodes();
        }

        protected virtual void SetUpTiers()
        {

        }

        private int GetPoints()
        {
            int points= 0;
            for (int i = 0; i < tiers.Count; i++)
            {
                for (int j = 0; j < tiers[i].Length; j++)
                {
                    TreeNode tn = tiers[i][j];
                    if (tn == null)
                    {
                        continue;
                    }
                    points += tn.points;
                }
            }

            return points;
        }

        private void PositionNodes()
        {
            for (int i = 0; i < tiers.Count; i++)
            {
                for (int j = 0; j < tiers[i].Length; j++)
                {
                    TreeNode tn = tiers[i][j];
                    if (tn == null)
                    {
                        continue;
                    }
                    tn.Pos = new Vector2((j * (tn.Dim.X * 2 + horizontalSpacing)), (i * (tn.Dim.Y * 2 + verticalSpacing)));
                }
            }
        }

        public void Update(GameTime g, Camera2D cam)
        {
            Vector2 worldMousePos = cam.GetWorldMousePos();
            Vector2 noReq = new Vector2(-1, -1);

            for (int i = 0; i < tiers.Count; i++)
            {
                for (int j = 0; j < tiers[i].Length; j++)
                {
                    TreeNode tn = tiers[i][j];
                    bool requirementsMet = true;
                    if (tn == null)
                    {
                        continue;
                    }
                    //check requirements
                    if (tn.Req != noReq)
                    {
                        if (tiers[(int)tn.Req.X][(int)tn.Req.Y].points != tiers[(int)tn.Req.X][(int)tn.Req.Y].GetMaximumPointsAllowed())
                        {
                            requirementsMet = false;
                        }
                    }

                    if (tn.CheckMouseClick(worldMousePos) & InputHandler.MouseState.LeftButton == ButtonState.Pressed & InputHandler.LastMouseState.LeftButton == ButtonState.Released & GetPoints() != MaxTotalPoints & requirementsMet)
                        tn.AddPoint();
                    tn.Update(g, GetPoints(), requirementsMet);
                }
            }
        }

        public void Draw(GameTime g, SpriteBatch spriteBatch, PrimitiveBatch2D primBatch)
        {
            for (int i = 0; i < tiers.Count; i++)
            {
                for (int j = 0; j < tiers[i].Length; j++)
                {
                    if (tiers[i][j] == null)
                    {
                        continue;
                    }

                    tiers[i][j].Draw(g, spriteBatch, primBatch);
                }
            }
        }
    }
}
