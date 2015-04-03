﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectEventArgs.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.ProjectManagement
{
    using System;

    public class ProjectEventArgs : EventArgs
    {
        #region Constructors
        public ProjectEventArgs(string location)
        {
            Location = location;
        }

        public ProjectEventArgs(IProject project)
        {
            Project = project;

            if (project != null)
            {
                Location = project.Location;
            }
        }
        #endregion

        #region Properties
        public string Location { get; private set; }
        public IProject Project { get; private set; }
        #endregion
    }
}