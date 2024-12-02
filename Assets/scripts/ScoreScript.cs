


using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNumber ;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
        MyscoreText.text = "Score :  " + ScoreNumber;
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D Strawberry_anim)
    {
        if( Strawberry_anim.tag == "Strawberry")
        {
            ScoreNumber++;
            Destroy(Strawberry_anim.gameObject);//destroy when the player touches the strawberry
            MyscoreText.text = "Score :  " + ScoreNumber;
        }
    }
    
}