﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

  void Start () {
   
  }

  void Update () {
 
	}

  public void OnClick() {
                                     //ボタンクリックによるゲームスタート
      SceneManager.LoadScene("Main");
    
  }
  
}
