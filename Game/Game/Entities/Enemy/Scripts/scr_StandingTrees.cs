using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_StandingTrees : MonoBehaviour
{
    [SerializeField] internal GameObject treePrefab;
    [SerializeField] internal GameObject[] treesGame;

    [Space]

    [SerializeField] internal bool leftPositionTaken = false;
    [SerializeField] internal bool middlePositionTaken = false;
    [SerializeField] internal bool rightPositionTaken = false;

    [Space]

    [SerializeField] internal int randomPositionNumber;
    [SerializeField] internal bool continueWhile = true;

    internal string animationName_TreeRiseOne = "anim_StandingTreeRiseV1";
    internal string animationName_TreeRiseTwo = "anim_StandingTreeRiseV2";
    internal string animationName_TreeRiseThree = "anim_StandingTreeRiseV3";

    internal string animationName_TreeApproachOne = "anim_StandingTreeApproachV1";
    internal string animationName_TreeApproachTwo = "anim_StandingTreeApproachV2";
    internal string animationName_TreeApproachThree = "anim_StandingTreeApproachV3";

    private void Start()
    {
        SpawnRandomizedTrees();
        AnimateTreesRise();

        StartCoroutine(WaitFor_AnimateTreesApproach(6f));
        StartCoroutine(WaitFor_DestroyTrees(30f));
    }

    private void SpawnRandomizedTrees()
    {

        for (int i = 0; i < 2; i++)
        {
            continueWhile = true;

            while (continueWhile)
            {
                randomPositionNumber = Random.Range(0, 3);
                if (randomPositionNumber == 0 && !leftPositionTaken)
                {
                    treesGame[0] = Instantiate(treePrefab);
                    leftPositionTaken = true;
                    continueWhile = false;
                }
                else if (randomPositionNumber == 1 && !middlePositionTaken)
                {
                    treesGame[1] = Instantiate(treePrefab);
                    middlePositionTaken = true;
                    continueWhile = false;
                }
                else if (randomPositionNumber == 2 && !rightPositionTaken)
                {
                    treesGame[2] = Instantiate(treePrefab);
                    rightPositionTaken = true;
                    continueWhile = false;
                }
            }
        }
    }

    private void AnimateTreesRise()
    {
        for (int i = 0; i < treesGame.Length; i++)
        {
            if (i == 0 && treesGame[i] != null)
            {
                treesGame[0].GetComponent<Animator>().Play(animationName_TreeRiseOne);
                continueWhile = false;
            }
            if (i == 1 && treesGame[i] != null)
            {
                treesGame[1].GetComponent<Animator>().Play(animationName_TreeRiseTwo);
                continueWhile = false;
            }
            if (i == 2 && treesGame[i] != null)
            {
                treesGame[2].GetComponent<Animator>().Play(animationName_TreeRiseThree);
                continueWhile = false;
            }
        }
    }

    private void AnimateTreesApproach()
    {
        for (int i = 0; i < treesGame.Length; i++)
        {
            if (i == 0 && treesGame[i] != null)
            {
                treesGame[i].GetComponent<Animator>().Play(animationName_TreeApproachOne);
                continueWhile = false;
            }
            else if (i == 1 && treesGame[i] != null)
            {
                treesGame[i].GetComponent<Animator>().Play(animationName_TreeApproachTwo);
                continueWhile = false;
            }
            else if (i == 2 && treesGame[i] != null)
            {
                treesGame[i].GetComponent<Animator>().Play(animationName_TreeApproachThree);
                continueWhile = false;
            }
        }
    }

    private IEnumerator WaitFor_AnimateTreesApproach(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        AnimateTreesApproach();
    }

    private void DestroyTrees()
    {
        for (int i = 0; i < treesGame.Length; i++)
        {
            Destroy(treesGame[i]);
        }
    }

    private IEnumerator WaitFor_DestroyTrees(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        DestroyTrees();
    }
}
