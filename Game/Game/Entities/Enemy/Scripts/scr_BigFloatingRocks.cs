using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_BigFloatingRocks : MonoBehaviour
{
    [SerializeField] internal Vector3 leftPosition = new Vector3(-5, 6, 95);
    [SerializeField] internal Vector3 middlePosition = new Vector3(.75f, 6, 95);
    [SerializeField] internal Vector3 rightPosition = new Vector3(7, 6, 95);

    [Space]

    [SerializeField] internal GameObject[] bigRocksPrefabs;
    [SerializeField] internal GameObject[] bigRocksGame;

    [Space]

    [SerializeField] internal bool leftPositionTaken = false;
    [SerializeField] internal bool middlePositionTaken = false;
    [SerializeField] internal bool rightPositionTaken = false;

    [Space]

    [SerializeField] internal bool leftPositionThrown = false;
    [SerializeField] internal bool middlePositionThrown = false;
    [SerializeField] internal bool rightPositionThrown = false;

    [Space]

    [SerializeField] internal int randomPositionNumber;
    [SerializeField] internal bool continueWhile = true;

    internal string animationName_RockRiseOne = "anim_RockRiseV1";
    internal string animationName_RockRiseTwo = "anim_RockRiseV2";
    internal string animationName_RockRiseThree = "anim_RockRiseV3";

    internal string animationName_RockFloatOne = "anim_RotateRockV1";
    internal string animationName_RockFloatTwo = "anim_RotateRockV2";
    internal string animationName_RockFloatThree = "anim_RotateRockV3";

    internal string animationName_RockThrowOne = "anim_ThrowRockV1";
    internal string animationName_RockThrowTwo = "anim_ThrowRockV2";
    internal string animationName_RockThrowThree = "anim_ThrowRockV3";

    private void Start()
    {
        SpawnRandomizedRocks();
        AnimateRockRise();

        StartCoroutine(WaitFor_AnimateRocksWindUp(1f));
        RandomizeThrownRock();
        StartCoroutine(WaitFor_DestroyRocks(30f));
    }


    private IEnumerator WaitFor_AnimateRocksWindUp(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        AnimateRocksWindUp();
    }

    private IEnumerator WaitFor_ThrowRock(float seconds, GameObject rock, string throwVersion)
    {
        yield return new WaitForSeconds(seconds);

        ThrowRock(rock, throwVersion);
    }

    private void RandomizeThrownRock()
    {
        for (int i = 0; i < bigRocksGame.Length; i++)
        {
            continueWhile = true;

            while (continueWhile)
            {
                randomPositionNumber = Random.Range(0, 3);

                if (randomPositionNumber == 0 && !leftPositionThrown)
                {
                    leftPositionThrown = true;
                    StartCoroutine(WaitFor_ThrowRock(5f, bigRocksGame[0], animationName_RockThrowOne));
                    continueWhile = false;
                }
                else if (randomPositionNumber == 1 && !middlePositionThrown)
                {
                    middlePositionThrown = true;
                    StartCoroutine(WaitFor_ThrowRock(8f, bigRocksGame[1], animationName_RockThrowTwo));
                    continueWhile = false;
                }
                else if (randomPositionNumber == 2 && !rightPositionThrown)
                {
                    rightPositionThrown = true;
                    StartCoroutine(WaitFor_ThrowRock(11f, bigRocksGame[2], animationName_RockThrowThree));
                    continueWhile = false;
                }
            }
        }
    }

    private IEnumerator WaitFor_DestroyRocks(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        DestroyRocks();
    }

    private void SpawnRandomizedRocks()
    {
        for (int i = 0; i < bigRocksGame.Length; i++)
        {
            continueWhile = true;

            while (continueWhile)
            {
                randomPositionNumber = Random.Range(0, 3);

                if (randomPositionNumber == 0 && !leftPositionTaken)
                {
                    leftPositionTaken = true;
                    bigRocksGame[i] = Instantiate(bigRocksPrefabs[i], leftPosition, Quaternion.Euler(0, 0, 0));
                    continueWhile = false;
                }
                else if (randomPositionNumber == 1 && !middlePositionTaken)
                {
                    middlePositionTaken = true;
                    bigRocksGame[i] = Instantiate(bigRocksPrefabs[i], middlePosition, Quaternion.Euler(0, 0, 0));
                    continueWhile = false;
                }
                else if (randomPositionNumber == 2 && !rightPositionTaken)
                {
                    rightPositionTaken = true;
                    bigRocksGame[i] = Instantiate(bigRocksPrefabs[i], rightPosition, Quaternion.Euler(0, 0, 0));
                    continueWhile = false;
                }
            }
        }
    }

    private void AnimateRockRise()
    {
        for (int i = 0; i < bigRocksGame.Length; i++)
        {
            if (i == 0)
            {
                bigRocksGame[i].GetComponent<Animator>().Play(animationName_RockRiseOne);
                continueWhile = false;
            }
            else if (i == 1)
            {
                bigRocksGame[i].GetComponent<Animator>().Play(animationName_RockRiseTwo);
                continueWhile = false;
            }
            else if (i == 2)
            {
                bigRocksGame[i].GetComponent<Animator>().Play(animationName_RockRiseThree);
                continueWhile = false;
            }
        }
    }

    private void AnimateRocksWindUp()
    {
        for (int i = 0; i < bigRocksGame.Length; i++)
        {
            if (i == 0)
            {
                AnimateRockFloat(bigRocksGame[i], animationName_RockFloatOne);
            }
            else if (i == 1)
            {
                AnimateRockFloat(bigRocksGame[i], animationName_RockFloatTwo);
            }
            else if (i == 2)
            {
                AnimateRockFloat(bigRocksGame[i], animationName_RockFloatThree);
            }
        }
    }

    private void AnimateRockFloat(GameObject rock, string floatVersion)
    {
        rock.GetComponent<Animator>().Play(floatVersion);
    }

    private void ThrowRock(GameObject rock, string throwVersion)
    {
        rock.GetComponent<Animator>().Play(throwVersion);
    }

    private void DestroyRocks()
    {
        for (int i = 0; i < bigRocksGame.Length; i++)
        {
            Destroy(bigRocksGame[i]);
        }
    }
}
