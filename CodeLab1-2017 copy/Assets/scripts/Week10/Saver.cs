using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class Saver : MonoBehaviour {
	
	Vector3 pos;
	Vector3 scale;

	private const string POS_X = "xpos";
	private const string POS_Y = "ypos";
	private const string POS_Z = "zpos";

	// Use this for initialization
	void Start ()
	{
		
		GameObject[] asteroids = GameObject.FindGameObjectsWithTag ("Asteroid");
		AsteroidData ad = new AsteroidData (pos, scale);
		JSONArray jArray = new JSONArray();

		for (int i = 0; i < asteroids.Length; i++) {
			pos = asteroids [i].transform.position;
			JSONNode testNode = new JSONClass ();
			testNode [POS_X].AsFloat = pos.x;
			testNode [POS_Y].AsFloat = pos.y;
			testNode [POS_Z].AsFloat = pos.z;
			jArray.Add (testNode);
		}

		//ad.Save ("Asteroid.txt", jArray);
		UtilScript.WriteJSONtoFile(Application.dataPath, "Asteroid.txt", jArray);

	}

	// Update is called once per frame
	void Update () {

	}
}