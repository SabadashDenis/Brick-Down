using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePref;
    [SerializeField]
    private GameObject textPref;
    private Cube cube;
    private Shoot shoot;

    private void Start()
    {
        cube = cubePref.GetComponent<Cube>();
        shoot = new Shoot();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            cube.Health -= shoot.Damage;
            cube.HpText.GetComponent<TextMesh>().text = Convert.ToString(cube.Health);
            DestroyCube();
        }
    }

    private void DestroyCube()
    {
        if (cube.Health <= 0)
        {
            Destroy(cube.gameObject);
            Destroy(cube.HpText.gameObject);
        }
    }
}
