using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using TreeForge.Graphics;
using TreeForge.GUI;
using TreeForge.SkillTrees;

namespace TreeForge.GUI
{
    public class TreePanel : Panel
    {
        PrimitiveBatch2D primBatch;
        SpriteBatch spriteBatch;
        Camera2D cam;
        SkillTree tree;

        public TreePanel(Vector2 upLeft, Vector2 botRight)
            : base(upLeft, botRight)
        {
            cam = new Camera2D(Vector2.Zero, this);
            tree = new MercenarySkillTree();
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);

            spriteBatch = new SpriteBatch(Device);
            primBatch = new PrimitiveBatch2D(Device);
        }

        protected override void OnRefresh()
        {
            base.OnRefresh();
            cam.Resize(width, height);
        }

        public override void Update(GameTime g)
        {
            base.Update(g);
            cam.Update(g);
            tree.Update(g,cam);

        }

        public override void Draw(GameTime g)
        {
            base.Draw(g);
            Device.Clear(Color.MediumBlue);


            primBatch.Begin(PrimitiveType.TriangleList, cam);
            tree.Draw(g, spriteBatch, primBatch);
            primBatch.End();
        }

    }
}
