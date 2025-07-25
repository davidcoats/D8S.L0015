using System;

using R5T.T0131;


namespace D8S.L0015.Z000
{
    /// <summary>
    /// 
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectXmlNodeNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>AssemblyName</value></para>
        /// Common - used by MSBuild.
        /// </summary>
        public string AssemblyName => "AssemblyName";
    }
}
