using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class exit : MonoBehaviour {

    // Use this for initialization
    //public GameObject Myset;//退出提示框
    private float mDoubleClk = -2.0f;
    private bool fading = false;
    //private bool mbSet = false;

    void Start () {

	}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if (mbSet)
            //{
            //    mbSet = false;
            //    Myset.SetActive(false);
            //}
            //else
            //{
            //first time
            if (mDoubleClk == -2)
            {
                fading = true;
               
            }

            if ((Time.time - mDoubleClk) < 2.0f)
            {
                mDoubleClk = -2;
                this.OnDoubleClick();
            }
            else
            {
                mDoubleClk = Time.time;
            }
        }
        if (fading)
        {
            if ((Time.time - mDoubleClk) > 2.0f)
            {
              
                mDoubleClk = -2.0f;
            }
        }
    }
    //双击退出
    void OnDoubleClick()
    {
        Application.LoadLevel("Medical3D1.0");
    }
   
}
