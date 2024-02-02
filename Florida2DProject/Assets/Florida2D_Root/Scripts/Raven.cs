using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raven : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Player movement;



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<Player>();
    }

    private void LateUpdate()
    {

    }
}
