using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public const char Symbol = '|';

        // Switched the CollisionGroupString (TASK 08)
        //===================================================================================================== Edit>
        public new const string CollisionGroupString = "indestructibleBlock";
        //===================================================================================================== >Edit
        
        public IndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }

        // Overrided the GetCollisionGroupString (TASK 08)
        //===================================================================================================== Edit>
        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }
        //===================================================================================================== >Edit
    }
}
