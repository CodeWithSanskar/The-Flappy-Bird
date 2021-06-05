using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
  public static  int score = 0;
    private void Start()
    {
        score = 0 ;
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text =  score.ToString(); 
    }
}
