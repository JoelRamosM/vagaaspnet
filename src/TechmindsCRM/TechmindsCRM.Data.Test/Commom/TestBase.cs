﻿using Ninject.MockingKernel.NSubstitute;

namespace TechmindsCRM.Data.Test.Commom
{
    public class TestBase
    {
        protected NSubstituteMockingKernel kernel;

        public TestBase()
        {
            kernel = new NSubstituteMockingKernel();
        }
    }
}
