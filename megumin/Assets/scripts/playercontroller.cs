using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
    // Use this for initialization
    public float vel = 0f;
    private Animator megumin;
    void Start () {
        megumin = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * vel;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        megumin.SetFloat("Status", Mathf.Abs(z));
    }
}
