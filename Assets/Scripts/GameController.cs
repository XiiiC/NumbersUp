using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum ShopItemID
{
    PowerClick,
    AutoClick,
    MultiplyClick,
    TimeWarper,
    OfflineClicker,
    RandomClicker,
    GoldenClick,
    NumberGenerator,
    MagicCrystal,
    ExoplanetaryBeacon,
    NeuralNetworkInterface,
    EldritchMagic,
    TimeDilation,
    UnicornHorn,
    LeviathanScale,
    CosmicRayAmplifier,
    PlasmaCrystal,
    QuantumClicker,
    Necronomicon,
    TimeMachine,
    DarkMatterAmulet,
    HyperdriveClicker,
    NeuralNexusAmplifier,
    VoidSiphon,
    ElementalCatalyst,
    ExponentialClicker,
    WormholeGenerator,
    ChronoAccelerator,
    InfinityShard,
    CosmicSingularity,
    QuantumBlackHole,
    CelestialAmplifier,
    InfinityClicker
}

[Serializable]
public class ShopItem
{
    public ShopItemID itemId;
    public string itemName;
    public string itemDescription;
    public float itemCost;
    public bool itemPurchased;
    public long amountPurchased;

    public ShopItem(ShopItemID itemId, string itemName, string itemDescription, long itemCost, bool itemPurchased, long amountPurchased)
    {
        this.itemId = itemId;
        this.itemName = itemName;
        this.itemDescription = itemDescription;
        this.itemCost = itemCost;
        this.itemPurchased = itemPurchased;
        this.amountPurchased = amountPurchased;
    }
}

public class ShopInventory
{
    public List<ShopItem> shopItems;

