using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedModel : MonoBehaviour {

    public Vector3 HitPointPos = new Vector3 (0,0,0);
    private string SelectedModelName =null;
    GameObject[] Heart_Objs;

   public  bool bSelectedModel = false;
    //四个按钮的文字
    public  Text Conceal_Button_text;
    public Text Conceal_Else_Button_text;
    public Text Transparent_Button_text;
    public Text Transparent_Else_Button_text;
    //透明的shader
    public Shader transparentShader;
    public Shader opaqueShader;

    ChangeShader changeshader;
    //信息显示文字框
    public Text information_Text;


    void Start () {

        Heart_Objs = GameObject.FindGameObjectsWithTag("heart");
        changeshader = GameObject.Find("Heart").GetComponent<ChangeShader>();


    }	
	void Update ()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.layer == 8 )
                {
                    GameObject gameObj = hitInfo.collider.gameObject;
                    SelectedModelName = gameObj.name;
                    HitPointPos = hitInfo.point;
                    bSelectedModel = true;
                    print(SelectedModelName);
                    TheSelected(hitInfo.transform.gameObject);
                }         
            }
         }

     }
    bool bConcel = false;
    
   public void ConcealModel()
    {
        
        foreach (var obj in Heart_Objs)
        {
            if (obj.name == SelectedModelName && bSelectedModel==true)
            {
                if (bConcel == false)
                {
                    obj.SetActive(false);
                    Conceal_Button_text.text = "显示所选";
                    bConcel = true;
                }
                else
                {
                    obj.SetActive(true);
                    Conceal_Button_text.text = "隐藏所选";
                    bConcel = false;
                }
                
            }
        }
    }

    bool bConceal_Else = false;
   public void Conceal_ElseModel()
    {
        if (bConceal_Else == false && bSelectedModel == true)
        {
            foreach (var obj in Heart_Objs)
            {
                if (obj.name != SelectedModelName && bSelectedModel == true)
                {
                    obj.SetActive(false);

                }
            }
            Conceal_Else_Button_text.text = "显示其他";
            bConceal_Else = true;
        }
        else if (bConceal_Else == true && bSelectedModel == true)
        {
            foreach (var obj in Heart_Objs)
            {
                if (obj.name != SelectedModelName && bSelectedModel == true)
                {
                    obj.SetActive(true);

                }
            }
            Conceal_Else_Button_text.text = "隐藏其他";
            bConceal_Else = false;
        }
        
    }
    
    public void TransparentModel()//透明所选
    {
        foreach (var obj in Heart_Objs)
        {
            if (obj.name == SelectedModelName && bSelectedModel == true)
            {
                Renderer mater = obj.transform.GetComponent<Renderer>();
                if (mater.material.shader == opaqueShader)
                {
                    Transparent_Button_text.text = "恢复所选";
                    mater.material.shader = transparentShader;
                }
                else
                {
                    Transparent_Button_text.text = "透明所选";
                    mater.material.shader = opaqueShader;
                }
            }

        }
    }

    bool bTransparent_Else = false;
    public void Transparent_ElseModel()//透明其他
    {
        if (bTransparent_Else == false)
        {
            foreach (var obj in Heart_Objs)
            {
                if (obj.name != SelectedModelName && bSelectedModel == true)
                {
                    Renderer mater = obj.transform.GetComponent<Renderer>();
                    mater.material.shader = transparentShader;
                }
            }
            Transparent_Else_Button_text.text = "恢复其他";
            bTransparent_Else = true;
        }
        else
        {
            foreach (var obj in Heart_Objs)
            {
                if (obj.name != SelectedModelName && bSelectedModel == true)
                {
                    Renderer mater = obj.transform.GetComponent<Renderer>();
                    mater.material.shader = opaqueShader;
                }
            }
            Transparent_Else_Button_text.text = "透明其他";
            bTransparent_Else = false;
        }
       
     }
    public void TheSelected(GameObject selectMaterial)//选中高亮  一次只能选中一个
    {
        foreach (GameObject mat in Heart_Objs)
        {
            if (mat == selectMaterial)
            {
                Renderer mater = mat.transform.GetComponent<Renderer>();
                Debug.Log(mater.material);
                mater.material.SetFloat("_selected", 1);
            }
            else
            {
                Renderer mater = mat.transform.GetComponent<Renderer>();
                Debug.Log(mater.material);
                mater.material.SetFloat("_selected",0);
            }
        }
    }

    public void InformationWindowText()
    {
        information_Text.text = "选中的是"+ SelectedModelName+
            ",它的医学信息XXXXXXXXXXXXXX"
                    ;
    }
}
