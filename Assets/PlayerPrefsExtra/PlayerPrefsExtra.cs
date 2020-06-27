using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// PlayerPrefsExtra gives you more possibilities like saving complex types :
/// Vectors, Colors, Quaternions, Lists, and Your Pre defined types (Object) [classes or structs].
/// 
/// Developed by Hamza Herbou
/// --------------------------------------------------------------------------------------------------------
/// Email  : hamza95herbou@gmail.com
/// GITHUB : https://github.com/herbou/
/// 
/// </summary>

public static class PlayerPrefsExtra
{
	#region Bool -----------------------------------------------------------------------------------------

	public static bool GetBool (string key)
	{
		return (PlayerPrefs.GetInt (key, 0) == 1) ? true : false;
	}

	public static bool GetBool (string key, bool defaultValue)
	{
		return (PlayerPrefs.GetInt (key, (defaultValue ? 1 : 0)) == 1) ? true : false;
	}

	public static void SetBool (string key, bool value)
	{
		PlayerPrefs.SetInt (key, (value ? 1 : 0));
	}

	#endregion

	#region Vector 2 -----------------------------------------------------------------------------------------

	public static Vector2 GetVector2 (string key)
	{
		return Get<Vector2> (key, Vector2.zero);
	}

	public static Vector2 GetVector2 (string key, Vector2 defaultValue)
	{
		return Get<Vector2> (key, defaultValue);
	}

	public static void SetVector2 (string key, Vector2 value)
	{
		Set (key, value);
	}

	#endregion

	#region Vector 3 -----------------------------------------------------------------------------------------

	public static Vector3 GetVector3 (string key)
	{
		return Get<Vector3> (key, Vector3.zero);
	}

	public static Vector3 GetVector3 (string key, Vector3 defaultValue)
	{
		return Get<Vector3> (key, defaultValue);
	}

	public static void SetVector3 (string key, Vector3 value)
	{
		Set (key, value);
	}

	#endregion

	#region Vector 4 -----------------------------------------------------------------------------------------

	public static Vector4 GetVector4 (string key)
	{
		return Get<Vector4> (key, Vector4.zero);
	}

	public static Vector4 GetVector4 (string key, Vector4 defaultValue)
	{
		return Get<Vector4> (key, defaultValue);
	}

	public static void SetVector4 (string key, Vector4 value)
	{
		Set (key, value);
	}

	#endregion

	#region Color -----------------------------------------------------------------------------------------

	public static Color GetColor (string key)
	{
		return Get<Color> (key, new Color (0f, 0f, 0f, 0f));
	}

	public static Color GetColor (string key, Color defaultValue)
	{
		return Get<Color> (key, defaultValue);
	}

	public static void SetColor (string key, Color value)
	{
		Set (key, value);
	}

	#endregion

	#region Quaternion -----------------------------------------------------------------------------------------

	public static Quaternion GetQuaternion (string key)
	{
		return Get<Quaternion> (key, Quaternion.identity);
	}

	public static Quaternion GetQuaternion (string key, Quaternion defaultValue)
	{
		return Get<Quaternion> (key, defaultValue);
	}

	public static void SetQuaternion (string key, Quaternion value)
	{
		Set (key, value);
	}

	#endregion

	#region List <T> -----------------------------------------------------------------------------------------

	public class ListWrapper<T>
	{
		public List<T> list = new List<T> ();
	}

	public static List<T> GetList <T> (string key)
	{
		return Get<ListWrapper<T>> (key, new ListWrapper<T> ()).list;
	}

	public static List<T> GetList <T> (string key, List<T> defaultValue)
	{
		return Get<ListWrapper<T>> (key, new ListWrapper<T> { list = defaultValue }).list;
	}

	public static void SetList <T> (string key, List<T> value)
	{
		Set (key, new ListWrapper<T> { list = value });
	}

	#endregion


	#region Object -----------------------------------------------------------------------------------------

	public static T GetObject <T> (string key)
	{
		return Get<T> (key, default(T));
	}

	public static T GetObject <T> (string key, T defaultValue)
	{
		return Get<T> (key, defaultValue);
	}

	public static void SetObject <T> (string key, T value)
	{
		Set (key, value);
	}

	#endregion

	//Generic template ---------------------------------------------------------------------------------------

	static T Get<T> (string key, T defaultValue)
	{
		return JsonUtility.FromJson <T> (PlayerPrefs.GetString (key, JsonUtility.ToJson (defaultValue)));
	}

	static void Set<T> (string key, T value)
	{
		PlayerPrefs.SetString (key, JsonUtility.ToJson (value));
	}

}
