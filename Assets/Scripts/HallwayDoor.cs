using UnityEngine;
using System.Collections;

public class HallwayDoor : MonoBehaviour {

	bool doorClosed;
	BoxCollider2D col;

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(0, 8);
		doorClosed = true;
		col = GetComponent<BoxCollider2D>();
	}

    void OnMouseOver()
    {
    	if(Input.GetMouseButtonDown(0)){
    		if(doorClosed){
    			gameObject.layer = 8;
    			doorClosed = false;
    		}
    		else{
    			doorClosed = true;
    			gameObject.layer = 0;
    		}
    	}
    }

	// Update is called once per frame
	void Update () {


	}
}
