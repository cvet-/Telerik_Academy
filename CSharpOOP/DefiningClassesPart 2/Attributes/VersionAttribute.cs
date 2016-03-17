using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Enum |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Struct)]
    class VersionAttribute : Attribute
    {
        public Version Version { get; private set; }

        public VersionAttribute(string version)
        {
            try
            {
                Version = Version.Parse(version);
            }
            catch (Exception)
            {
                
                throw new ArgumentException("Invalid version format");
            }
        }
    }
}
