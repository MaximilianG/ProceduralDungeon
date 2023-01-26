using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject[] walls; // 0 - Up 1 - Down 2 - Right 3 - Left
    public GameObject[] doors;
    public RoomType roomType;

    public enum RoomType { NORMAL = 0, BOSSROOM = 1 };

    public void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            doors[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);
        }
    }

    public bool HasOneDoor(bool[] status)
    {
        List<bool> results = new List<bool>();

        for (int j = 0; j < status.Length; j++)
        {
            if (status[j] == true)
            {
                results.Add(true);
            }
        }

        if (results.Count == 1)
            return true;

        return false;
    }
}
