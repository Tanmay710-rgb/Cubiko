using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
  public gamemanager GameManager;

  void OnTriggerEnter(){
    GameManager.Completelevel();
  }
}
