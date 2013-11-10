//11.01. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and
//       holds a version in the format major.minor (e.g. 2.11).

namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
        AllowMultiple = false /* Doesn't allow multiple entries */)]
    class VersionAttribute : Attribute
    {
        // Property with a public getter and a private setter
        public double Version { get; private set; }

        // I use double because the format we're looking for is 'major.minor' but it could be string too
        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
}