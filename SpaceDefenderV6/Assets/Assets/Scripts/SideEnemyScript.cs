using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideEnemyScript : MonoBehaviour
{
    public Transform[] Spawners;
    private Transform TheSpawner;
    public float Speed;
    private float RandSpawner;

    // Start is called before the first frame update
    void Start()
    {
        RandSpawner = Random.Range(0, 100);

        if (RandSpawner < 50)
        {
            TheSpawner = Spawners[0];
        }
        else if (RandSpawner > 50)
        {
            TheSpawner = Spawners[1];
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(TheSpawner.rotation.x, TheSpawner.rotation.y, TheSpawner.rotation.z) * Speed * Time.deltaTime);
    }
}
