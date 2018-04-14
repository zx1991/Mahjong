using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startGame : MonoBehaviour {

	public static List<GameObject> majs = new List<GameObject>();
	public static List<GameObject> Playmajs = new List<GameObject> ();
	public Transform t;

	// Use this for initialization
	void Start () {
		Object [] all = Resources.LoadAll ("Mahjong", typeof( GameObject));
		foreach (GameObject a  in all) {
			majs.Add (a);
		}

		//Sorting list and check it count
		if (majs.Count > 0) {
			majs.Sort (delegate(GameObject a, GameObject b) {
				return (a.GetComponent<majong> ().index).CompareTo (b.GetComponent<majong> ().index);
			});
		}

		 


		SetUp ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetUp(){
		List<GameObject> tempList = new List<GameObject> ();
		Playmajs.Clear ();
		for (int i = 0; i < 4; i++) {
			tempList.AddRange (majs);
		}

		for (int i = 0; i < 120; i++) {

			int index = Random.Range (0, 120 - i);

			Playmajs.Add (tempList [index]);
			tempList.RemoveAt (index);

		}

		Vector3 pos = t.position;

		foreach (GameObject a in Playmajs) {



			GameObject temp =  Instantiate (a, pos, t.rotation);
			temp.transform.localScale = t.localScale;
			pos.x += 0.03f;

		}

	}
}
