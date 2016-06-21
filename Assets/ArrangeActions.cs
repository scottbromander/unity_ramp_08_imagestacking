using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ArrangeActions : MonoBehaviour {
	private RectTransform panelRectTransform;

	// Use this for initialization
	void Start () {
		panelRectTransform = GetComponent<RectTransform>();
	}

	public void MoveDownOne(){
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex ();
		print ("(before change) " + panelRectTransform.name + " sibling index =  " + currentSiblingIndex);
		panelRectTransform.SetSiblingIndex (currentSiblingIndex - 1);
		print ("After Change: " + panelRectTransform.name + " sibling index = " + currentSiblingIndex);
	}

	public void MoveUpOne(){
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex ();
		print ("Before Change: " + panelRectTransform.name + " sibling index = " + currentSiblingIndex);
		panelRectTransform.SetSiblingIndex (currentSiblingIndex + 1);
		print ("After Change: " + panelRectTransform.name + " sibling index = " + currentSiblingIndex);
	}
}
