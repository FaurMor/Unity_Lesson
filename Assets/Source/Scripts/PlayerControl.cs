using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{
    private const string Vertical = "Vertical";
    private const string Horizontal = "Horizontal";

    [SerializeField, Min(0.1f)] private float _speed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xVal = Input.GetAxis(Horizontal);
        float zVal = Input.GetAxis(Vertical);

        transform.Translate(xVal, 0f, zVal);
    }
}
