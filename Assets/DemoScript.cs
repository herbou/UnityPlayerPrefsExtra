using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

//[System.Serializable] is not required,
//I used it just to see the shape object in the inspector.
[System.Serializable]
public class Shape
{
	public int points = 0;
	public float size = 0f;
	public Vector2 pos = Vector2.zero;
}

public class DemoScript : MonoBehaviour
{
	public Shape shape;

	void Start ()
	{
		//Load shape object from PlayerPrefs
		shape = PlayerPrefsExtra.GetObject<Shape> ("myShape", new Shape ());

		//Update shape data
		shape.points++;
		shape.size += 0.5f;
		shape.pos += Vector2.up * 0.4f;

		//Save shape object to PlayerPrefs
		PlayerPrefsExtra.SetObject ("myShape", shape);

		//Now everytime you hit play you will see shape data increasing in the inspector
	}
}


