using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        int currentScore = int.Parse(textScore.text);
        int newScore = currentScore;
        textScore.text = newScore.ToString();
        Debug.Log(textScore.text);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dustbin" || other.gameObject.tag == "BasketBallPool")
        {
            Debug.Log("Hi");
            int currentScore = int.Parse(textScore.text);
            int newScore = currentScore + 1;
            textScore.text = newScore.ToString();
            Debug.Log(textScore.text);
        }

        Debug.Log("Hello");
    }

    /*void OnTriggerEnter(Collider other)
    {
        if(other.tag == 'Dustbin')
        {
            int currentScore = int.Parse(textScore.text);
            int newScore = currentScore + 1;
            textScore.text = newScore.ToString();
            Debug.Log(textScore.text);
        }
    }*/


    // Update is called once per frame
    void Update()
    {
       
    }
}
