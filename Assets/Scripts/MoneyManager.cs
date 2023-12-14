using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    public UserData userData;
    private void Awake()
    {
        instance = this;
    }
}