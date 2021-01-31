using UnityEngine;
using System.Collections.Generic;

public class Demo2 : MonoBehaviour {
	//Data
	public List<int> listInt;

	void Start ( ) {
		//Load data
		listInt = PlayerPrefsExtra.GetList<int> ( "listInt", new List<int> ( ) );
	}

	void Update ( ) {
		//Update & save data
		if ( Input.GetMouseButtonUp ( 0 ) ) {
			listInt.Add ( Random.Range ( 0, 100 ) );
			PlayerPrefsExtra.SetList ( "listInt", listInt );
		}
	}
}
