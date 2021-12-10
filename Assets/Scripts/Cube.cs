using System;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private GameObject cubeObject;

    private Vector3 position;

    private float health;

    private GameObject hpText;

    public GameObject CubeObject
    {
        get { return cubeObject; }
        set { cubeObject = value; }
    }

    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    public GameObject HpText
    {
        get { return hpText; }
        set { hpText = value; }
    }

    public Vector3 Position
    {
        get { return position; }
        set { position = value; }
    }


    public Cube(GameObject cubeObj, Vector3 pos, float hp, GameObject txt)
    {
        cubeObject = cubeObj;
        position = pos;
        health = hp;
        hpText = txt;
        hpText = Instantiate(hpText, position + Vector3.up, hpText.transform.rotation);
        hpText.GetComponent<TextMesh>().text = Convert.ToString(health);
        CreateCube();
    }

    public void CreateCube()
    {
        hpText.GetComponent<TextMesh>().text = Convert.ToString(health);

        GameObject cubee = Instantiate(cubeObject, position, Quaternion.identity);
        cubee.AddComponent<Cube>();
        Cube c = cubee.GetComponent<Cube>();
        c.health = health;
        c.hpText = hpText;
        c.position = position;
        Debug.Log(hpText.gameObject.name);
    }

}
