using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrderSystem.Responses
{
	/// <summary>
	/// ヘルスチェック用レスポンス
	/// </summary>
	public class HealthCheckResponse
	{
		/// <summary>
		/// メッセージ
		/// </summary>
		public string Message { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public HealthCheckResponse()
		{
			Message = "Alive";
		}
	}
}
