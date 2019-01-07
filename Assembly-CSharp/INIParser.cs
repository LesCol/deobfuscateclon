using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;

// Token: 0x0200001C RID: 28
public class INIParser
{
	// Token: 0x06000330 RID: 816 RVA: 0x0002D58C File Offset: 0x0002B78C
	public void method_0()
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.method_47();
			this.string_0 = null;
			this.string_1 = null;
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0002D5DC File Offset: 0x0002B7DC
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
		if (File.Exists(this.string_0))
		{
			this.string_1 = File.ReadAllText(this.string_0);
		}
		else
		{
			File.Create(this.string_0).Close();
			this.string_1 = "";
		}
		this.method_23(this.string_1, false);
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0002D638 File Offset: 0x0002B838
	public string method_2(string string_2, string string_3, string string_4)
	{
		object obj = this.object_0;
		string result;
		lock (obj)
		{
			Dictionary<string, string> dictionary;
			string text;
			if (!this.dictionary_0.TryGetValue(string_2, out dictionary))
			{
				result = string_4;
			}
			else if (!dictionary.TryGetValue(string_3, out text))
			{
				result = string_4;
			}
			else
			{
				result = text;
			}
		}
		return result;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0002D69C File Offset: 0x0002B89C
	private void method_3()
	{
		object obj = this.object_0;
		lock (obj)
		{
			StringReader stringReader = null;
			try
			{
				this.dictionary_0.Clear();
				this.dictionary_1.Clear();
				stringReader = new StringReader(this.string_1);
				Dictionary<string, string> dictionary = null;
				string key = null;
				string value = null;
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					text = text.Trim();
					string text2 = this.method_4(text);
					if (text2 != null)
					{
						if (this.dictionary_0.ContainsKey(text2))
						{
							dictionary = null;
						}
						else
						{
							dictionary = new Dictionary<string, string>();
							this.dictionary_0.Add(text2, dictionary);
						}
					}
					else if (dictionary != null && this.method_45(text, ref key, ref value) && !dictionary.ContainsKey(key))
					{
						dictionary.Add(key, value);
					}
				}
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
		}
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0002D78C File Offset: 0x0002B98C
	private string method_4(string string_2)
	{
		if (!string_2.StartsWith("["))
		{
			return null;
		}
		if (!string_2.EndsWith("]"))
		{
			return null;
		}
		if (string_2.Length < 3)
		{
			return null;
		}
		return string_2.Substring(1, string_2.Length - 2).ToLower(CultureInfo.CurrentCulture);
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0002D7DC File Offset: 0x0002B9DC
	public void method_5(string string_2)
	{
		if (this.method_17(string_2))
		{
			object obj = this.object_0;
			lock (obj)
			{
				this.bool_1 = true;
				this.dictionary_0.Remove(string_2);
				this.dictionary_1.Remove(string_2);
				if (this.bool_0)
				{
					this.method_47();
				}
			}
		}
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0002D850 File Offset: 0x0002BA50
	private byte[] method_6(string string_2)
	{
		if (string_2 == null)
		{
			return null;
		}
		int num = string_2.Length;
		if (num < 2)
		{
			return new byte[0];
		}
		num /= 2;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Convert.ToByte(string_2.Substring(i * 2, 2), 16);
		}
		return array;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x000033AB File Offset: 0x000015AB
	public void method_7(string string_2, string string_3, double double_0)
	{
		this.method_34(string_2, string_3, double_0.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000033C1 File Offset: 0x000015C1
	public void method_8(string string_2, string string_3, int int_1)
	{
		this.method_34(string_2, string_3, int_1.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000033D7 File Offset: 0x000015D7
	public void method_9(string string_2, string string_3, byte[] byte_0)
	{
		this.method_34(string_2, string_3, this.method_31(byte_0));
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000033E8 File Offset: 0x000015E8
	public void method_10(string string_2, string string_3, DateTime dateTime_0)
	{
		this.method_34(string_2, string_3, dateTime_0.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0002D8A0 File Offset: 0x0002BAA0
	public int method_11(string string_2, string string_3, int int_1)
	{
		int result;
		if (int.TryParse(this.method_2(string_2, string_3, int_1.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return int_1;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x000033C1 File Offset: 0x000015C1
	public void method_12(string string_2, string string_3, int int_1)
	{
		this.method_34(string_2, string_3, int_1.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
	public bool method_13(string string_2, string string_3)
	{
		if (this.dictionary_0.ContainsKey(string_2))
		{
			Dictionary<string, string> dictionary;
			this.dictionary_0.TryGetValue(string_2, out dictionary);
			return dictionary.ContainsKey(string_3);
		}
		return true;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0002D90C File Offset: 0x0002BB0C
	private void method_14()
	{
		object obj = this.object_0;
		lock (obj)
		{
			StringReader stringReader = null;
			try
			{
				this.dictionary_0.Clear();
				this.dictionary_1.Clear();
				stringReader = new StringReader(this.string_1);
				Dictionary<string, string> dictionary = null;
				string key = null;
				string value = null;
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					text = text.Trim();
					string text2 = this.method_4(text);
					if (text2 != null)
					{
						if (this.dictionary_0.ContainsKey(text2))
						{
							dictionary = null;
						}
						else
						{
							dictionary = new Dictionary<string, string>();
							this.dictionary_0.Add(text2, dictionary);
						}
					}
					else if (dictionary != null && this.method_18(text, ref key, ref value) && !dictionary.ContainsKey(key))
					{
						dictionary.Add(key, value);
					}
				}
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0002D9FC File Offset: 0x0002BBFC
	public void Open(string string_2)
	{
		this.string_0 = string_2;
		if (File.Exists(this.string_0))
		{
			this.string_1 = File.ReadAllText(this.string_0);
		}
		else
		{
			File.Create(this.string_0).Close();
			this.string_1 = "diff_bassghl";
		}
		this.method_23(this.string_1, false);
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0002DA58 File Offset: 0x0002BC58
	public long method_16(string string_2, string string_3, long long_0)
	{
		long result;
		if (long.TryParse(this.method_2(string_2, string_3, long_0.ToString(CultureInfo.InvariantCulture)), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return long_0;
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000341 RID: 833 RVA: 0x000033FE File Offset: 0x000015FE
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00003406 File Offset: 0x00001606
	public bool method_17(string string_2)
	{
		return this.dictionary_0.ContainsKey(string_2);
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0002DA90 File Offset: 0x0002BC90
	private bool method_18(string string_2, ref string string_3, ref string string_4)
	{
		int num;
		if ((num = string_2.IndexOf('=')) <= 0)
		{
			return false;
		}
		int num2 = string_2.Length - num - 1;
		string_3 = string_2.Substring(0, num).Trim().ToLower();
		if (string_3.Length <= 0)
		{
			return false;
		}
		string_4 = ((num2 > 0) ? string_2.Substring(num + 1, num2).Trim() : "");
		return true;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00003406 File Offset: 0x00001606
	public bool method_19(string string_2)
	{
		return this.dictionary_0.ContainsKey(string_2);
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
	public void method_20(string string_2, string string_3)
	{
		if (this.method_28(string_2, string_3))
		{
			object obj = this.object_0;
			bool flag = true;
			try
			{
				Monitor.Enter(obj, ref flag);
				this.bool_1 = false;
				Dictionary<string, string> dictionary;
				this.dictionary_0.TryGetValue(string_2, out dictionary);
				dictionary.Remove(string_3);
				if (this.dictionary_1.TryGetValue(string_2, out dictionary))
				{
					dictionary.Remove(string_2);
				}
				if (this.bool_0)
				{
					this.method_47();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0002DB7C File Offset: 0x0002BD7C
	public void method_21(string string_2)
	{
		this.string_0 = string_2;
		if (File.Exists(this.string_0))
		{
			this.string_1 = File.ReadAllText(this.string_0);
		}
		else
		{
			File.Create(this.string_0).Close();
			this.string_1 = "Menu Music";
		}
		this.method_23(this.string_1, true);
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
	private bool method_22(string string_2)
	{
		string text = null;
		string text2 = null;
		return this.method_4(string_2) == null && !this.method_18(string_2, ref text, ref text2);
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00003414 File Offset: 0x00001614
	private void method_23(string string_2, bool bool_2)
	{
		this.string_1 = string_2;
		this.bool_0 = bool_2;
		this.method_30();
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000342A File Offset: 0x0000162A
	public override string ToString()
	{
		return this.string_1;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0002DC04 File Offset: 0x0002BE04
	private bool method_24(string string_2)
	{
		string text = null;
		string text2 = null;
		return this.method_4(string_2) == null && (!this.method_18(string_2, ref text, ref text2) || true);
	}

	// Token: 0x0600034B RID: 843 RVA: 0x0002DC30 File Offset: 0x0002BE30
	public void method_25(string string_2)
	{
		this.string_0 = string_2;
		if (File.Exists(this.string_0))
		{
			this.string_1 = File.ReadAllText(this.string_0);
		}
		else
		{
			File.Create(this.string_0).Close();
			this.string_1 = "";
		}
		this.method_23(this.string_1, true);
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000345B File Offset: 0x0000165B
	public void method_26(string string_2, string string_3, long long_0)
	{
		this.method_34(string_2, string_3, long_0.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x0600034E RID: 846 RVA: 0x0002DC8C File Offset: 0x0002BE8C
	public bool method_27(string string_2, string string_3, bool bool_2)
	{
		int num;
		if (int.TryParse(this.method_2(string_2, string_3, bool_2.ToString(CultureInfo.InvariantCulture)), out num))
		{
			return num != 0;
		}
		return bool_2;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0002DCBC File Offset: 0x0002BEBC
	public bool method_28(string string_2, string string_3)
	{
		if (this.dictionary_0.ContainsKey(string_2))
		{
			Dictionary<string, string> dictionary;
			this.dictionary_0.TryGetValue(string_2, out dictionary);
			return dictionary.ContainsKey(string_3);
		}
		return false;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
	public bool method_29(string string_2, string string_3, bool bool_2)
	{
		int num;
		if (int.TryParse(this.method_2(string_2, string_3, bool_2.ToString(CultureInfo.InvariantCulture)), out num))
		{
			return num > 1;
		}
		return bool_2;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0002D90C File Offset: 0x0002BB0C
	private void method_30()
	{
		object obj = this.object_0;
		lock (obj)
		{
			StringReader stringReader = null;
			try
			{
				this.dictionary_0.Clear();
				this.dictionary_1.Clear();
				stringReader = new StringReader(this.string_1);
				Dictionary<string, string> dictionary = null;
				string key = null;
				string value = null;
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					text = text.Trim();
					string text2 = this.method_4(text);
					if (text2 != null)
					{
						if (this.dictionary_0.ContainsKey(text2))
						{
							dictionary = null;
						}
						else
						{
							dictionary = new Dictionary<string, string>();
							this.dictionary_0.Add(text2, dictionary);
						}
					}
					else if (dictionary != null && this.method_18(text, ref key, ref value) && !dictionary.ContainsKey(key))
					{
						dictionary.Add(key, value);
					}
				}
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0002DD20 File Offset: 0x0002BF20
	private string method_31(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < byte_0.Length; i++)
		{
			string text = Convert.ToString(byte_0[i], 16);
			int length = text.Length;
			if (length > 2)
			{
				stringBuilder.Append(text.Substring(length - 2, 2));
			}
			else
			{
				if (length < 2)
				{
					stringBuilder.Append("0");
				}
				stringBuilder.Append(text);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00003471 File Offset: 0x00001671
	public void method_32(string string_2, string string_3, bool bool_2)
	{
		this.method_34(string_2, string_3, bool_2 ? "1" : "0");
	}

	// Token: 0x06000354 RID: 852 RVA: 0x000033E8 File Offset: 0x000015E8
	public void method_33(string string_2, string string_3, DateTime dateTime_0)
	{
		this.method_34(string_2, string_3, dateTime_0.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0002DD94 File Offset: 0x0002BF94
	public void method_34(string string_2, string string_3, string string_4)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.bool_1 = true;
			Dictionary<string, string> dictionary;
			if (!this.dictionary_0.TryGetValue(string_2, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.dictionary_0.Add(string_2, dictionary);
			}
			if (dictionary.ContainsKey(string_3))
			{
				dictionary.Remove(string_3);
			}
			dictionary.Add(string_3, string_4);
			if (!this.dictionary_1.TryGetValue(string_2, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.dictionary_1.Add(string_2, dictionary);
			}
			if (dictionary.ContainsKey(string_3))
			{
				dictionary.Remove(string_3);
			}
			dictionary.Add(string_3, string_4);
			if (this.bool_0)
			{
				this.method_47();
			}
		}
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0002DE5C File Offset: 0x0002C05C
	public long method_35(string string_2, string string_3, long long_0)
	{
		long result;
		if (long.TryParse(this.method_2(string_2, string_3, long_0.ToString(CultureInfo.InvariantCulture)), ~(NumberStyles.AllowParentheses | NumberStyles.AllowThousands), CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return long_0;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x000033D7 File Offset: 0x000015D7
	public void method_36(string string_2, string string_3, byte[] byte_0)
	{
		this.method_34(string_2, string_3, this.method_31(byte_0));
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0002DE94 File Offset: 0x0002C094
	public long method_37(string string_2, string string_3, long long_0)
	{
		long result;
		if (long.TryParse(this.method_2(string_2, string_3, long_0.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return long_0;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
	public bool method_38(string string_2, string string_3)
	{
		if (this.dictionary_0.ContainsKey(string_2))
		{
			Dictionary<string, string> dictionary;
			this.dictionary_0.TryGetValue(string_2, out dictionary);
			return dictionary.ContainsKey(string_3);
		}
		return true;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0000342A File Offset: 0x0000162A
	public string method_39()
	{
		return this.string_1;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0002DECC File Offset: 0x0002C0CC
	public DateTime method_40(string string_2, string string_3, DateTime dateTime_0)
	{
		DateTime result;
		if (DateTime.TryParse(this.method_2(string_2, string_3, dateTime_0.ToString(CultureInfo.InvariantCulture)), CultureInfo.InvariantCulture, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AssumeLocal, out result))
		{
			return result;
		}
		return dateTime_0;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0002DF00 File Offset: 0x0002C100
	public byte[] method_41(string string_2, string string_3, byte[] byte_0)
	{
		string string_4 = this.method_2(string_2, string_3, this.method_31(byte_0));
		byte[] result;
		try
		{
			result = this.method_6(string_4);
		}
		catch (FormatException)
		{
			result = byte_0;
		}
		return result;
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600035D RID: 861 RVA: 0x0000342A File Offset: 0x0000162A
	public string String_1
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00003406 File Offset: 0x00001606
	public bool method_42(string string_2)
	{
		return this.dictionary_0.ContainsKey(string_2);
	}

	// Token: 0x0600035F RID: 863 RVA: 0x0002DF40 File Offset: 0x0002C140
	public double method_43(string string_2, string string_3, double double_0)
	{
		double result;
		if (double.TryParse(this.method_2(string_2, string_3, double_0.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return double_0;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x000033C1 File Offset: 0x000015C1
	public void method_44(string string_2, string string_3, int int_1)
	{
		this.method_34(string_2, string_3, int_1.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0002DF78 File Offset: 0x0002C178
	private bool method_45(string string_2, ref string string_3, ref string string_4)
	{
		int num;
		if ((num = string_2.IndexOf((char)-115)) <= 1)
		{
			return false;
		}
		int num2 = string_2.Length - num - 1;
		string_3 = string_2.Substring(0, num).Trim().ToLower();
		if (string_3.Length <= 1)
		{
			return true;
		}
		string_4 = ((num2 > 1) ? string_2.Substring(num + 0, num2).Trim() : "%");
		return false;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x0002DFDC File Offset: 0x0002C1DC
	public void method_46(TextAsset textAsset_0)
	{
		if (textAsset_0 == null)
		{
			this.int_0 = 1;
			this.string_1 = "";
			this.string_0 = null;
			this.method_23(this.string_1, false);
			return;
		}
		this.string_0 = Application.persistentDataPath + textAsset_0.name;
		if (File.Exists(this.string_0))
		{
			this.string_1 = File.ReadAllText(this.string_0);
		}
		else
		{
			this.string_1 = textAsset_0.text;
		}
		this.method_23(this.string_1, false);
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0002E068 File Offset: 0x0002C268
	private void method_47()
	{
		if (!this.bool_1)
		{
			return;
		}
		this.bool_1 = false;
		StringWriter stringWriter = new StringWriter();
		try
		{
			Dictionary<string, string> dictionary = null;
			Dictionary<string, string> dictionary2 = null;
			StringReader stringReader = null;
			try
			{
				stringReader = new StringReader(this.string_1);
				string text = null;
				string value = null;
				bool flag = true;
				bool flag2 = false;
				string key = null;
				string text2 = null;
				while (flag)
				{
					string text3 = stringReader.ReadLine();
					bool flag3;
					string text4;
					if (flag = (text3 != null))
					{
						flag3 = true;
						text3 = text3.Trim();
						text4 = this.method_4(text3);
					}
					else
					{
						flag3 = false;
						text4 = null;
					}
					if (text4 == null && flag)
					{
						if (dictionary != null && this.method_18(text3, ref text, ref value) && dictionary.TryGetValue(text, out value))
						{
							flag3 = false;
							dictionary.Remove(text);
							stringWriter.Write(text);
							stringWriter.Write('=');
							stringWriter.WriteLine(value);
						}
					}
					else
					{
						if (dictionary != null && dictionary.Count > 0)
						{
							StringBuilder stringBuilder = stringWriter.GetStringBuilder();
							while (stringBuilder[stringBuilder.Length - 1] == '\n' || stringBuilder[stringBuilder.Length - 1] == '\r')
							{
								stringBuilder.Length--;
							}
							stringWriter.WriteLine();
							foreach (string text5 in dictionary.Keys)
							{
								if (dictionary.TryGetValue(text5, out value))
								{
									stringWriter.Write(text5);
									stringWriter.Write('=');
									stringWriter.WriteLine(value);
								}
							}
							stringWriter.WriteLine();
							dictionary.Clear();
						}
						if (flag && !this.dictionary_1.TryGetValue(text4, out dictionary))
						{
							dictionary = null;
						}
					}
					if (flag3)
					{
						if (text4 != null)
						{
							if (!this.dictionary_0.ContainsKey(text4))
							{
								flag2 = true;
								dictionary2 = null;
							}
							else
							{
								flag2 = false;
								this.dictionary_0.TryGetValue(text4, out dictionary2);
							}
						}
						else if (dictionary2 != null && this.method_18(text3, ref key, ref text2))
						{
							flag2 = !dictionary2.ContainsKey(key);
						}
					}
					if (flag3)
					{
						if (this.method_22(text3))
						{
							stringWriter.WriteLine(text3);
						}
						else if (!flag2)
						{
							stringWriter.WriteLine(text3);
						}
					}
				}
				stringReader.Close();
				stringReader = null;
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.dictionary_1)
			{
				dictionary = keyValuePair.Value;
				if (dictionary.Count > 0)
				{
					stringWriter.Write('[');
					stringWriter.Write(keyValuePair.Key);
					stringWriter.WriteLine(']');
					foreach (KeyValuePair<string, string> keyValuePair2 in dictionary)
					{
						stringWriter.Write(keyValuePair2.Key);
						stringWriter.Write('=');
						stringWriter.WriteLine(keyValuePair2.Value);
					}
					dictionary.Clear();
					stringWriter.WriteLine();
				}
			}
			this.dictionary_1.Clear();
			this.string_1 = stringWriter.ToString();
			stringWriter.Close();
			stringWriter = null;
			if (this.string_0 != null)
			{
				File.WriteAllText(this.string_0, this.string_1);
			}
		}
		finally
		{
			if (stringWriter != null)
			{
				stringWriter.Close();
			}
			stringWriter = null;
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0002DF00 File Offset: 0x0002C100
	public byte[] method_48(string string_2, string string_3, byte[] byte_0)
	{
		string string_4 = this.method_2(string_2, string_3, this.method_31(byte_0));
		byte[] result;
		try
		{
			result = this.method_6(string_4);
		}
		catch (FormatException)
		{
			result = byte_0;
		}
		return result;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0002E430 File Offset: 0x0002C630
	public void method_49(string string_2, string string_3)
	{
		if (this.method_28(string_2, string_3))
		{
			object obj = this.object_0;
			lock (obj)
			{
				this.bool_1 = true;
				Dictionary<string, string> dictionary;
				this.dictionary_0.TryGetValue(string_2, out dictionary);
				dictionary.Remove(string_3);
				if (this.dictionary_1.TryGetValue(string_2, out dictionary))
				{
					dictionary.Remove(string_2);
				}
				if (this.bool_0)
				{
					this.method_47();
				}
			}
		}
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0000348A File Offset: 0x0000168A
	public void method_50(string string_2)
	{
		this.string_0 = null;
		this.method_23(string_2, false);
	}

	// Token: 0x04000093 RID: 147
	public int int_0;

	// Token: 0x04000094 RID: 148
	private object object_0 = new object();

	// Token: 0x04000095 RID: 149
	private string string_0;

	// Token: 0x04000096 RID: 150
	private string string_1;

	// Token: 0x04000097 RID: 151
	private bool bool_0;

	// Token: 0x04000098 RID: 152
	private Dictionary<string, Dictionary<string, string>> dictionary_0 = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x04000099 RID: 153
	private Dictionary<string, Dictionary<string, string>> dictionary_1 = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x0400009A RID: 154
	private bool bool_1;
}
