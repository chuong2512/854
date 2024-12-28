using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Ui;
using UnityEngine;

public class IapManager
{
	public static void Init()
	{
		
		
		IapManager.inst = new IapManager();
	}

	public static string[] productIds = new string[]
	{
		"com.beesquare.almostahero.gem_pack_01",
		"com.beesquare.almostahero.gem_pack_02",
		"com.beesquare.almostahero.gem_pack_03",
		"com.beesquare.almostahero.gem_pack_04",
		"com.beesquare.almostahero.gem_pack_05",
		"com.beesquare.almostahero.gem_pack_06",
		"com.beesquare.almostahero.starter_pack",
		"com.beesquare.almostahero.currency_pack",
		"com.beesquare.almostahero.xmas_pack",
		"com.beesquare.almostahero.mid_gem_offer",
		"com.beesquare.almostahero.late_gem_offer",
		"com.beesquare.almostahero.rift_pack_01",
		"com.beesquare.almostahero.rift_pack_02",
		"com.beesquare.almostahero.rift_pack_03",
		"com.beesquare.almostahero.gem_pack_04_discounted",
		"com.beesquare.almostahero.stage_100_offer",
		"com.beesquare.almostahero.rift_pack_04",
		"com.beesquare.almostahero.halloween_pack_01",
		"com.beesquare.almostahero.candies_pack_01",
		"com.beesquare.almostahero.candies_pack_01",
		"com.beesquare.almostahero.xmas_pack_18_01",
		"com.beesquare.almostahero.xmas_pack_18_02",
		"com.beesquare.almostahero.stage_200",
		"com.beesquare.almostahero.stage_500",
		"com.beesquare.almostahero.bday_gems_19_01",
		"com.beesquare.almostahero.bday_currency_19_01",
		"com.beesquare.almostahero.bday_gems_19_02",
		"com.beesquare.almostahero.bday_currency_19_02"
	};

	public static string[] productPriceStringsLocal = new string[]
	{
		"$ 0.99",
		"$ 1.99",
		"$ 4.99",
		"$ 19.99",
		"$ 49.99",
		"$ 99.99",
		"$ 3.99",
		"$ 9.99",
		"$ 14.99",
		"$ 3.99",
		"$ 5.99",
		"$ 8.99",
		"$ 6.99",
		"$ 7.99",
		"$ 7.99",
		"$ 5.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 14.99",
		"$ 4.99",
		"$ 19.99",
		"$ 9.99",
		"$ 39.99"
	};

	public static double[] productPrices;

	public static List<IapManager.XiaomiReceipt> xiaomiTransactions;

	private static string transactionSave = "XIAOMI_TRANSACTIONS";

	public int boughtProductIndex = -1;

	public static IapManager inst;

	public static string storeCurrency;

	public class UnityIapReceipt
	{
		public string Store;

		public string TransactionID;

		public string Payload;
	}

	private class UnityIapGooglePlayPayload
	{
		public string json;

		public string signature;
	}

	public class XiaomiReceipt
	{
		public string receipt;

		public string transactionId;

		public string id;
	}
}
