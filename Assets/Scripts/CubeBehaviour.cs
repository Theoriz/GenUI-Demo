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
    
    public Vector3 PositionOffset;

    public Color CubeColor;

    private Vector3 startPosition;


    public void SetColor(Color col)
    {
        CubeColor = col;
        GetComponent<Renderer>().material.color = CubeColor;
    }

    private void Start()
    {
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update () {
        NombreFloat = Mathf.Sin(Time.time);
        transform.localPosition = startPosition  + PositionOffset;
        SetColor(CubeColor);
        if (Rotate)
            transform.Rotate(new Vector3(0, 1, 0) * Speed);
	}
}
