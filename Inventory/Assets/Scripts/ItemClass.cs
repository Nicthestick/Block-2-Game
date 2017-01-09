using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ItemClass : MonoBehaviour{
    //Icons
    static public Texture2D knifeIcon;
    static public Texture2D macheteIcon;
    static public Texture2D arrowIcon;
    static public Texture2D groudIcon;
    static public Texture2D HpIcon;
    static public Texture2D axeIcon;
    static public Texture2D torchIcon;
    static public Texture2D bowIcon;
    static public Texture2D spearIcon;
    static public Texture2D boltIcon;
    static public Texture2D crossbowIcon;
    static public Texture2D pemmicanIcon;
    static public Texture2D firebombIcon;
    static public Texture2D healpotionIcon;
    static public Texture2D poisonIcon;
    static public Texture2D metalarmorIcon;
    static public Texture2D clotharmorIcon;
    static public Texture2D stringIcon;
    static public Texture2D leatherIcon;


    //Items
    public ItemCreatorClass knifeItem = new ItemCreatorClass(0, "Knife", knifeIcon, "It is used to do basic actions for skinning/cooking/fighting.", -1, 4, 3);
    public ItemCreatorClass macheteItem = new ItemCreatorClass(1, "Machete", macheteIcon, "A sharp blade with many uses, from slicing up your enemies to cutting meat when cooking.", 200, 7, 4);
    public ItemCreatorClass arrowItem = new ItemCreatorClass(2, "Arrow", arrowIcon, "Great for hunting deer and such, and decent for keeping enemies at a distance.", 0, 0, 1);
    public ItemCreatorClass groudItem = new ItemCreatorClass(3, "Groud", groudIcon, "Gourd that grows as commonly as weeds", 0, 0, 0);
    public ItemCreatorClass hpItem = new ItemCreatorClass(4, "Health Potion", HpIcon, "Drink to heal", 0, 0, 0);
    public ItemCreatorClass axeItem = new ItemCreatorClass(5, "Axe", axeIcon, "Heavier than a machete, this axe hits harder than anyone would expect.", 120, 4, 8);
    public ItemCreatorClass torchItem = new ItemCreatorClass(6, "Torch", torchIcon, "Used tp scare animals and to see when it's dark.", 0, 0, 0);
    public ItemCreatorClass bowItem = new ItemCreatorClass(6, "Bow", bowIcon, "Most effective to use for hunting and stealthy kills.", 75, 8, 4);
    public ItemCreatorClass spearItem = new ItemCreatorClass(8, "Spear", spearIcon, "Spears are high damage projectiles, use them wisely!", 20, 2, 9);
    public ItemCreatorClass boltItem = new ItemCreatorClass(9, "Crossbow Bolt", boltIcon, "Hitting something with one of these will probably stop them in their tracks.", 0, 0, 0);
    public ItemCreatorClass crossbowItem = new ItemCreatorClass(10, "Crossbow", crossbowIcon, "Very effective to shoot down enemies that you rather would not have up close. Slower reload rate than a standard bow.", 100, 6, 7);
    public ItemCreatorClass pemmicanItem = new ItemCreatorClass(11, "Pemmican", pemmicanIcon, "Dried up meat and berries are not the greatest combination, but it stays good up to 24 months.", 0, 0, 0);
    public ItemCreatorClass firebombItem = new ItemCreatorClass(12, "Fire Bomb", firebombIcon, "A gourd filled with flammable ingredients make up this deadly weapon", 1, 4, 10);
    public ItemCreatorClass healpotionItem = new ItemCreatorClass(13, "Heal Potion", healpotionIcon, "A mix of ingredients to heal up wounds, kids get taught this recipe at a really young age.", 0, 0, 0);
    public ItemCreatorClass poisonItem = new ItemCreatorClass(14, "Poison", poisonIcon, "Adding this poison on anything will kill an enemy quickly once it enters the body", 0, 0, 0);
    public ItemCreatorClass metalarmorItem = new ItemCreatorClass(15, "Metal Armor", metalarmorIcon, "Body armor that protects versus bullets and can deflect other projectiles, very useful in any fight.", 250, 0, 0);
    public ItemCreatorClass clotharmorItem = new ItemCreatorClass(16, "Cloth Armor", clotharmorIcon, "Cloth armor helps reducing damage from incoming strikes and projectiles, very light set of armor.", 150, 0, 0);
    public ItemCreatorClass stringITem = new ItemCreatorClass(17, "String", stringIcon, "Strings are a part of many items, very useful while crafting.", 0, 0, 0);
    public ItemCreatorClass leather = new ItemCreatorClass(18, "Leather", leatherIcon, "Leather made from animal skins, can be made into armor and other things.", 0, 0, 0);

    public class ItemCreatorClass
    {
        public int itemId;
        public string itemName;
        public Texture2D icon;
        public string description;
        public int value;
        public int speed;
        public int power;

        public ItemCreatorClass(int id, string name, Texture2D icn, string desc, int val, int spd, int pwr)
        {
            itemId = id;
            itemName = name;
            icon = icn;
            description = desc;
            value = val;
            speed = spd;
            power = pwr;
        }
    }
}
