using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundSroll : MonoBehaviour
{
    public Renderer meshRender;
    private float speed = 0.1f;

    void Update()
    {
        Vector2 offset = meshRender.material.mainTextureOffset;
        offset += new Vector2(0, speed * Time.deltaTime);
        meshRender.material.mainTextureOffset = offset;
    }
}
