using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleFloor : MonoBehaviour
{
    //効果音
    public AudioClip FindSE;
    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player") && mesh.enabled == false){
           
            //この1行で「Mesh Renderer」にチェックが入った状態に。
            //ゲームを再生して、触れた瞬間にチェックが入ることを確認。
            mesh.enabled = true;
            
            //効果音
            AudioSource.PlayClipAtPoint(FindSE, transform.position);
        }
    }
}
