using System;


namespace D8S.L0015.Z000
{
    public class ProjectXmlNodeNames : IProjectXmlNodeNames
    {
        #region Infrastructure

        public static IProjectXmlNodeNames Instance { get; } = new ProjectXmlNodeNames();


        private ProjectXmlNodeNames()
        {
        }

        #endregion
    }
}
