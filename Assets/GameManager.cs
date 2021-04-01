using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    private bool isRed = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        var render = cube.GetComponent<Renderer>();
        if(isRed){
            render.material.SetColor("_Color", Color.white);
        } else {
            render.material.SetColor("_Color", Color.red);
        }

    }

    public void ScaleObject()
    {


    }
    
}
