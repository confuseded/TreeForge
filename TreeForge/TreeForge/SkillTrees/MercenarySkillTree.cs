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
            TreeNode[] firstTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return firstTier;
        }

        private TreeNode[] CreateTierTwo()
        {
            TreeNode[] secondTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return secondTier;
        }

        private TreeNode[] CreateTierThree()
        {
            TreeNode[] thirdTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return thirdTier;
        }

        private TreeNode[] CreateTierFour()
        {
            TreeNode[] fourthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return fourthTier;
        }

        private TreeNode[] CreateTierFive()
        {
            TreeNode[] fifthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return fifthTier;
        }
        private TreeNode[] CreateTierSix()
        {
            TreeNode[] sixthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return sixthTier;
        }

        private TreeNode[] CreateTierSeven()
        {
            TreeNode[] seventhTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return seventhTier;
        }

        private TreeNode[] CreateTierEight()
        {
            TreeNode[] eigthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return eigthTier;
        }

        private TreeNode[] CreateTierNine()
        {
            TreeNode[] ninthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return ninthTier;
        }

        private TreeNode[] CreateTierTen()
        {
            TreeNode[] tenthTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return tenthTier;
        }

        private TreeNode[] CreateTierEleven()
        {
            TreeNode[] eleventhTier = { null, new TreeNode(), new TreeNode(), new TreeNode(), null, null };
            return eleventhTier;
        }
    }
}
