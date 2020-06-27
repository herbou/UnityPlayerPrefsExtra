# Unity PlayerPrefsExtra
Unity PlayerPrefsExtra gives you more types and complexe data types such as :
Vectors, Bool, Colors, Lists, ...
and it uses the Unity's PlayerPrefs behind the scene.

# ⁉ How to use :
Use the same syntaxe as PlayerPrefs uses.

// Get

- myVar = PlayerPrefsExtra.GetType(key);

// Get with default value

- myVat = PlayerPrefsExtra.GetType(key, defaultValueIfNotExist);

// Set

- PlayerPrefsExtra.SetType(key, myVar);
# ⬛ Booleans :
```c#
//Load
bool b = PlayerPrefsExtra.GetBool("mybool", false);

//Update (flip value)
b = !b;

//Save
PlayerPrefsExtra.SetBool("mybool", b);
```

# ⬛ Vectors ( Vector2, Vector3, and Vector4 ):
```c#
//Load
Vector2 v = PlayerPrefsExtra.GetVector2("myV2", Vector2.zero);

//Update
v+=Vector2.one;

//Save
PlayerPrefsExtra.SetVector2("myV2", v);
```

# ⬛ Colors :
```c#
// Get color
Color c = PlayerPrefsExtra.GetColor("Col");

// Set color
PlayerPrefsExtra.SetColor("Col", Color.red);
```
# ⬛ Quaternions :
```c#
// Get Quaternion
Quaternion qua = PlayerPrefsExtra.GetQuaternion("q");

//Set Quaternion
PlayerPrefsExtra.SetQuaternion("q", qua);
```

# ⬛ Lists :
```c#
// Get List
List<float> list = PlayerPrefsExtra.GetList<float>("myList", new List<float>());

// Add data to List
list.Add(Random.Range(100,900);

// Save List
PlayerPrefsExtra.SetList("myList", list);
```

# ⬛ Objects :
```c#
//Class
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
