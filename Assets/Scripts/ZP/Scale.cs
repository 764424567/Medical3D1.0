using UnityEngine;
using System.Collections;


public class Scale : MonoBehaviour
{

    public Transform target;

    float distance = 51f;
    float xSpeed = 20f;
    float ySpeed = 150f;
    float yMinLimit = -180f;
    float yMaxLimit = 180f;
    float x = 0f;
    float y = 0f;
    Vector2 oldPosition1;
    Vector2 oldPosition2;
    private bool flag_Roable = true;//自动旋转标志

    private System.DateTime oldTime;
    private System.DateTime nowTime;
    public Vector3 vec;
    public float scale;
    // Use this for initializatio

    float startSalse;

    //float a;
    //string b;
   public  void Start()
    {
       
       
        transform.eulerAngles = vec;
        startSalse = transform.localScale.x;
        transform.localScale = new Vector3(scale, scale, scale);
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
        oldTime = System.DateTime.Now;
        
    }


    // Update is called once per frame
    void Update()
    {
        nowTime = System.DateTime.Now;
        System.TimeSpan ts1 = new System.TimeSpan(oldTime.Ticks);
        System.TimeSpan ts2 = new System.TimeSpan(nowTime.Ticks);

        System.TimeSpan ts = ts2.Subtract(ts1).Duration();
        if (ts.Seconds > 8 && !Input.anyKey)
        {
            flag_Roable = true;
            oldTime = System.DateTime.Now;
        }
        if (Input.anyKey)
        {
      
         
            if (Input.touchCount > 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
                {
                    Vector2 tempPosition1 = Input.GetTouch(0).position;
                    Vector2 tempPosition2 = Input.GetTouch(1).position;
                    if (isEnlarge(oldPosition1, oldPosition2, tempPosition1, tempPosition2))
                    {

                       // distance = (transform.position - target.position).magnitude;
                       // distance -= 0.5f;
                      
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale * 1.025f;
                        if(newScale<startSalse*3f)
                        {
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                        }
                        
                        // if (distance > 3.0f)
                        // {

                        // }
                    }
                    else
                    {
                        //if (distance < 18.5f)
                        //{
                        // distance += 0.5f;
                        //  }
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale / 1.025f;
                        if (newScale > startSalse * 0.5f)
                        {
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                        }
                           
                    }
                    //备份上一次触摸点的位置，用于对比  
                    oldPosition1 = tempPosition1;
                    oldPosition2 = tempPosition2;

                }
            }
        }
       



    }

 
    bool isEnlarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        //函数传入上一次触摸两点的位置与本次触摸两点的位置计算出用户的手势  
        var leng1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        var leng2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));
        if (leng1 < leng2)
        {
            //放大手势  
            return true;
        }
        else
        {
            //缩小手势  
            return false;
        }
    }


   
}