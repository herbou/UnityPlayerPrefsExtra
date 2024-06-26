# Unity PlayerPrefsExtra
### Video tutorial : [https://youtu.be/wqRYdFcfiVw](https://youtu.be/wqRYdFcfiVw)
![Video thumbnail](https://img.youtube.com/vi/wqRYdFcfiVw/0.jpg)


Unity PlayerPrefsExtra gives you the ability to save more complexe data types such as :
Vectors, Bool, Colors, Lists, ...
and it uses the Unity's PlayerPrefs under the hood.

# ⁉ How to use :
Use the same syntaxe as PlayerPrefs.


## ■ Booleans :
```c#
//Load
bool b = PlayerPrefsExtra.GetBool("mybool", false);

//Update (flip value)
b = !b;

//Save
PlayerPrefsExtra.SetBool("mybool", b);
```

<br />

## ■ Vectors ( Vector2, Vector3, and Vector4 ):
```c#
//Load
Vector2 v = PlayerPrefsExtra.GetVector2("myV2", Vector2.zero);

//Update
v+=Vector2.one;

//Save
PlayerPrefsExtra.SetVector2("myV2", v);
```

<br />

## ■ Colors :
```c#
// Get color
Color c = PlayerPrefsExtra.GetColor("Col");

// Set color
PlayerPrefsExtra.SetColor("Col", Color.red);
```

<br />

## ■ Quaternions :
```c#
// Get Quaternion
Quaternion qua = PlayerPrefsExtra.GetQuaternion("q");

//Set Quaternion
PlayerPrefsExtra.SetQuaternion("q", qua);
```

<br />

## ■ Lists :
```c#
// Get List
List<float> list = PlayerPrefsExtra.GetList<float>("myList", new List<float>());

// Add data to List
list.Add(Random.Range(100,900);

// Save List
PlayerPrefsExtra.SetList("myList", list);
```

<br />

## ■ Objects :
```c#
//Class
[System.Serializable]
public class Shape{
	public int totalPoints = 3;
	public float strokeWidth = 0f;
	public List<Vector3> points = new List<Vector3>();
}
```
```c#
// Get object
Shape s = PlayerPrefsExtra.GetObject<Shape>("myShape", new Shape());

// Update object data
s.strokeWidth++;
s.points.Add(Vector3.one*Random.Range(0f,3f));

// Save object
PlayerPrefsExtra.SetObject("myShape", s);
```

<br />

## ■ Delete All Keys (both PlayerPrefs & PlayerPrefsExtra) :
use PlayerPrefs instead of PlayerPrefsExtra
```c#
PlayerPrefs.DeleteAll();
```

<br />

## ■ Delete one key :
use PlayerPrefs instead of PlayerPrefsExtra
```c#
PlayerPrefs.DeleteKey("Key");
```

<br />

## ■ Check key existance :
use PlayerPrefs instead of PlayerPrefsExtra
```c#
PlayerPrefs.HasKey("Key");
```


<br><br>
<br>
## ❤️ Donate  
<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>
