using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour {
    public static ChangeShader instance;
    public Material[] allMaterial;
    public Shader transparentShader;
    public Shader opaqueShader;
    public Renderer temp;
    void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TheSelected(temp);
        }
	}
    
    public void TransparentTheOther(Material selectMaterial)//透明其他
    {
        foreach(Material mat in allMaterial)
        {
            if(mat!= selectMaterial)
            {
                if (mat.shader == opaqueShader)
                {
                    mat.shader = transparentShader;
                }
                else
                {
                    mat.shader = opaqueShader;
                }
            }
        }
    }

    public void TransparentSelected(Material selectMaterial)//透明所选
    {
        if (selectMaterial.shader == opaqueShader)
        {
            selectMaterial.shader = transparentShader;
        }
        else
        {
            selectMaterial.shader = opaqueShader;
        }
    }
    public  void TheSelected(Renderer selectMaterial)//选中高亮  一次只能选中一个
    {
        foreach (Material mat in allMaterial)
        {
            if (mat == selectMaterial.material)
            {
                selectMaterial.material.SetFloat("_selected", 1);
            }
            else
            {
                mat.SetFloat("_selected", 0);
            }
        }
    }
}
