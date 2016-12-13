using UnityEngine;
using System.Collections;

public class housescript : MonoBehaviour {
    public humanscript[] counthuman;
    public float[] count;
    public int i = 0;
    public int maxi;
    public int upgrade = 0;
    public Texture[] house;
	void Start ()
    {
        switch (upgrade)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[0];
                maxi = 1;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[1];
                maxi = 2;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[2];
                maxi = 3;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[3];
                maxi = 5;
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[4];
                maxi = 10;
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[5];
                maxi = 20;
                break;
            case 6:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[6];
                maxi = 30;
                break;
            case 7:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[7];
                maxi = 50;
                break;
            case 8:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[8];
                maxi = 35;
                break;
            case 9:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[9];
                maxi = 100;
                break;
            case 10:
                gameObject.GetComponent<Renderer>().material.mainTexture = house[10];
                maxi = 300;
                break;
        }
	}
	void Update ()
    {
        if(i > maxi)
        {
            i = 0;
        }
	}
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Human")
        {
            if (counthuman[i] == null)
            {
                counthuman[i] = col.gameObject.GetComponent<humanscript>();
                counthuman[i].liquidstate = true;
                i++;
            }
            else
            {
                col.gameObject.GetComponent<humanscript>().state = true;
            }
        }
    }
}
