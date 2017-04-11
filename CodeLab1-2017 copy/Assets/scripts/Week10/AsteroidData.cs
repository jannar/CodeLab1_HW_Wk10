using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class AsteroidData : MonoBehaviour {

	public Vector3 position;
	public Vector3 scale;

	GameObject[] spheres;

	Vector3[] transforms;

	private const string POS_X = "xpos";
	private const string POS_Y = "ypos";
	private const string POS_Z = "zpos";

	public AsteroidData(string fileName){
		
		JSONArray jason = UtilScript.ReadJSONFromFile(Application.dataPath, fileName) as JSONArray;
		Debug.Log (jason);

		for (int i = 0; i < jason.Count; i++) {
			position = new Vector3(jason[i][POS_X].AsFloat, jason[i][POS_Y].AsFloat, jason[i][POS_Z].AsFloat);
			GameObject asteroid = Instantiate (Resources.Load ("Prefabs/Sphere", typeof(GameObject))) as GameObject;
			asteroid.transform.position = position;
			//sphere[i].transform.position= new Vector3(jason[i][POS_X].AsFloat, jason[i][POS_Y].AsFloat, jason[i][POS_Z].AsFloat);
			//jason[i] = ToJSON();
			Debug.Log(position);
		}

		//GameObject spheres[] = GameObject.FindGameObjectsWithTag("Asteroid");

//		for (int i = 0; i < jason.Count; i++) {
//
//			position = new Vector3(jason[i][POS_X].AsFloat, jason[i][POS_Y].AsFloat, jason[i][POS_Z].AsFloat);
//
//		}
	}

	public AsteroidData(Vector3 position, Vector3 scale){
		
		this.position = position;
		this.scale = scale;
	}

	public JSONNode ToJSON(){
		
		JSONNode json = new JSONClass();
		json[POS_X].AsFloat = position.x;
		json[POS_Y].AsFloat = position.y;
		json[POS_Z].AsFloat = position.z;
		return json;

	}

	public void Save(string fileName, JSONNode json){

		Debug.Log (json);
		//UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
	}
}
