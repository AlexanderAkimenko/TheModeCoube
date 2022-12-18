using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollor : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int randomColor;
    
    // Start is called before the first frame update
    void Start()
    {
        
   
    }

    // Update is called once per frame
    void Update()
    {

        RandomColor();
       
    }
    void RandomColor()
    {
        Material material = Renderer.material;
        randomColor = Random.Range(0, 4);
        switch (randomColor)
        {
            case 0:
                material.color = Color.blue;
                break;
            case 1:
                material.color = Color.white;
                break;
            case 2:
                material.color = Color.red;
                break;
            case 3:
                material.color = Color.yellow;
                break;
        }
            
    }
}
