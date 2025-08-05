using UnityEngine;
using UnityEngine.SceneManagement;

public class Scripede : MonoBehaviour
{
   public string nomedacena;

   public void carregar()
   {
      SceneManager.LoadScene(nomedacena);
   }
}
