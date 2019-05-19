using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

    private int _property = -1;
    public int Property
    {
        get
        {
            return _property;
        }

        set
        {
            _property = value;
        }
    }

    public int NombreInt;

    public float NombreFloat;

    public string MyString;

    public bool Rotate;

    public int IntSlider;

    public float Speed;

    private Vector3 _positionOffset;
    public Vector3 PositionOffset {
        get
        {
            return _positionOffset;
        }
        set
        {
            _positionOffset = value;
            transform.localPosition = startPosition + _positionOffset;
        }
    }

    private Color _color;
    public Color CubeColor {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
            GetComponent<Renderer>().material.color = _color;
        }
    }

    private Vector3 startPosition;


    public void SetColor(Color col)
    {
        CubeColor = col;
    }

    private void Start()
    {
        startPosition = transform.localPosition;
    }

    void Update () {
        NombreFloat = Mathf.Sin(Time.time);

        if (Rotate)
            transform.Rotate(new Vector3(0, 1, 0) * Speed);
	}
}
