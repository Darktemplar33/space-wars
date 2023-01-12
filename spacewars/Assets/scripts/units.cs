using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class units : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnitSelections.Instance.unitList.Add(this.gameObject);
    }

   void OnDestory()
    {
        UnitSelections.Instance.unitList.Remove(this.gameObject);
    }
}
