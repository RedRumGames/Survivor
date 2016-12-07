using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class resourcebag : MonoBehaviour {
    public int amtOfCoins;
    public int amtOfGoldBars, gbw;
    public int amtOfIronBars, ibw;
    public int amtOfLogs, lw;
    public int amtOfSticks, sw;
    public int amtOfPlanks, pw;
    public int weight;
    public int bagSize;

    public Text cointext;
    public Text weightText;
    public Text logtext;
    public Text planktext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gbw = amtOfGoldBars * 5;
        ibw = amtOfIronBars * 4;
        lw = amtOfLogs * 10;
        sw = amtOfSticks * 1;
        pw = amtOfPlanks * 3;
        weight = gbw + ibw + lw + sw + pw;
        cointext.text = "$"+amtOfCoins.ToString("0,0");
        weightText.text = "Weight: " + weight.ToString() + "/"+bagSize.ToString();
        logtext.text = amtOfLogs.ToString();
        planktext.text = amtOfPlanks.ToString();
        //Debug.Log(weight);
    }
}
