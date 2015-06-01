using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HollowBack
{
    class Slug : Enemy
    {
        private bool isFriendly = false;
        private bool isDestroy = false;


        public bool Friendly
        {
            get { return isFriendly; }
            set { this.isFriendly = value; }
        }

        public bool Destroy
        {
            get { return isDestroy; }
            set { this.isDestroy = value; }
        }


        public Slug(ContentManager pContent, Scene pScene, int pID, Point pTargetID)
            : base(pContent, "Slug", pScene)
        {
            IsUnknown = false;
            IsVisible = true;
            IsActive = false;
            Health = 1;

            ID = new Point(6, pID);
            TargetID = pTargetID;

            this.Scale = new Vector2(0.3f, 0.3f);

            MaxSpeed = 2f;
            Velocity = MaxSpeed;
            Accelaration = 0.2f;

            this.s_texture = pContent.Load<Texture2D>("SlugSelected");
        }

        public void Update()
        {
            UpdateMovement(10);
            base.Update();
        }
    }
}
