using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum CustomEnum
{
    Value1, Value2, Value3
}

public class CubeBehaviour : MonoBehaviour {

    private float _property = -1;
    public float Property
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

    public CustomEnum customEnum;

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
            _color = GetComponent<Renderer>().material.color;
            return _color;
        }
        set
        {
            _color = value;
            GetComponent<Renderer>().material.color = _color;
        }
    }

    private Vector3 startPosition;

    public void SetColorBlue()
    {
        CubeColor = Color.blue;
    }

    public void SetColor(Color col)
    {
        CubeColor = col;
    }

    private void Awake()
    {
        startPosition = transform.localPosition;
    }

    void Update () {
        NombreFloat = Mathf.Sin(Time.time);

        if (Rotate)
            transform.Rotate(new Vector3(0, 1, 0) * Speed);
	}
}
