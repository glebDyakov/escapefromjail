﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GrabCoins : MonoBehaviour {
	static int w = 0;

	void OnMouseDown () {
		//gameObject.SetActive (gameObject);
		Text  q = GetComponentInParent(typeof(Text)) as Text;
		w+=1;
		q.text = "Coins: " + w.ToString();
		PlayerPrefs.SetInt ("TextCoinsInLevel", w);
		gameObject.GetComponent<Renderer>().enabled = false;
		print ("собрал монету");
		gameObject.GetComponent<SpriteRenderer>().color = new Color32(255,255,255,0);
		Destroy (gameObject, 5f);
		//UpdateText();
	}
	void UpdateText(){
		UpdateTextCustomComponent updateTextCustomComponentInst = this.gameObject.AddComponent (typeof(UpdateTextCustomComponent)) as UpdateTextCustomComponent;
		Destroy (this.gameObject, 1f);				
	}
	/*
	void OnDestroy(){
		
	}
	*/
}
