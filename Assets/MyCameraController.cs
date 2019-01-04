using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {
    private GameObject unitychan;
    public float difference;
	// Use this for initialization
	void Start () {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
		
	}
    private void OnBecameInvisible()
    {
        if(gameObject.tag == "CarTag"|| gameObject.tag == "TrafficConeTag" || gameObject.tag == "CoinTag"){
            Destroy(this.gameObject);
        }
    }
}
