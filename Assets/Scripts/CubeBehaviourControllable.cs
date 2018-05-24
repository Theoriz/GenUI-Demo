using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourControllable : Controllable
{
    public CubeBehaviour MyCubeBehaviour;

    [OSCProperty]
    public int NombreInt;

    [OSCProperty]
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
    public Vector3 Pos;

    [OSCProperty]
    public Color CubeColor;

    [OSCMethod]
    public void SetColor(Color col)
    {
        MyCubeBehaviour.SetColor(col);
    }

    [OSCMethod]
    public void SetColorRed()
    {
        MyCubeBehaviour.SetColor(Color.red);
    }

    [OSCMethod]
    public void SetColorWhite()
    {
        MyCubeBehaviour.SetColor(Color.white);
    }

    public override void Awake()
    {
        debug = false;
        if (MyCubeBehaviour == null)
        {
            var scripts = FindObjectsOfType<CubeBehaviour>();
            if(scripts.Length >=1 )
                Debug.LogError("Too many CubeBehaviour script, please set the good one manually");
            if (scripts.Length == 1)
                MyCubeBehaviour = scripts[0];

        }

        if (MyCubeBehaviour == null)
        {
            Debug.LogWarning("Can't find CubeBehaviour script to control !");
            return;
        }
        TargetScript = MyCubeBehaviour;
        base.Awake();
    }

    public override void DataLoaded()
    {
        base.DataLoaded();
        MyCubeBehaviour.SetColor(CubeColor);
    }

    //public override void OnScriptValueChanged(string name)
    //{
    //    NombreInt = MyCubeBehaviour.NombreInt;
    //    NombreFloat = MyCubeBehaviour.NombreFloat;
    //    MyString = MyCubeBehaviour.MyString;
    //    Rotate = MyCubeBehaviour.Rotate;
    //    IntSlider = MyCubeBehaviour.IntSlider;
    //    Speed = MyCubeBehaviour.Speed;
    //    Pos = MyCubeBehaviour.Pos;
    //    CubeColor = MyCubeBehaviour.CubeColor;
    //}

    //public override void OnUiValueChanged(string name)
    //{
    //    MyCubeBehaviour.NombreInt = NombreInt;
    //    MyCubeBehaviour.NombreFloat = NombreFloat;
    //    MyCubeBehaviour.MyString = MyString;
    //    MyCubeBehaviour.Rotate = Rotate;
    //    MyCubeBehaviour.IntSlider = IntSlider;
    //    MyCubeBehaviour.Speed = Speed;
    //    MyCubeBehaviour.Pos = Pos;
    //    MyCubeBehaviour.CubeColor = CubeColor;
    //}
}
