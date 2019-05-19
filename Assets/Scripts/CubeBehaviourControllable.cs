using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourControllable : Controllable
{
    [Header("Exposed properties")]

    [OSCProperty]
    public int Property;

    [OSCProperty]
    public int NombreInt;

    [OSCProperty(isInteractible = false)]
    public float NombreFloat;

    [OSCProperty]
    public string MyString;

    [OSCProperty]
    public bool Rotate;

    [OSCProperty]
    [Range(0, 10)]
    public int IntSlider;

    [OSCProperty]
    [Range(0,10)]
    public float Speed;

    [OSCProperty]
    public Vector3 PositionOffset;

    [OSCProperty]
    public Color CubeColor;

    [OSCMethod]
    public void SetColor(Color col)
    {
        ((CubeBehaviour)TargetScript).SetColor(col);
    }

    [OSCMethod]
    public void SetColorRed()
    {
        ((CubeBehaviour)TargetScript).SetColor(Color.red);
    }

    [OSCMethod]
    public void SetColorWhite()
    {
        ((CubeBehaviour)TargetScript).SetColor(Color.white);
    }

    public override void DataLoaded()
    {
        base.DataLoaded();
        ((CubeBehaviour)TargetScript).SetColor(CubeColor);
    }
}
