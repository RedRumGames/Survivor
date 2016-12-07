using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class infoboxmanager : MonoBehaviour {
    public GameObject player;
    public Text lvltext;
    public Text xptext;
    public Text uptext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lvltext.text = "Level: "+player.GetComponent<playerlevel>().lvl.ToString();
        xptext.text = "XP: "+player.GetComponent<playerlevel>().totalxp.ToString()+"/"+player.GetComponent<playerlevel>().nxtxp.ToString();
        uptext.text = "UP: " + player.GetComponent<playerlevel>().up.ToString();
    }
}
