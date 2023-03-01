using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageForPerson : MonoBehaviour
{
    [SerializeField] private float Hp;
    // Start is called before the first frame update
    public void Damage(float Damage)
    {
        Hp = Hp - Damage;
        if (Hp < 1)
        {
            Destroy(gameObject);
        }
    }
}
