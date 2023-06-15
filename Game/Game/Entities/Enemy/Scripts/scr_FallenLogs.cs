using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_FallenLogs : MonoBehaviour
{
    [SerializeField] GameObject[] fallenLogsPrefab;
    [SerializeField] GameObject[] fallenLogsGame;

    internal string animationName_FallenLogsLeftFall = "anim_FallenLogsLeftFall";
    internal string animationName_FallenLogsRightFall = "anim_FallenLogsRightFall";

    internal string animationName_FallenLogsLeftApproach = "anim_FallenLogsLeftApproach";
    internal string animationName_FallenLogsRightApproach = "anim_FallenLogsRightApproach";

    private void Start()
    {
        SpawnFallenLogs();
        AnimateFallenLogsInitial();
        StartCoroutine(WaitFor_AnimateFallenLogsApproach(4f));
        StartCoroutine(WaitFor_DestroyFallenLogs(30f));
    }

    private void SpawnFallenLogs()
    {
        for (int i = 0; i< fallenLogsPrefab.Length; i++)
        {
            fallenLogsGame[i] = Instantiate(fallenLogsPrefab[i]);
        }
    }

    private void AnimateFallenLogsInitial()
    {
        fallenLogsGame[0].GetComponent<Animator>().Play(animationName_FallenLogsLeftFall);
        fallenLogsGame[1].GetComponent<Animator>().Play(animationName_FallenLogsRightFall);
    }

    private IEnumerator WaitFor_AnimateFallenLogsApproach(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        AnimateFallenLogsApproach();
    }

    private void AnimateFallenLogsApproach()
    {
        fallenLogsGame[0].GetComponent<Animator>().Play(animationName_FallenLogsLeftApproach);
        fallenLogsGame[1].GetComponent<Animator>().Play(animationName_FallenLogsRightApproach);
    }

    private IEnumerator WaitFor_DestroyFallenLogs(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        DestroyFallenLogs();
    }

    private void DestroyFallenLogs()
    {
        Destroy(this);
    }
}
