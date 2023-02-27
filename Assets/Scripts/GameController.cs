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
    public long itemCost;
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
            new ShopItem(ShopItemID.CosmicSingularity,        "Cosmic Singularity",           "Harness the power of a cosmic singularity with this amazing device and achieve massive number gains on a scale that few can imagine.",                                                                                        50000000000000000,      false, 0),
            new ShopItem(ShopItemID.QuantumBlackHole,        "Quantum Black Hole",           "Create a quantum black hole with this incredible device and tap into the immense power of the universe to achieve massive number gains beyond belief.",                                                                        100000000000000000,     false, 0),
            new ShopItem(ShopItemID.CelestialAmplifier,      "Celestial Amplifier",          "This amazing amplifier harnesses the power of the stars and celestial bodies to amplify your number gains to incredible levels.",                                                                                              500000000000000000,     false, 0),
            new ShopItem(ShopItemID.InfinityClicker,         "Infinity Clicker",             "With this ultimate clicker, you can achieve infinite power and gain massive numbers beyond the limits of human comprehension.",                                                                                                1000000000000000000,    false, 0)

        };
    }
}
public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private float currentScore;
    [SerializeField] private float hitPower;
    [SerializeField] private float sips; //ScoreIncreasePerSecond
    [SerializeField] private float x;

    [SerializeField] public ShopInventory shopInventory = new ShopInventory();

    [SerializeField] private TMP_Text[] shopItemTxts = new TMP_Text[33];
    [SerializeField] private Button[] shopItemBtns = new Button[33];
    [SerializeField] private TMP_Text[] shopItemCostTxts = new TMP_Text[33];


    void Start()
    {
        currentScore = 0f;
        hitPower = 1f;
        sips =  1f;
        x = 0;
        
        UpdateShopItemTexts();
        
    }

    void Update()
    {
        scoreTxt.text = (int)currentScore + "";
        sips = x * Time.deltaTime;
        currentScore += sips;

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
            shopItemCostTxts[i].text = shopInventory.shopItems[i].itemCost + "";
        }
    }
    public void BuyItem(int itemIndex)
    {
        if (currentScore >= shopInventory.shopItems[itemIndex].itemCost)
        {
            currentScore -= shopInventory.shopItems[itemIndex].itemCost;
            shopInventory.shopItems[itemIndex].itemCost *= 2;
            shopInventory.shopItems[itemIndex].itemPurchased = true;
            UpdateShopItemTexts();
            ShopUnlockUpdate();
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
}
