using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    // Config Parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float xMin = 0;
    [SerializeField] float xMax = 14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXPos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mouseXPos, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXPos, xMin, xMax);
        transform.position = paddlePos;
    }
}
