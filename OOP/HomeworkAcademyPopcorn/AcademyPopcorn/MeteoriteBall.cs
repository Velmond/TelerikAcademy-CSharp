namespace AcademyPopcorn
{
    using System.Collections.Generic;

    //06. Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects.
    //    Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way
    //    as the normal ball. You must NOT edit any existing .cs file.
    //========================================================================================================== Task 06>
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        { }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> trail = new List<GameObject>();

            trail.Add(new TrailObject(base.topLeft, 3));

            return trail;
        }
    }
    //========================================================================================================== >Task 06
}
