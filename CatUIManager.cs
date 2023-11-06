using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatUIManager : MonoBehaviour
{
    public int Moneyz;

    public Slider Hp;
    public Slider Cl;
    public Slider Fu;

    TextMeshProUGUI hpPro;
    TextMeshProUGUI clPro;
    TextMeshProUGUI fuPro;


    void Start()
    {
        hpPro = Hp.transform.Find("Text_Exp").GetComponent<TextMeshProUGUI>();
        clPro = Cl.transform.Find("Text_Exp").GetComponent<TextMeshProUGUI>();
        fuPro = Fu.transform.Find("Text_Exp").GetComponent<TextMeshProUGUI>();
        StartCoroutine(subtracthp());
        Hp.value = Cl.value + Fu.value;
        hpPro.text = Cl.value + Fu.value + "/200";
        clPro.text = Cl.value + "/100";
        fuPro.text = Fu.value + "/100";
    }

    IEnumerator subtracthp()
    {
        yield return new WaitForSeconds(30f);
        Cl.value -= 5;
        Fu.value -= 10;
        Hp.value = Cl.value + Fu.value;
        hpPro.text = Cl.value + Fu.value + "/200";
        clPro.text = Cl.value + "/100";
        fuPro.text = Fu.value + "/100";

        StartCoroutine(subtracthp());
    }
    void Update()
    {
     

    }

    public void ShowPanel(float aa)
    {
        transform.localScale = new Vector3(aa, aa, 1);
        if (h0[0].text == "0")
        {
            Btns[0].interactable = false;
        }
        else
        {
            Btns[0].interactable = true;

        }
        if (h0[1].text == "0")
        {
            Btns[1].interactable = false;
        }
        else
        {
            Btns[1].interactable = true;

        }
        if (h0[2].text == "0")
        {
            Btns[2].interactable = false;
        }
        else
        {
            Btns[2].interactable = true;

        }
    }

    public TextMeshProUGUI[] h0;
    public Button[] Btns;
    public void Eatfood(int num)
    {
        if (num == 0)
        {
            Hp.value += 5;
            hpPro.text = Hp.value+ "/200";
          
        }
        if (num == 1)
        {
            Cl.value += 5;
            clPro.text = Cl.value + "/100";
        }
        if (num == 2)
        {
            Fu.value += 5;
            fuPro.text = Fu.value + "/100";
        }
        int a = int.Parse(h0[num].text);
        a--;
        h0[num].text = a.ToString();
        if (h0[num].text == "0")
        {
            Btns[num].interactable = false;
        }
    }


    [HideInInspector]
    public int xymoney;
    public Button[] Btns2;
    public void Butshop(int num)
    {
        foreach (var item in Btns2)
        {
            item.transform.Find("select").gameObject.SetActive(false);
        }
        Btns2[num].transform.Find("select").gameObject.SetActive(true);

        if (num == 0)
        {
            xymoney = 1000;
        }
        if (num == 1)
        {
            xymoney = 300;
        }
        if (num == 2)
        {
            xymoney = 500;
        }
    }

    int yw = 0;
    int cl = 0;
    int fish = 0;
    public void Butshoping()
    {
    

        if (Moneyz >=xymoney)
        {
            Moneyz -= xymoney;
            h0[3].text = Moneyz.ToString();
            if (xymoney == 1000)
            {
                yw += 1;
                h0[0].text = yw.ToString();
            }
            if (xymoney == 300)
            {
                cl += 1;
                h0[1].text = cl.ToString();
            }
            if (xymoney == 500)
            {
                fish += 1;
                h0[2].text = fish.ToString();
            }
        }
        else
        {
            print("no enough money");
        }
     
    }
}
