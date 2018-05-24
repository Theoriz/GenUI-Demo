using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

    public int NombreInt;

    public float NombreFloat;

    public string MyString;

    public bool Rotate;

    public int IntSlider;

    public float Speed;
    
    public Vector3 Pos;

    public Color CubeColor;

    public void SetColor(Color col)
    {
        CubeColor = col;
        GetComponent<Renderer>().material.color = CubeColor;
    }

    //// Use this for initialization
    //void Start () {
    //    GetComponent<Renderer>().material.color = CubeColor;
    //}
	
	// Update is called once per frame
	void Update () {
        if (Rotate)
            transform.Rotate(new Vector3(0, 1, 0) * Speed);
	}
}
