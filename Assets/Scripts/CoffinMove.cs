using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coffin;
    public GameObject XROrigin;
    public void moveCoffin()

    {
        Vector3 movedirection = new Vector3(0, 3, 0);
        Vector3 new_player_position = new Vector3(coffin.transform.position.x, coffin.transform.position.y, coffin.transform.position.z);

        // move coffin transform up
        // StartCoroutine(MoveToPosition(coffin.transform, coffin.transform.position + movedirection, 2));
        coffin.transform.Translate(movedirection);

        // move xrorigin to coffin transform after
        XROrigin.transform.position = new_player_position;
        XROrigin.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(-90,0,0));

        // wait 2 seconds
        // System.Threading.Thread.Sleep(2000);

        // move coffin transform down
        // StartCoroutine(MoveToPosition(coffin.transform, coffin.transform.position - 2/3*movedirection, 2));
        coffin.transform.Translate(-2/3*movedirection);
        coffin.transform.GetChild(0).gameObject.SetActive(false);

        // wait 1 second
        System.Threading.Thread.Sleep(1000);

        // position = new Vector3(coffin.transform.position.x, coffin.transform.position.y + 1, coffin.transform.position.z);
        // XROrigin.transform.position = new Vector3(coffin.transform.position.x, coffin.transform.position.y, coffin.transform.position.z);
        // System.Threading.Thread.Sleep(1000);
        // coffin.transform.position = new Vector3(coffin.transform.position.x, coffin.transform.position.y - 1, coffin.transform.position.z);
        // System.Threading.Thread.Sleep(1000);
    }

//     public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
// {
//       var currentPos = transform.position;
//       var t = 0f;
//       while(t <= 1f)
//       {
//              t += Time.deltaTime / timeToMove;
//              transform.position = Vector3.Lerp(currentPos, position, t);
//              yield return null;
//       }
//       transform.position = position;
// }
}
