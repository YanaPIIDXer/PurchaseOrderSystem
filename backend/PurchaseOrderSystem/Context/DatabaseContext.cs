using Microsoft.EntityFrameworkCore;
using PurchaseOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrderSystem.Context
{
	/// <summary>
	/// データベースコンテキスト
	/// </summary>
	public class DatabaseContext : DbContext
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="options">オプション</param>
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{
		}

		// === 各種テーブルへのプロパティ ===
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
	}
}
