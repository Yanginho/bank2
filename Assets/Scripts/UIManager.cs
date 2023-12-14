using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text cashTxt;
    [SerializeField] TMP_Text balanceTxt;

    [SerializeField] TMP_InputField inputValue;
    [SerializeField] TMP_InputField outputValue;

    [SerializeField] GameObject popupError;
    void Start()
    {
        Refresh();
    }

    void Refresh()
    {
        cashTxt.text = MoneyManager.instance.userData.cash.ToString();
        balanceTxt.text = MoneyManager.instance.userData.balance.ToString();
    }

    public void Deposit(int money)
    {

        if (money <= MoneyManager.instance.userData.cash)
        {
            popupError.SetActive(true);
            return;
        }
        MoneyManager.instance.userData.balance += money;
        MoneyManager.instance.userData.cash -= money;
        

        Refresh();
    }

    public void Withdraw(int money)
    {
        if (money > MoneyManager.instance.userData.balance)
        {
            popupError.SetActive(true);
            return;
        }

        MoneyManager.instance.userData.cash += money;
        MoneyManager.instance.userData.balance -= money;

        Refresh();
    }

    public void CustomDeposit()
    {
        Deposit(int.Parse(inputValue.text));
    }

    public void CustomWithdraw()
    {
        Withdraw(int.Parse(outputValue.text));
    }
}
