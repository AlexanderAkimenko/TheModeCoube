using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  
   
    private int randomValueRotation;
    private int randomValuePosition;
    private int randomValueSize = 1;
  

    //Vector3
    private Vector3 currentRotation;
    




    private void Start()
    {
      
    }
    private void Update()
    {
        CreateRandomValue(randomValueRotation,0,4);
        CreateRandomValue(randomValuePosition,0,4);
    
        RandomSize();
        RandomRotation();
        RandomPosition();
        
    }
    private void FixedUpdate()
    {
       
    }



    int CreateRandomValue(int value,int a,int b)
    {
      
        value = Random.Range(a, b);
        
        return value;
    }
    
   void RandomPosition()
    {
        if (transform.position.y > 0.5f)
        {
            switch (randomValuePosition)
            {
                case 0:

                    transform.Translate(Vector3.right * 1 * Time.fixedDeltaTime);
                    break;
                case 1:

                    transform.Translate(Vector3.left * 1 * Time.fixedDeltaTime);
                    break;
                case 2:

                    transform.Translate(Vector3.up * 1 * Time.fixedDeltaTime);
                    break;
                case 3:

                    transform.Translate(Vector3.down * 1 * Time.fixedDeltaTime);
                    break;
                default:
                    transform.Translate(Vector3.zero);
                    break;

            }
        }
       
   
    }
       
    
   void RandomRotation()
    {
        switch (randomValueRotation)
        {
            case 0:
                currentRotation = new Vector3(1.0f, -1.0f, 0);
                transform.Rotate(currentRotation);
                break;
            case 1:
                currentRotation = new Vector3(0, 1.0f, 0);
                transform.Rotate(currentRotation);
                break;
            case 2:
                currentRotation = new Vector3(-1.0f, 0, 0);
                transform.Rotate(currentRotation);
                break;
            case 3:
                currentRotation = new Vector3(0, -2.0f, -2.0f);
                transform.Rotate(currentRotation);
                break;
            default:
                currentRotation = new Vector3(0, 0, 0);
                transform.Rotate(currentRotation);
                break;

        }
   
    }
    void RandomSize()
    {
       randomValueSize = Random.Range(0, 3);
        if (randomValueSize !=0)
        {
            transform.localScale = new Vector3(randomValueSize, randomValueSize, randomValueSize);
        }
       
      
    }




    /*  void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
       
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }*/

}
