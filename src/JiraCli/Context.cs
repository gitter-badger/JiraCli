﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Context.cs" company="CatenaLogic">
//   Copyright (c) 2014 - 2014 CatenaLogic. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace JiraCli
{
    using Catel.Logging;

    public class Context
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public Context()
        {
        }

        public bool IsHelp { get; set; }
        public string LogFile { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string JiraUrl { get; set; }

        public void ValidateContext()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                Log.ErrorAndThrowException<JiraCliException>("User name is missing");
            }

            if (string.IsNullOrEmpty(Password))
            {
                Log.ErrorAndThrowException<JiraCliException>("Password is missing");
            }

            if (string.IsNullOrEmpty(JiraUrl))
            {
                Log.ErrorAndThrowException<JiraCliException>("Jira url is missing");
            }

            // TODO: Add more items
        }
    }
}