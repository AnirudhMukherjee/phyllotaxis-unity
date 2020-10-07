using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phyl : MonoBehaviour
{
    public float r;
    public int n;
    public int c = 2;
    public float phi;
    float x, y;

    public GameObject prefab;
    
    private void Update()
    {
        CalculateConstants();
        x = r * Mathf.Cos(phi * Mathf.PI/180);
        y = r * Mathf.Sin(phi * Mathf.PI/180);
        Debug.Log(x +" " + y);
        prefab = Instantiate(prefab, new Vector3(x/15, y/15, 0), Quaternion.identity);
        prefab.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        Renderer rend = prefab.transform.GetComponent<Renderer>();
        rend.material.SetColor("_BaseColor", new Color((float)((n % 256) / 256.0f), (float)(((n*2) % 256) / 256.0f), (float)(((n /2) % 256) / 256.0f)));
        
    }

    void CalculateConstants()
    {
        phi = (float)n * 137.5f;
        r = (float)c * Mathf.Sqrt(n);
        n++;
    }
}
