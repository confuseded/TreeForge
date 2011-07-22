using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TreeForge.Nodes;
using TreeForge.Graphics;

namespace TreeForge.SkillTrees
{
    public class SkillTree
    {
        protected List<TreeNode[]> tiers;
        private float horizontalSpacing = 0.5f;
        private float verticalSpacing = 0.5f;

        public SkillTree()
        {
            tiers = new List<TreeNode[]>();

            SetUpTiers();
            PositionNodes();
        }

        protected virtual void SetUpTiers()
        {

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

        public void Update(GameTime g)
        {

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
