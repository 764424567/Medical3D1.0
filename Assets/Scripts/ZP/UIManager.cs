using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {


    SelectedModel selectmodel;
    // Use this for initialization
    public GameObject Information_Panel_Obj;

    ModelControl modelcontrol;
    RotationTo rotationto;
    Scale scale;
    WrittingBoard writtingboard;
    void Start () {

        selectmodel = GameObject.Find("UIManager").GetComponent<SelectedModel>();
        modelcontrol = GameObject.Find("Main Camera").GetComponent<ModelControl>();
        rotationto = GameObject.Find("Heart").GetComponent<RotationTo>();
        scale = GameObject.Find("Heart").GetComponent<Scale>();
        writtingboard = GameObject.Find("WrittingBoard").GetComponent<WrittingBoard>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //   隐藏/显示所选按钮
    public void Conceal_Button_Click()
    {
        selectmodel.ConcealModel();

    }

  //    隐藏/显示其他按钮
    public void Conceal_Else_Button_Click()
    {

        selectmodel.Conceal_ElseModel();
    }
    //  透明/恢复所选按钮
    public void Transparent_Button_Click()
    {
        selectmodel.TransparentModel();
    }

    //  透明/恢复其他按钮
    public void Transparent_Else_Button_Click()
    {
        selectmodel.Transparent_ElseModel();
    }

    //信息显示按钮
    public void Information_Button_Click()
    {
        if (selectmodel.bSelectedModel == true)
        {
            Information_Panel_Obj.SetActive(true);
            selectmodel.InformationWindowText();
        }
        
    }

    //书写板按钮
    public void WrittingBoard_Button_Click()
    {
        writtingboard.enabled = true;
        writtingboard.mCanDraw = true;
        modelcontrol.enabled = false;
        scale.enabled = false;
        rotationto.enabled = false;
    }

    //解除锁定按钮

    public void Unlock_Button_Click()
    {
        writtingboard.ClearLineRenderer();
        writtingboard.mCanDraw = false;
        writtingboard.enabled = false;
        modelcontrol.enabled = true;
        scale.enabled = true;
        rotationto.enabled = true;
    }
}
