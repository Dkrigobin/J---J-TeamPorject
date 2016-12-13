using UnityEngine;
using System.Collections;

public class humanscript : MonoBehaviour {
    public bool state;
    public bool liquidstate;
    public Texture[] human;
    public int gage = 5;
    public int humannum;
    public float count = 1f;
    public float speed;
    public bool move;
    public Transform backposion;
    public Transform removeposion;
    enum humangoing
    {
        go,
        liquid,
        back,
        goback,
        remove
    }
    humangoing nowstate = humangoing.go;
    void Start ()
    {
        humannum = Random.Range(0, 5);
        switch (humannum)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.mainTexture = human[0];
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.mainTexture = human[1];
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.mainTexture = human[2];
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.mainTexture = human[3];
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material.mainTexture = human[4];
                break;
        }
	}
	void Update ()
    {
        if(state == true)
        {
            nowstate = humangoing.back;
            state = false;
        }
        if(liquidstate == true)
        {
            nowstate = humangoing.liquid;
        }
        switch (nowstate)
        {
            case humangoing.go:
                transform.Translate(speed * Time.deltaTime, 0, 0);
                break;
            case humangoing.back:
                if (move == true)
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    move = false;
                }
                break;
            case humangoing.liquid:
                if (count <= 0)
                {
                    gage--;
                    count = 1f;
                }
                if(gage <= 0)
                {
                    gage = 10;
                    nowstate = humangoing.back;
                }
                break;
            case humangoing.remove:
                if (move == true)
                {
                    transform.position = new Vector3(removeposion.position.x, removeposion.position.y);
                    move = false;
                }
                break;
            case humangoing.goback:

                break;
        }
	}
}
