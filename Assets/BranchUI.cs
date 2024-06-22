using UnityEngine;
using UnityEngine.UI;

public class BranchUI : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = Player.player.branchPoint.ToString() + "/5";
    }
}
