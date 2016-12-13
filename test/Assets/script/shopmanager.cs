using UnityEngine;
using System.Collections;

public class shopmanager : MonoBehaviour {
    public housescript house;
    public GameObject houseicon;
    public Texture[] upgradeicon;
    public GameObject locker;
    public bool buy;
	void Start ()
    {
        switch (house.upgrade)
        {
            case 1:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[1];
                break;
            case 2:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[2];
                break;
            case 3:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[3];
                break;
            case 4:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[4];
                break;
            case 5:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[5];
                break;
            case 6:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[6];
                break;
            case 7:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[7];
                break;
            case 8:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[8];
                break;
            case 9:
                houseicon.GetComponent<Renderer>().material.mainTexture = upgradeicon[9];
                break;
        }
	}
	void Update ()
    {
	
	}
    public void upgradebutton()
    {
        house.upgrade++;
        buy = true;
        locker.SetActive(true);
    }
    public void background()
    {

    }
    public void carparkbutton()
    {

    }
    public void getgiup()
    {

    }
}
