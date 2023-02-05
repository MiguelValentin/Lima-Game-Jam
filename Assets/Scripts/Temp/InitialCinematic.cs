using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialCinematic : MonoBehaviour
{
    public void FinishedAnimatic()
    {
        GameManager.Instance.ChangeRoom(1);
    }
}
