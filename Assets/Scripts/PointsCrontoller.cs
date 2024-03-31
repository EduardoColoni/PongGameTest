using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCrontoller : MonoBehaviour
{
    public TMP_Text scoreTextLeft;
    public TMP_Text scoreTextRight;
    private int scoreLeft;
    private int scoreRight;
    // Start is called before the first frame update
    void Start()
    {
        scoreLeft = 0;
        scoreRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextLeft.text=scoreLeft.ToString();
        scoreTextRight.text=scoreRight.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PointsLeft"))
        {  
            scoreLeft++; 
        }
        if (col.CompareTag("PointsRight"))
        {  
            scoreRight++;
        }
    }
}
