using UnityEngine;
using System.Collections;

public class RotationTo : MonoBehaviour
{

    private Transform tr;
    private Quaternion finalQuaternion = new Quaternion(0, 180, 0, 0);

    SelectedModel selectdmodel;
    // Use this for initialization


    //计时器，在一定的时间内双击有效  
    private float time = 0f;
    //计数器  
    private int count = 0;
    void Start()
    {
        tr = transform;
        selectdmodel = GameObject.Find("UIManager").GetComponent<SelectedModel>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            count++;
            //当第一次点击鼠标，启动计时器  
            if (count == 1)
            {
                time = Time.time;

            }
            //当第二次点击鼠标，且时间间隔满足要求时双击鼠标  
            if (2 == count && Time.time - time <= 0.5f)
            {
                GetTheClickPoint();

                print("双击了鼠标");
                count = 0;
            }
            if (Time.time - time > 0.5f)
            {
                // time = 0f;  
                count = 0;
            }

        }

        // 使用差值函数平滑的旋转到最终朝向
        tr.rotation = Quaternion.Lerp(tr.rotation, finalQuaternion, 0.1f);
    }

    // 获取点中球面上点坐标
    private void GetTheClickPoint()
    {
      
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;


        
       if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.layer == 8)
            {
                finalQuaternion = CalculateRotation(selectdmodel.HitPointPos);
            }
             

        }
    }

    //计算球面上点 hitPoint 朝向主摄像机时球的 rotation
    private Quaternion CalculateRotation(Vector3 hitPoint)
    {
        // 获取球心到点击球面点的向量
        Vector3 v1 = hitPoint - tr.position;

        // 获取球心到主摄像机的向量
        Vector3 v2 = Camera.main.transform.position - tr.position;

        // 球进行旋转即是以通过球心且和 v1、v2 组成界面垂直的向量（法向量）为旋转轴
        // v1 和 v2 叉乘，获取 v1、v2 组成界面的法向量
        Vector3 cross = Vector3.Cross(v1, v2);

        // 球绕旋转轴旋转的角度为 v1 和 v2 的夹角
        // 获取向量 v1、v2 的夹角
        float angle = Vector3.Angle(v1, v2);

        //获取球以 cross 为旋转轴 旋转angle 角度的 四元数
        Quaternion quaternion = Quaternion.AngleAxis(angle, cross);

        // 这样错误， 必须要 quaternion 左乘 tr.rotation
        //return tr.rotation * quaternion;
        return quaternion * tr.rotation;
    }

}