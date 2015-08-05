﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemoryProjectReader.cs" company="Orchestra development team">
//   Copyright (c) 2008 - 2014 Orchestra development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.ProjectManagement.Test.Mocks
{
    using System;

    public class MemoryProjectReader : ProjectReaderBase
    {
        protected override IProject ReadFromLocation(string location)
        {
            if (string.Equals(location, "cannotload"))
            {
                throw new Exception("expected exception");
            }

            return new Project(location);
        }
    }
}