using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour 
{
    [SerializeField]
    float speed = 10.0f;

	void Start () 
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;	
	}
}
