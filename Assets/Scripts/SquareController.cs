using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer _renderer;

    void Start()
    {
        _renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Time.deltaTime * 100);

        _renderer.color = new Color(
            (Mathf.Sin(Time.time * 2) + 1) / 2,
            (Mathf.Cos(Time.time * 3) + 1) / 2,
            (Mathf.Sin(Time.time * 5) + 1) / 2);
    }
}