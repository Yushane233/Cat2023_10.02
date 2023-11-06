using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{

    public Animator animator;



    private void Start()
    {
        animator.Play("IdleA");
        StartCoroutine(anis());
    }
    string[] anisstr = new string[]
    {
        "IdleA",
        "Idle03",
        "IdleB",
        "Idle05",
        "IdleC",
        "Sit"
    };
    IEnumerator anis()
    {
        yield return new WaitForSeconds(10f);
        int num = Random.Range(0, 6);
        animator.Play(anisstr[num]);


  

        StartCoroutine(anis());
    }
    public AnimationClip AlertClip;
    public AnimationClip HiClip;
    public AnimationClip NoClip;
    public AnimationClip IdleCClip;
    public AnimationClip IdleClip;
    public AnimationClip SitClip;
    public AnimationClip WorshipClip;
    public AnimationClip JumpClip;

    float timess = 0;
    public void OnClickAni(string str)
    {
        StopCoroutine(anis());
        if (str.Equals("Alert"))
        {
            timess = AlertClip.length;
            animator.Play(str);

        }
        if (str.Equals("Hi"))
        {
            timess = HiClip.length;
            animator.Play(str);
        }
        if (str.Equals("dupi"))
        {
            FindObjectOfType<CatUIManager>().ShowPanel(0.4f);
        }
        if (str.Equals("IdleC"))
        {
            timess = IdleCClip.length;
            animator.Play(str);

        }
        if (str.Equals("Idle"))
        {
            timess = IdleClip.length;
            animator.Play(str);

        }
        if (str.Equals("Sit"))
        {
            timess = SitClip.length;
            animator.Play(str);

        }
        if (str.Equals("Worship"))
        {
            timess = WorshipClip.length;
            animator.Play(str);

        }
        if (str.Equals("Jump"))
        {
            timess = JumpClip.length;
            animator.Play(str);
        }
        StartCoroutine(anis2(timess));
    }
    IEnumerator anis2(float times)
    {
        yield return new WaitForSeconds(times+0.2f);
        StartCoroutine(anis());
    }

}
