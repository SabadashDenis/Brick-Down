using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;
    [SerializeField]
    private Vector3[] positions;
    [SerializeField]
    private float[] hp;
    [SerializeField]
    private GameObject textPrefab;

    void Start()
    {
        //Instantiate(gameObject.AddComponent<Cube>());

        Cube[] Cube = {
            new Cube(cubePrefab, positions[0], hp[0], textPrefab),
            new Cube(cubePrefab, positions[1], hp[1], textPrefab),
            new Cube(cubePrefab, positions[2], hp[2], textPrefab),
            new Cube(cubePrefab, positions[3], hp[3], textPrefab),
            new Cube(cubePrefab, positions[4], hp[4], textPrefab),
    };

    }

    void Update()
    {
        
    }
}
