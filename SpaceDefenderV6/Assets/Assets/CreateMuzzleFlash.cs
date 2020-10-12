using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMuzzleFlash : MonoBehaviour
{
    private PlayerController PC;
    public Transform MuzzleFlash;
    public Transform MuzzleFlashPoint;

    // Start is called before the first frame update
    void Start()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.IsShooting)
        {
            Instantiate(MuzzleFlash, MuzzleFlashPoint.position, MuzzleFlashPoint.rotation);
        }
    }
}
