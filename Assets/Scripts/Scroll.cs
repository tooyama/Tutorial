﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour 
{
    [SerializeField]
    Transform pos;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            other.transform.position = new Vector2(pos.position.x, other.transform.position.y);
        }
    }
}