    public ShopInventory()
    {
        shopItems = new List<ShopItem>()
        {
            new ShopItem(ShopItemID.PowerClick,              "Power Click",                  "Unleash the full potential of your clicking abilities with this upgrade. Each click will pack a bigger punch, allowing you to rack up numbers faster and more efficiently.",                                                   100,                    false, 0),
            new ShopItem(ShopItemID.AutoClick,               "Auto Click",                   "Why bother clicking manually when you can automate the process? This upgrade lets you sit back and watch as your numbers grow automatically, freeing up your time for more important things.",                                 500,                    false, 0),
            new ShopItem(ShopItemID.MultiplyClick,           "Multiply Click",               "Multiply your numbers with every click and watch them skyrocket! Each click will give you more than ever before, giving you a huge advantage in your number-gathering endeavors.",                                             1000,                   false, 0),
            new ShopItem(ShopItemID.TimeWarper,              "Time Warper",                  "Slow down time and watch as your numbers soar! With this upgrade, you can manipulate the very fabric of time to your advantage and gather numbers faster than ever before.",                                                   5000,                   false, 0),
            new ShopItem(ShopItemID.OfflineClicker,          "Offline Clicker",              "Why stop collecting numbers just because you're not playing? With this upgrade, you'll continue to gather numbers even when you're not actively playing the game, giving you a huge advantage over other players.",            10000,                  false, 0),
            new ShopItem(ShopItemID.RandomClicker,           "Random Clicker",               "Sometimes, a little bit of luck can go a long way. With this upgrade, you'll occasionally trigger a random event that gives you a bonus boost of numbers, helping you to stay ahead of the game.",                             50000,                  false, 0),
            new ShopItem(ShopItemID.GoldenClick,             "Golden Click",                 "Strike gold with this upgrade! Click on the golden button for a chance at massive number gain, giving you an advantage that other players can only dream of.",                                                                 100000,                 false, 0),
            new ShopItem(ShopItemID.NumberGenerator,         "Number Generator",             "Why settle for small numbers when you can generate extra ones? With this upgrade, you'll get an additional boost of numbers every second, helping you to climb the leaderboard faster than ever before.",                      500000,                 false, 0),
            new ShopItem(ShopItemID.MagicCrystal,            "Magic Crystal",                "Tap into the power of magic and use it to boost your number gain! This upgrade gives you access to ancient spells and enchantments, helping you to gather numbers more quickly and efficiently.",                              1000000,                false, 0),
            new ShopItem(ShopItemID.ExoplanetaryBeacon,      "Exoplanetary Beacon",          "Harness the power of nearby planets and watch your numbers soar! With this upgrade, you'll be able to tap into the energy of nearby planets and use it to your advantage, giving you a huge edge over other players.",         5000000,                false, 0),
            new ShopItem(ShopItemID.NeuralNetworkInterface,  "Neural Network Interface",     "Connect your brain to the game and gain a massive advantage! This upgrade uses advanced neural technology to enhance your number-gathering abilities, making you an unstoppable force in the game.",                           10000000,               false, 0),
            new ShopItem(ShopItemID.EldritchMagic,           "Eldritch Magic",               "Some say that forbidden magic comes at a cost, but with this upgrade, the benefits far outweigh the risks. Tap into ancient and powerful magic to gain massive numbers, leaving other players in the dust.",                   50000000,               false, 0),
            new ShopItem(ShopItemID.TimeDilation,            "Time Dilation",                "Slow down time and gain a huge advantage! With this upgrade, you can manipulate time to your advantage, making it seem as though the world around you is moving in slow motion while you gather numbers at lightning speed.",  100000000,              false, 0),
            new ShopItem(ShopItemID.UnicornHorn,             "Unicorn Horn",                 "Use the power of a unicorn to boost your numbers! This upgrade gives you access to the magic of unicorns, helping you to gather numbers more quickly and efficiently than ever before.",                                       500000000,              false, 0),
            new ShopItem(ShopItemID.LeviathanScale,          "Leviathan Scale",              "Harness the power of a leviathan to gain an edge in the game! This upgrade gives you access to the energy of these ancient and powerful creatures, helping you to climb the leaderboard with ease.",                           1000000000,             false, 0),
            new ShopItem(ShopItemID.CosmicRayAmplifier,      "Cosmic Ray Amplifier",         "Amplify the power of cosmic rays and watch your numbers soar! This upgrade gives you the ability to tap into the energy of the cosmos, allowing you to gather massive amounts of numbers in a short amount of time.",          5000000000,             false, 0),
            new ShopItem(ShopItemID.PlasmaCrystal,           "Plasma Crystal",               "Use the power of plasma to your advantage and gather numbers like never before! This upgrade gives you access to the energy of plasma, allowing you to harness its power to gain a massive advantage in the game.",            10000000000,            false, 0),
            new ShopItem(ShopItemID.QuantumClicker,          "Quantum Clicker",              "This cutting-edge clicker uses quantum mechanics to harness the power of the universe and gain massive numbers with every click.",                                                                                             50000000000,            false, 0),
            new ShopItem(ShopItemID.Necronomicon,            "Necronomicon",                 "This forbidden tome contains ancient knowledge and dark magic that can unlock incredible number gains for those brave enough to delve into its pages.",                                                                        100000000000,           false, 0),
            new ShopItem(ShopItemID.TimeMachine,             "Time Machine",                 "Step into this amazing machine and travel through time to gain massive numbers from the past, present, and future.",                                                                                                           500000000000,           false, 0),
            new ShopItem(ShopItemID.DarkMatterAmulet,        "Dark Matter Amulet",           "This mystical amulet harnesses the power of dark matter to enhance your number gains to unimaginable levels.",                                                                                                                 1000000000000,          false, 0),
            new ShopItem(ShopItemID.HyperdriveClicker,       "Hyperdrive Clicker",           "With this futuristic clicker, you can click at faster-than-light speeds to achieve massive numbers in record time.",                                                                                                           5000000000000,          false, 0),
            new ShopItem(ShopItemID.NeuralNexusAmplifier,    "Neural Nexus Amplifier",       "This incredible device enhances the power of your brain, allowing you to achieve massive number gains that were previously unimaginable.",                                                                                     10000000000000,         false, 0),
            new ShopItem(ShopItemID.VoidSiphon,              "Void Siphon",                  "Tap into the infinite energy of the void with this incredible device and increase your number gains to astronomical levels.",                                                                                                  50000000000000,         false, 0),
            new ShopItem(ShopItemID.ElementalCatalyst,       "Elemental Catalyst",           "This powerful catalyst unlocks the elemental forces of the universe, allowing you to achieve massive number gains by manipulating the very fabric of reality.",                                                                100000000000000,        false, 0),
            new ShopItem(ShopItemID.ExponentialClicker,      "Exponential Clicker",          "This clicker uses the power of exponential growth to achieve massive numbers with every click, making it one of the most powerful tools in your arsenal.",                                                                     500000000000000,        false, 0),
            new ShopItem(ShopItemID.WormholeGenerator,       "Wormhole Generator",           "Open up new pathways to the universe with this amazing generator and achieve massive number gains by traveling to new and exotic locations.",                                                                                  1000000000000000,       false, 0),
            new ShopItem(ShopItemID.ChronoAccelerator,       "Chrono Accelerator",           "This incredible device accelerates time itself, allowing you to achieve massive number gains in the blink of an eye.",                                                                                                         5000000000000000,       false, 0),
            new ShopItem(ShopItemID.InfinityShard,           "Infinity Shard",               "This rare and powerful shard contains the essence of infinity, allowing you to tap into its limitless power and achieve massive number gains beyond comprehension.",                                                           10000000000000000,      false, 0),
            new ShopItem(ShopItemID.CosmicSingularity,       "Cosmic Singularity",           "Harness the power of a cosmic singularity with this amazing device and achieve massive number gains on a scale that few can imagine.",                                                                                        50000000000000000,      false, 0),
            new ShopItem(ShopItemID.QuantumBlackHole,        "Quantum Black Hole",           "Create a quantum black hole with this incredible device and tap into the immense power of the universe to achieve massive number gains beyond belief.",                                                                        100000000000000000,     false, 0),
            new ShopItem(ShopItemID.CelestialAmplifier,      "Celestial Amplifier",          "This amazing amplifier harnesses the power of the stars and celestial bodies to amplify your number gains to incredible levels.",                                                                                              500000000000000000,     false, 0),
            new ShopItem(ShopItemID.InfinityClicker,         "Infinity Clicker",             "With this ultimate clicker, you can achieve infinite power and gain massive numbers beyond the limits of human comprehension.",                                                                                                1000000000000000000,    false, 0)

        };
    }
}
public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] public float currentScore = 0;
    [SerializeField] public float hitPower = 1f;
    [SerializeField] private float sips = 0f; //ScoreIncreasePerSecond
    [SerializeField] public float cps = 0f; //ClicksPerSecond
    [SerializeField] public float offlineMultiplier = 0.05f;
    [SerializeField] private float offlineScore;
    public double saveTime;
    public double loadTime;
    [SerializeField] private float saveTimer = 15f;

    [SerializeField] public ShopInventory shopInventory = new ShopInventory();
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private TMP_Text[] shopItemTxts = new TMP_Text[33];
    [SerializeField] private Button[] shopItemBtns = new Button[33];
    [SerializeField] private TMP_Text[] shopItemCostTxts = new TMP_Text[33];

    public void Save()
    {
        DateTime now = DateTime.Now;
        saveTime = (now - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

        SaveSystem.Save(this);
        Debug.Log("Game Saved");
    }
    public void Load()
    {
        DateTime now = DateTime.Now;
        PlayerData data = SaveSystem.Load();

        currentScore = data.score;
        hitPower = data.hitPower;
        cps = data.cps;
        saveTime = data.time;
        
        loadTime = (now - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

        for (int i = 0; i < shopInventory.shopItems.Count; i++)
        {
            shopInventory.shopItems[i].itemPurchased = data.itemPurchased[i];
            shopInventory.shopItems[i].amountPurchased = data.amountPurchased[i];
            shopInventory.shopItems[i].itemCost = data.itemCost[i];
        }

        offlineScore = (float)(loadTime - saveTime) * sips * offlineMultiplier;
        currentScore += offlineScore;

        UpdateShopItemTexts();
        ShopUnlockUpdate();
        UpdateUpgrades();
    }


    void Start()
    {    
        Load();
        UpdateShopItemTexts();
        ShopUnlockUpdate();
        UpdateUpgrades();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!PauseMenu.gameObject.activeSelf);
        }
    }
    void FixedUpdate()
    {
        if(currentScore < 10000000)
        {
            scoreTxt.text = (int)currentScore + "";
        }
        else if(currentScore >= 10000000 && currentScore < 1000000000)
        {
            scoreTxt.text = (int)currentScore / 1000 + "K";
        }
        else if(currentScore >= 1000000000 && currentScore < 1000000000000)
        {
            scoreTxt.text = (int)currentScore / 1000000 + "M";
        }
        sips = cps * Time.fixedDeltaTime;
        currentScore += sips;

        if(saveTimer <= 0)
        {
            Save();
            saveTimer = 15f;
        }
        else
        {
            saveTimer -= Time.fixedDeltaTime;
        }

    }

    public void Hit()
    {
        currentScore += hitPower;
        
    }

    private void UpdateShopItemTexts()
    { 
        for (int i = 0; i < shopItemTxts.Length; i++)
        {
            shopItemTxts[i].text = shopInventory.shopItems[i].itemName;
        }
        for(int i = 0; i < shopItemCostTxts.Length; i++)
        {
            shopItemCostTxts[i].text = Math.Truncate(shopInventory.shopItems[i].itemCost) + "";
        }
    }
    public void BuyItem(int itemIndex)
    {
        if (currentScore >= shopInventory.shopItems[itemIndex].itemCost)
        {
            currentScore -= shopInventory.shopItems[itemIndex].itemCost;
            shopInventory.shopItems[itemIndex].itemCost *= 1.2f;
            shopInventory.shopItems[itemIndex].itemPurchased = true;
            shopInventory.shopItems[itemIndex].amountPurchased += 1;
            UpdateShopItemTexts();
            ShopUnlockUpdate();
            UpdateUpgrades();
        }
    }
    public void ShopUnlockUpdate()
    {
        for(int i = 0; i < shopItemTxts.Length; i++)
        {
            if(shopInventory.shopItems[i].itemPurchased == true)
            {
                
                shopItemTxts[i+1].gameObject.SetActive(true);
                shopItemBtns[i+1].gameObject.SetActive(true);
                shopItemCostTxts[i+1].gameObject.SetActive(true);
            }
        }
    }
    private void UpdateUpgrades()
    {
        hitPower = 1;
        cps = 0;

        for(int i = 0; i < shopInventory.shopItems.Count; i++)
        {
            switch(i)
            {
                case 0: //PowerClicker
                    hitPower =  hitPower + (1 * shopInventory.shopItems[0].amountPurchased);
                    break;
                case 1: //AutoClicker
                    cps = cps + (1 * shopInventory.shopItems[1].amountPurchased);
                    break;
                case 2: //MultiClicker
                    if(shopInventory.shopItems[2].itemPurchased)
                        hitPower *= 1.2f * shopInventory.shopItems[2].amountPurchased;
                    break;
                case 3: //TimeWarper
                    if(shopInventory.shopItems[3].itemPurchased)
                        cps *= 1.5f * shopInventory.shopItems[3].amountPurchased;
                    break;
                case 4: //OfflineClicker
                    if(shopInventory.shopItems[4].itemPurchased)
                        offlineMultiplier *= shopInventory.shopItems[4].amountPurchased;
                    break;
                case 5: //RandomClicker
                    if(shopInventory.shopItems[5].itemPurchased)
                        RandomClick();
                    break;
                case 6: //GoldenClicker
                    //run GoldClicker function for 10 seconds then stop
                    if(shopInventory.shopItems[6].itemPurchased)
                    {
                        StartCoroutine(GoldenClick());
                    }
                    break;
                case 7: //NumberGenerator
                    if(shopInventory.shopItems[7].itemPurchased)
                        cps *= 5f * shopInventory.shopItems[7].amountPurchased;
                    break;
                case 8: //MagicCrystal
                    if(shopInventory.shopItems[8].itemPurchased)
                        hitPower += 10f * shopInventory.shopItems[8].amountPurchased;
                    break;
                case 9: //ExoplanetaryBeacon
                     if(shopInventory.shopItems[9].itemPurchased)
                        cps += 20f * shopInventory.shopItems[9].amountPurchased;
                    break;
                case 10: //NeuralNetworkInterface
                    if(shopInventory.shopItems[10].itemPurchased)
                        hitPower += 200f * shopInventory.shopItems[10].amountPurchased;
                    break;
                case 11: //EldritchMagic
                    if(shopInventory.shopItems[11].itemPurchased)
                        hitPower += 50f * shopInventory.shopItems[11].amountPurchased;
                    break;
                case 12: //TimeDilation
                    if(shopInventory.shopItems[12].itemPurchased)
                        cps += 50f * shopInventory.shopItems[12].amountPurchased;
                    break;
                case 13: //UnicornHorn
                    if(shopInventory.shopItems[13].itemPurchased)
                        hitPower += 100f * shopInventory.shopItems[13].amountPurchased;
                    break;
                case 14: //LeviathanScale
                    if(shopInventory.shopItems[14].itemPurchased)
                        hitPower += 150f * shopInventory.shopItems[14].amountPurchased;
                    break;
                case 15: //CosmicRayAmplifier
                    if(shopInventory.shopItems[15].itemPurchased)
                        cps += 100f * shopInventory.shopItems[15].amountPurchased;
                    break;
                case 16: //Plasma Crystal
                    if(shopInventory.shopItems[16].itemPurchased)
                        hitPower *= 5f * shopInventory.shopItems[16].amountPurchased;
                    break;
                case 17: //QuantumClicker
                    if(shopInventory.shopItems[17].itemPurchased)
                        hitPower *= 10f * shopInventory.shopItems[17].amountPurchased;
                    break;
                case 18: //Necronomicon
                    if(shopInventory.shopItems[18].itemPurchased)
                        cps *= 10f * shopInventory.shopItems[18].amountPurchased;
                    break;
                case 19: //TimeMachine
                    if(shopInventory.shopItems[19].itemPurchased)
                       cps *= 15f * shopInventory.shopItems[19].amountPurchased;
                    break;
                case 20: //DarkMatterAmulet
                    if(shopInventory.shopItems[20].itemPurchased)
                        hitPower *= 20f * shopInventory.shopItems[20].amountPurchased;
                    break;
                case 21: //HyperdriveClicker
                    if(shopInventory.shopItems[21].itemPurchased)
                        hitPower *= 25f * shopInventory.shopItems[21].amountPurchased;
                    break;
                case 22: //NeuralNexusAmplifier
                    if(shopInventory.shopItems[22].itemPurchased)
                        cps *= 20f * shopInventory.shopItems[22].amountPurchased;
                    break;
                case 23: //VoidSiphon
                    if(shopInventory.shopItems[23].itemPurchased)
                        hitPower *= 50f * shopInventory.shopItems[23].amountPurchased;
                    break;
                case 24: //ElementalCatalyst
                    if(shopInventory.shopItems[24].itemPurchased)
                        cps *= 50f * shopInventory.shopItems[24].amountPurchased;
                    break;
                case 25: //ExpontentialClicker
                    //function here
                    break;
                case 26: //WormholeGenerator
                    //function here
                    break;
                case 27: //ChronoAccelerator
                    //function here
                    break;
                case 28: //InfinityShard
                    //function here
                    break;
                case 29: //CosmicSingularity
                    //function here
                    break;  
                case 30: //QuantumBlackHole
                    //function here
                    break;
                case 31: //SelestialAmplifier
                    //function here
                    break;
                case 32: //InfinityClicker
                    //function here
                    break;


            }
        }
        
    }

    private void RandomClick()
    {
        hitPower += UnityEngine.Random.Range(0, 10) * shopInventory.shopItems[5].amountPurchased;
    }
    private IEnumerator GoldenClick()
    {
        hitPower *= 50f * shopInventory.shopItems[6].amountPurchased;
        yield return new WaitForSeconds(10);
        hitPower /= 50f * shopInventory.shopItems[6].amountPurchased;
    }

}
    



