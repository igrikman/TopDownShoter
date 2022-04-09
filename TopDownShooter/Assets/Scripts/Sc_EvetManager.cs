using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Sc_EvetManager : MonoBehaviour
{
  public static Action OnEnemyKilled;

   public static void SendEnemyKilled()
    {
        if (OnEnemyKilled != null) OnEnemyKilled.Invoke();
    }
}
