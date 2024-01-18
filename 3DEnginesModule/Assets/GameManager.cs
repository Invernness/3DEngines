using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] CoherenceBridge Bridge;
    GameObject player;
    [SerializeField] GameObject currencyObject;

    float Timer = 60f;

    int playerPointer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Bridge = GameObject.FindGameObjectWithTag("Bridge").GetComponent<CoherenceBridge>();
        Bridge.ClientConnections.OnCreated += ClientConnections_OnCreated;
    }

    private void ClientConnections_OnCreated(CoherenceClientConnection obj)
    {

        CoherenceClientConnection selectedConnection = Bridge.ClientConnections.Get(obj.ClientId);

        player = selectedConnection.GameObject;

        if(playerPointer == 0)
        {
            player.transform.GetChild(0).gameObject.SetActive(true);
        }
        if (playerPointer == 1)
        {
            player.transform.GetChild(1).gameObject.SetActive(true);
            currencyObject.GetComponent<CurrencyManager>().enabled = true;
            Invoke("UpdateTimer", 1);
        }

        playerPointer++;
    }

    void UpdateTimer()
    {
        Timer = Timer - 1;
        Invoke("UpdateTimer", 1);
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = Timer.ToString();

        if(Timer <= 0)
        {
            Timer = 0;
            GameOver();
        }

    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
