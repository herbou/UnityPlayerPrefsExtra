using UnityEngine;

[System.Serializable] public class Shape {
	public int points = 0;
	public Vector2 pos = Vector2.zero;
}

public class Demo3 : MonoBehaviour {
	//Data
	public Shape myShape;

	void Start ( ) {
		//Load data
		myShape = PlayerPrefsExtra.GetObject<Shape> ( "MyShape", new Shape ( ) );
	}

	void Update ( ) {
		if ( Input.GetMouseButtonUp ( 0 ) ) {
			//Update & save data
			myShape.points += 3;
			myShape.pos = myShape.pos + Vector2.one;

			PlayerPrefsExtra.SetObject ( "MyShape", myShape );
		}
	}
}
