using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WrittingBoard : MonoBehaviour {
	
    public float mLineWidth = 0.5f;
	public Color mLineColor = Color.red;
	public GameObject mLineRendererObject;

	private LineRenderer lineRenderer;
	private List<LineRenderer> lineList = new List<LineRenderer> ();

	private Vector3 screenPoint;
	private Vector3 scanPos;

	public  bool mCanDraw = false;
	private int pointCnt = 0;//当前这条线点的个数

	private Event e;

	void Start () {
        e = Event.current;

		if (!mLineRendererObject) {
			mLineRendererObject = new GameObject();
			mLineRendererObject.AddComponent<LineRenderer> ();
			mLineRendererObject.transform.name = "LineRendererObject";
		}

		scanPos = mLineRendererObject.transform.position;
		lineRenderer = mLineRendererObject.GetComponent<LineRenderer> ();
		lineRenderer.material = new Material (Shader.Find ("Particles/Additive"));
		lineRenderer.SetColors (mLineColor, mLineColor);
		lineRenderer.SetWidth (mLineWidth * 0.01f, mLineWidth * 0.01f);
		lineRenderer.SetVertexCount (0);
    }
	
	void Update () {
		if(e != null & mCanDraw)
		{
            if(e.type == EventType.MouseDown)
			{
                screenPoint = Camera.main.WorldToScreenPoint(scanPos);
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

				GameObject newObj = Instantiate(mLineRendererObject, mLineRendererObject.transform.position, mLineRendererObject.transform.rotation) as GameObject;
				lineRenderer = newObj.GetComponent<LineRenderer>();
				lineRenderer.SetColors(mLineColor, mLineColor);
				lineRenderer.SetWidth(mLineWidth * 0.01f, mLineWidth * 0.01f);

				if (lineList == null) {
					lineList = new List<LineRenderer> ();
				}
				lineList.Add (lineRenderer);

				pointCnt = 0;
				DrawRenderLine(lineList[lineList.Count-1], curPosition);
            }
            if(e.type == EventType.MouseDrag)
			{
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
				if (lineList.Count > 0) {
					DrawRenderLine (lineList[lineList.Count-1], curPosition);
				}
            }
        }
    }

	string str1 = "";
    void OnGUI()
	{
		e = Event.current;
		//if (GUI.Button (new Rect (350, 0, 100, 50), "关闭")) {
		//	mCanDraw = false;
		//	ClearLineRenderer ();
		//}
		//if (GUI.Button (new Rect (250, 0, 100, 50), "启用")) {
		//	mCanDraw = true;
		//}
		if (GUI.Button (new Rect (0, Screen.height * 0.3f, Screen.width * 0.3f, Screen.height * 0.05f), "清除")) {
			ClearLineRenderer ();
		}
		if (GUI.Button (new Rect (0,Screen.height *0.35f, Screen.width * 0.3f, Screen.height * 0.05f), "撤回"))
        {
			RollBack ();
		}
		GUI.Label (new Rect (50, 100, 1000, 60), str1);
	}

    void DrawRenderLine(LineRenderer line, Vector3 pos)
	{
        line.SetVertexCount(++pointCnt);
        line.SetPosition(pointCnt-1, pos);
    }

	public void ClearLineRenderer()
	{
		while (lineList.Count > 0)
		{
			DestoryOneLine ();
		}
	}

	void RollBack()
	{
		DestoryOneLine ();
	}

	void DestoryOneLine()
	{
		if (lineList.Count > 0) {
			GameObject linego = lineList [lineList.Count - 1].gameObject;
			DestroyObject (linego);
			lineList.Remove (lineList [lineList.Count - 1]);
		}
	}
}