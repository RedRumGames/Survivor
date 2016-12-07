using UnityEngine;
using System.Collections;

public class playerlevel : MonoBehaviour {
    public int lvl;
    public int up;
    public int totalxp;
    public int currentxp;
    public int nxtxp;
    public int nxtxpmultiplyer;
    public int xpmulti;

	// Use this for initialization
	void Start () {
        lvl = 1;
        nxtxp = 100;
        xpmulti = 1;
        up = 10;
    }
	
	// Update is called once per frame
	void Update () {
        totalxp += xpmulti;
        if (totalxp >= nxtxp)
        {
            lvl++;
            nxtxp += 100 * nxtxpmultiplyer;
            nxtxpmultiplyer++;
            
            up += 15;
        }
	
	}
}
