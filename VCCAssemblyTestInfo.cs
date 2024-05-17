using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace VCCAssemblyTest
{
    public class VCCAssemblyTestInfo : GH_AssemblyInfo
    {
        public override string Name => "VCCAssemblyTest";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("91ed4566-7610-49e5-9d21-1af838af5cf4");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}