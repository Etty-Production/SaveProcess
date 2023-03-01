using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SER : MonoBehaviour
{
    public MonoBehaviour SFR;
    public bool Shoot;
    private void Update()
    {
        if (Shoot)
        {
            SFR.GetComponent<ShootInPerson>().Shoot = true;
            Shoot = false;
        }
    }
}
