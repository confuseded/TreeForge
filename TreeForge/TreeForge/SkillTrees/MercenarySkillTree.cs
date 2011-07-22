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
            TreeNode[] firstTier = { null, new TreeNode(tier,4), new TreeNode(tier,1), new TreeNode(tier,4), null, null };
            return firstTier;
        }

        private TreeNode[] CreateTierTwo()
        {
            int tier = 2;
            TreeNode[] secondTier = { new TreeNode(tier, 5), new TreeNode(tier, 4), new TreeNode(tier, 1), new TreeNode(tier, 4), new TreeNode(tier, 5), null };
            return secondTier;
        }

        private TreeNode[] CreateTierThree()
        {
            int tier = 3;
            TreeNode[] thirdTier = { new TreeNode(tier, 1), new TreeNode(tier, 4), new TreeNode(tier, 1), new TreeNode(tier, 4), new TreeNode(tier, 1), new TreeNode(tier, 4) };
            return thirdTier;
        }

        private TreeNode[] CreateTierFour()
        {
            int tier = 4;
            TreeNode[] fourthTier = { new TreeNode(tier,3), null, new TreeNode(tier,5), new TreeNode(tier,1), new TreeNode(tier,5), null };
            return fourthTier;
        }

        private TreeNode[] CreateTierFive()
        {
            int tier = 5;
            TreeNode[] fifthTier = { null, new TreeNode(tier, 4), new TreeNode(tier, 1), new TreeNode(tier, 5), new TreeNode(tier, 5), new TreeNode(tier, 3) };
            return fifthTier;
        }
        private TreeNode[] CreateTierSix()
        {
            int tier = 6;
            TreeNode[] sixthTier = { new TreeNode(tier, 5), new TreeNode(tier, 3), new TreeNode(tier, 5), new TreeNode(tier, 5), null, new TreeNode(tier, 1) };
            return sixthTier;
        }

        private TreeNode[] CreateTierSeven()
        {
            int tier = 7;
            TreeNode[] seventhTier = { new TreeNode(tier, 1), new TreeNode(tier, 1), new TreeNode(tier, 5), new TreeNode(tier, 5), new TreeNode(tier, 3), null };
            return seventhTier;
        }

        private TreeNode[] CreateTierEight()
        {
            int tier = 8;
            TreeNode[] eigthTier = { new TreeNode(tier, 1), new TreeNode(tier, 3), new TreeNode(tier, 1), new TreeNode(tier, 5), new TreeNode(tier, 5), null };
            return eigthTier;
        }

        private TreeNode[] CreateTierNine()
        {
            int tier = 9;
            TreeNode[] ninthTier = { new TreeNode(tier, 3), new TreeNode(tier, 5), new TreeNode(tier, 1), new TreeNode(tier, 1), new TreeNode(tier, 3), null };
            return ninthTier;
        }

        private TreeNode[] CreateTierTen()
        {
            int tier = 10;
            TreeNode[] tenthTier = { new TreeNode(tier, 5), null, new TreeNode(tier, 5), null, new TreeNode(tier, 5), null };
            return tenthTier;
        }

        private TreeNode[] CreateTierEleven()
        {
            int tier = 11;
            TreeNode[] eleventhTier = { new TreeNode(tier, 1), null, new TreeNode(tier, 1), null, new TreeNode(tier, 1), null };
            return eleventhTier;
        }
    }
}
