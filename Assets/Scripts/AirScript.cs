using UnityEngine;
using System.Collections;

public class AirScript : MonoBehaviour {

	// Use this for initialization
	public Transform sightStart;
	public Transform sightEnd;

	void Start () {
	
	}
	
	void CastRay(){
		Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
	}

	// Update is called once per frame
	void Update () {
		CastRay();
	}
}
