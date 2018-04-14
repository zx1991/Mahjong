using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour {

	static Dictionary<int, string> cardtype = new Dictionary<int, string>(){{0,"万"},{1,"条"},{2,"同"}};

	public int[] cards = new int[36];
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
