using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kllop : MonoBehaviour
{
    public int price = 6;
    public int score = 0;
    public int increment = 1;
    public Text text1;
    public Text text2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void increasesscore()
    {
        score += increment;
        text1.text = score.ToString();
    }
    public void store()
    {
        if (score > price)
        {
            increment++;
            text2.text = increment.ToString();
            score -= price;
            text1.text = score.ToString();
        }
    }
}