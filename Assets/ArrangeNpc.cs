using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangeNpc : GameAbs
{
    [SerializeField] public List<Transform> positions = new List<Transform>(); // 4 vị trí đặt thủ công trong editor
    private Dictionary<GameObject, Transform> occupiedPositions = new Dictionary<GameObject, Transform>();

    // Random vị trí trống cho NPC
    public Transform GetRandomAvailablePosition()
    {
        List<Transform> available = new List<Transform>();
        foreach (var pos in positions)
        {
            if (!occupiedPositions.ContainsValue(pos)) // return vị trí chưa bị chiếm thêm nó vào danh sách available
                available.Add(pos);
        }

        if (available.Count == 0) return null;

        int randIdx = Random.Range(0, available.Count);
        return available[randIdx];
    }

    // NPC vào vị trí
    public bool AssignNpcToPosition(GameObject npc, Transform pos)
    {
        if (pos != null)
        {
            occupiedPositions[npc] = pos;
            npc.transform.position = pos.position;
            return true;
        }
        return false;
    }

    // NPC rời vị trí (ví dụ sau khi hoàn thành order)
    public void ReleaseNpcPosition(GameObject npc)
    {
        if (occupiedPositions.ContainsKey(npc))
        {
            occupiedPositions.Remove(npc);
        }
    }


    

    public bool IsFull()
    {
    return occupiedPositions.Count >= positions.Count;
    }
    

    
}
