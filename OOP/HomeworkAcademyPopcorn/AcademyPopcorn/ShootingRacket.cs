using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //========================================================================================================== Task 13>
    class ShootingRacket : Racket
    {
        private bool HasShot { get; set; }

        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        { }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> shots = new List<GameObject>();

            if (this.HasShot)
            {
                shots.Add(new Bullet(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col + 3)));
                this.HasShot = false;
            }

            return shots;
        }

        internal void Shoot()
        {
            this.HasShot = true;
        }
    }
    //========================================================================================================== >Task 13
}
