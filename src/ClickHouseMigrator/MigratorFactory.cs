﻿using ClickHouseMigrator.Impl;
using System;

namespace ClickHouseMigrator
{
	public static class MigratorFactory
	{
		public static IMigrator Create(Options arguments)
		{
			var source = arguments.DataSource.ToLower();
			switch (source)
			{
				case "mysql":
					{
						return new MySqlMigrator(arguments);
					}
				case "mssql":
				case "sqlserver":
					{						
						return new MsSqlMigrator(arguments);
					}
				default:
					{
						throw new NotImplementedException($"Not implemented {source} migrator.");
					}
			}
		}
	}
}
