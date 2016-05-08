using UnityEngine;
using System.Collections;

public class Player_Info : MonoBehaviour {

    public int playerID;
    public string selectedRace;
    public int livesRemaining = 30;
    public PlayerManager playerManagerScript;
    public GameObject playerManagerObject;
    public GameObject playerUI;

	// Use this for initialization
	void Start () {
        playerID = GetInstanceID();
        playerManagerObject = GameObject.Find("PlayerManager");
        playerManagerScript = (PlayerManager) playerManagerObject.GetComponent("PlayerManager");

        // when this object is created, send this object to the manager so it can index it
        playerManagerScript.addPlayer(transform.gameObject);

        // attach this player_info object to the PlayerManager object.
        playerManagerScript.setChildRelationship(transform.gameObject);
        
        // race select
        selectTrads();

        // instantiate and set up the interface, and then attach it to this object
        generateUI();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void generateUI ()
    {
        playerUI = Instantiate(playerManagerScript.genericUI);
        playerUI.transform.parent = transform.parent;
    }


    void selectTrads()
    {
        // set race. needs to be changed.
        selectedRace = "Trads";
        
        // Remove the race selection UI
        GameObject raceSelectionObject = GameObject.Find("RaceSelection UI");
        Destroy(raceSelectionObject);
        
    }
}
