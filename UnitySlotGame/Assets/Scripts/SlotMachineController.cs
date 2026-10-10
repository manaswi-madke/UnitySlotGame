
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlotMachineController : MonoBehaviour
{
    [Header("Reel Images")]
    public Image reel1;
    public Image reel2;
    public Image reel3;

    [Header("Slot Symbols")]
    public Sprite[] symbols;

    [Header("UI")]
    public Button spinButton;
    public TMP_Text resultText;

    [Header("Spin Settings")]
    public float spinDuration = 2f;
    public float symbolChangeInterval = 0.08f;

    [Header("Coins")]
    public TMP_Text balanceText;
    public int balance = 100;
    public int spinCost = 10;
    public int winReward = 50;

    
    [Header("Result Colors")]
    public Color winColor = Color.green;
    public Color loseColor = Color.white;


    private bool isSpinning = false;

    
public void Spin()
{
    if (isSpinning)
        return;

    if (symbols == null || symbols.Length == 0)
    {
        resultText.text = "No symbols assigned!";
        return;
    }

    if (balance < spinCost)
    {
        resultText.text = "Not enough coins!";
        return;
    }

    balance -= spinCost;
    UpdateBalance();

    StartCoroutine(SpinReels());
}



private void Start()
{
    UpdateBalance();
    resultText.text = "Ready to spin!";
    resultText.color = loseColor;
}

   

private IEnumerator SpinReels()
{
    isSpinning = true;
    spinButton.interactable = false;
    resultText.text = "";

    // Spin all three reels, gradually slowing them down.
    float elapsed = 0f;
    float currentInterval = symbolChangeInterval;

    while (elapsed < spinDuration)
    {
        reel1.sprite = GetRandomSymbol();
        reel2.sprite = GetRandomSymbol();
        reel3.sprite = GetRandomSymbol();

        float progress = elapsed / spinDuration;

        // Increase the delay as the animation progresses.
        currentInterval = Mathf.Lerp(
            symbolChangeInterval,
            0.30f,
            progress
        );

        yield return new WaitForSeconds(currentInterval);
        elapsed += currentInterval;
    }

    // Stop each reel one by one.
    reel1.sprite = GetRandomSymbol();
    yield return new WaitForSeconds(0.4f);

    reel2.sprite = GetRandomSymbol();
    yield return new WaitForSeconds(0.4f);

    reel3.sprite = GetRandomSymbol();

    // Check for a jackpot.
    if (reel1.sprite == reel2.sprite &&
        reel2.sprite == reel3.sprite)
    {
        resultText.text = "JACKPOT! +" + winReward + " COINS!";
        resultText.color = winColor;

        balance += winReward;
        UpdateBalance();
    }
    else
    {
        resultText.text = "Try Again!";
        resultText.color = loseColor;
    }

    isSpinning = false;
    spinButton.interactable = true;
}


    private Sprite GetRandomSymbol()
    {
        return symbols[Random.Range(0, symbols.Length)];
    }

    private void UpdateBalance() {
    balanceText.text = "Balance: " + balance;
    }

    
    public void RestartGame() {
      if (isSpinning)
        return;

      balance = 100;
      UpdateBalance();

    resultText.text = "Ready to spin!";
    resultText.color = loseColor;
}

}
