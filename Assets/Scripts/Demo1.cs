using UnityEngine;

public class Demo1 : MonoBehaviour {
	//Data
	public Vector2 pos;
	public Color col;
	public Quaternion rot;

	void Start ( ) {
		//Load data
		pos = PlayerPrefsExtra.GetVector2 ( "Pos", Vector2.zero );
		col = PlayerPrefsExtra.GetColor ( "Col", Color.white );
		rot = PlayerPrefsExtra.GetQuaternion ( "Rot", Quaternion.identity );
	}

	void Update ( ) {
		//Update data only on mouse click
		if ( Input.GetMouseButtonUp ( 0 ) ) {
			//Update pos & save data:
			pos = new Vector2 ( pos.x + 1f, pos.y + 5f );
			PlayerPrefsExtra.SetVector2 ( "Pos", pos );

			//Update col & save
			col = new Color (
				Random.Range ( 0f, 1f ),
				Random.Range ( 0f, 1f ),
				Random.Range ( 0f, 1f ),
				1f
			);
			PlayerPrefsExtra.SetColor ( "Col", col );

			//Update & save rot
			rot = new Quaternion (
				rot.x + 1f,
				rot.y + 5f,
				rot.z + 10f,
				rot.w + 15f
			);
			PlayerPrefsExtra.SetQuaternion ( "Rot", rot );
		}

	}
}
