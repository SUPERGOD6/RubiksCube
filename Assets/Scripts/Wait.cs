using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour {
                                
	public IEnumerator Start()
  {
    yield return StartCoroutine(wait());

  }
  
  public IEnumerator wait()
  {
    yield return new WaitForSecondsRealtime(0.1f);
  }
  
}
