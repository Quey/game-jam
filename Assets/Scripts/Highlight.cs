using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

    private float blueMultiply = 3.50f;
    private float redGreenMultiply = 0.50f;
 	SpriteRenderer rend;
    private Color originalColor;
 
    private void Start()
    {
    	rend = GetComponent<SpriteRenderer>();
        originalColor = rend.color;
    }
 
    void OnMouseEnter()
    {
        AddHighlight();
    }
 
    void OnMouseExit()
    {
        RemoveHighlight();
    }

    void onMouseDown(){
    	//RemoveHighlight();
//    	rend.material.color = Color.green;
    }
 
    private void  AddHighlight()
    {
        float red = originalColor.r * redGreenMultiply;
        float blue = originalColor.b * blueMultiply;
        float green = originalColor.g * redGreenMultiply;
 
        rend.color = new Color(red, green, blue);
    }
 
    private void RemoveHighlight()
    {
        rend.color = originalColor;
    }
}