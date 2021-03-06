﻿using System;
using System.IO;
using System.Reflection;

namespace Evolve.IntegrationTest.PostgreSQL
{
    public static class TestContext
    {
        public const string ImageName = "postgres:latest";
        public const string ContainerName = "postgres-evolve";
        public const string ContainerPort = "5432";
        public const string DbName = "my_database";
        public const string DbPwd = "Password12!"; // AppVeyor
        public const string DbUser = "postgres";

        static TestContext()
        {
            ResourcesFolder = Path.Combine(Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath), "Resources");
            SqlScriptsFolder = Path.Combine(ResourcesFolder, "Sql_Scripts");
            MigrationFolder = Path.Combine(SqlScriptsFolder, "Migration");
            ChecksumMismatchFolder = Path.Combine(SqlScriptsFolder, "Checksum_mismatch");
            EmptyMigrationScriptPath = Path.Combine(ResourcesFolder, "V1_3_2__Migration_description.sql");
        }

        public static string ResourcesFolder { get; }
        public static string SqlScriptsFolder { get; }
        public static string MigrationFolder { get; }
        public static string ChecksumMismatchFolder { get; }
        public static string EmptyMigrationScriptPath { get; }
    }
}
