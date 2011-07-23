using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TreeForge.Nodes;

namespace TreeForge.SkillTrees
{
    public class MercenarySkillTree : SkillTree
    {
        Vector2 noReq = new Vector2(-1, -1);
        public MercenarySkillTree()
            : base()
        {
            
        }

        protected override void SetUpTiers()
        {
            base.SetUpTiers();

            tiers.Add(CreateTierOne());
            tiers.Add(CreateTierTwo());
            tiers.Add(CreateTierThree());
            tiers.Add(CreateTierFour());
            tiers.Add(CreateTierFive());
            tiers.Add(CreateTierSix());
            tiers.Add(CreateTierSeven());
            tiers.Add(CreateTierEight());
            tiers.Add(CreateTierNine());
            tiers.Add(CreateTierTen());
            tiers.Add(CreateTierEleven());
        }

        private TreeNode[] CreateTierOne()
        {
            int tier = 1;
            TreeNode[] firstTier = { null, new TreeNode(tier, 4, new Vector2(0,2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 4, new Vector2(0,2)), null, null };
            return firstTier;
        }

        private TreeNode[] CreateTierTwo()
        {
            int tier = 2;
            TreeNode[] secondTier = { new TreeNode(tier, 5, noReq), new TreeNode(tier, 4, new Vector2(1, 2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 4, new Vector2(1, 2)), new TreeNode(tier, 5, noReq), null };
            return secondTier;
        }

        private TreeNode[] CreateTierThree()
        {
            int tier = 3;
            TreeNode[] thirdTier = { new TreeNode(tier, 1, noReq), new TreeNode(tier, 4, new Vector2(2, 2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 4, new Vector2(2, 2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 4, new Vector2(2, 4)) };
            return thirdTier;
        }

        private TreeNode[] CreateTierFour()
        {
            int tier = 4;
            TreeNode[] fourthTier = { new TreeNode(tier, 3, new Vector2(2, 0)), null, new TreeNode(tier, 5, noReq), new TreeNode(tier, 1, noReq), new TreeNode(tier, 5, noReq), null };
            return fourthTier;
        }

        private TreeNode[] CreateTierFive()
        {
            int tier = 5;
            TreeNode[] fifthTier = { null, new TreeNode(tier, 4, new Vector2(4, 2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 5, new Vector2(3, 3)), new TreeNode(tier, 5, noReq), new TreeNode(tier, 3, new Vector2(2, 5)) };
            return fifthTier;
        }
        private TreeNode[] CreateTierSix()
        {
            int tier = 6;
            TreeNode[] sixthTier = { new TreeNode(tier, 5, new Vector2(3, 0)), new TreeNode(tier, 3, new Vector2(4, 1)), new TreeNode(tier, 5, noReq), new TreeNode(tier, 5, noReq), null, new TreeNode(tier, 1, new Vector2(4, 5)) };
            return sixthTier;
        }

        private TreeNode[] CreateTierSeven()
        {
            int tier = 7;
            TreeNode[] seventhTier = { new TreeNode(tier, 1, new Vector2(5, 0)), new TreeNode(tier, 1, new Vector2(5, 1)), new TreeNode(tier, 5, noReq), new TreeNode(tier, 5, noReq), new TreeNode(tier, 3, noReq), null };
            return seventhTier;
        }

        private TreeNode[] CreateTierEight()
        {
            int tier = 8;
            TreeNode[] eigthTier = { new TreeNode(tier, 1, new Vector2(7, 1)), new TreeNode(tier, 3, new Vector2(7, 2)), new TreeNode(tier, 1, noReq), new TreeNode(tier, 5, noReq), new TreeNode(tier, 5, noReq), null };
            return eigthTier;
        }

        private TreeNode[] CreateTierNine()
        {
            int tier = 9;
            TreeNode[] ninthTier = { new TreeNode(tier, 3, noReq), new TreeNode(tier, 5, noReq), new TreeNode(tier, 1, noReq), new TreeNode(tier, 1, new Vector2(7, 3)), new TreeNode(tier, 3, noReq), null };
            return ninthTier;
        }

        private TreeNode[] CreateTierTen()
        {
            int tier = 10;
            TreeNode[] tenthTier = { new TreeNode(tier, 5, new Vector2(8, 0)), null, new TreeNode(tier, 5, new Vector2(8, 2)), null, new TreeNode(tier, 5, new Vector2(8, 4)), null };
            return tenthTier;
        }

        private TreeNode[] CreateTierEleven()
        {
            int tier = 11;
            TreeNode[] eleventhTier = { new TreeNode(tier, 1, new Vector2(9, 0)), null, new TreeNode(tier, 1, new Vector2(9, 2)), null, new TreeNode(tier, 1, new Vector2(9, 4)), null };
            return eleventhTier;
        }
    }
}
