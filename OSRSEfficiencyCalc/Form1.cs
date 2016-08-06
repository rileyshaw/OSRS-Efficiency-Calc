using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace OSRSEfficiencyCalc
{
 
    public partial class Form1 : Form
    {
        Player curPlayer;
        String userName;

        String[,] statinfo = new String[23,4];
        public Form1()
        {
            InitializeComponent();
            statinfo[0, 0] = "Attack";
            statinfo[1, 0] = "Defence";
            statinfo[2, 0] = "Strength";
            statinfo[3, 0] = "Hitpoints";
            statinfo[4, 0] = "Ranged";
            statinfo[5, 0] = "Prayer";
            statinfo[6, 0] = "Magic";
            statinfo[7, 0] = "Cooking";
            statinfo[8, 0] = "Woodcutting";
            statinfo[9, 0] = "Fletching";
            statinfo[10, 0] = "Fishing";
            statinfo[11, 0] = "Firemaking";
            statinfo[12, 0] = "Crafting";
            statinfo[13, 0] = "Smithing";
            statinfo[14, 0] = "Mining";
            statinfo[15, 0] = "Herblore";
            statinfo[16, 0] = "Agility";
            statinfo[17, 0] = "Thieving"; 
            statinfo[18, 0] = "Slayer";
            statinfo[19, 0] = "Farming";
            statinfo[20, 0] = "Runecrafting";
            statinfo[21, 0] = "Hunter";
            statinfo[22, 0] = "Construction";
            curPlayer = new Player();
            updatePricing();
            updateSkills();
            updateCrafting();
        }
        private void itemView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            this.itemView.ListViewItemSorter = new ItemViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            listView1.Sort();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userName = this.playerText.Text;
            userName = userName.Replace(' ', '_');
            WebRequest request = WebRequest.Create("http://services.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + userName);
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            try {
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                curPlayer = new Player(userName, responseFromServer);
                updateSkills();
                // Clean up the streams and the response.
                reader.Close();
                response.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Player lookup failed.");
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updatePricing();
        }
        private void itemView_MouseDoubleClick(object sender, EventArgs e)
        {
            if (itemView.SelectedItems.Count > 0) {
                var item = itemView.SelectedItems[0];
                if (item.ToString().Length != 0) {
                    Item temp = ItemData.getItem(item.Text);
                    System.Diagnostics.Process.Start("https://rsbuddy.com/exchange/?id=" + temp.id);
                }
                    
            }
        }
        int prevcharCount = 0;
        public void searchPricingFilter(String search) {
            if(search.Length < 2) {
                if (prevcharCount < search.Length) {
                    return;
                }
            }
            itemView.Items.Clear();
            for (int i = 0; i < ItemData.itemList.Count; i++)
            {
                String temp = ((Item)(ItemData.itemList[i])).name.ToLower();
                search = search.ToLower();
                if (temp.Contains(search)) {
                    itemView.Items.Add(new ListViewItem(new string[] { ((Item)(ItemData.itemList[i])).name, ((Item)(ItemData.itemList[i])).buy_average.ToString("N0"), ((Item)(ItemData.itemList[i])).sell_average.ToString("N0"), ((Item)(ItemData.itemList[i])).marginString }));
                }
            }
        }
        public void updateSkills()
        {
            listView1.Items.Clear();
            for (int i = 0; i < 23; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { statinfo[i, 0], curPlayer.levels[i].ToString(), curPlayer.curxp[i].ToString("N0"), curPlayer.xpremaining[i].ToString("N0") }));
            }
        }
        public void updateCrafting() {
            new Crafting();
            craftingList.Items.Clear();
            for (int i = 0; i < Crafting.listOfMethods.Count; i++)
            {
                craftingList.Items.Add(new ListViewItem(new string[] { ((SkillMethod)(Crafting.listOfMethods[i])).description, ((SkillMethod)(Crafting.listOfMethods[i])).totalbuyperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).totalsellperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).avgxperHour.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).gpperxp.ToString() }));
            }
        }
        public void updatePricing()
        {
            new ItemData();
            itemView.Items.Clear();
            for (int i = 0; i < ItemData.itemList.Count; i++)
            {
                itemView.Items.Add(new ListViewItem(new string[] { ((Item)(ItemData.itemList[i])).name, ((Item)(ItemData.itemList[i])).buy_average.ToString("N0"), ((Item)(ItemData.itemList[i])).sell_average.ToString("N0"), ((Item)(ItemData.itemList[i])).marginString }));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchPricingFilter(textBoxSearch.Text);
        }

      
    }
}
public class Crafting {
    public static ArrayList listOfMethods;
    public Crafting() {
        listOfMethods = new ArrayList();
        SkillMethod temp = new SkillMethod("Gold amulet (unstrung)", new string[] { "Gold bar" }, new string[] { "Gold amulet (u)" },30,1500);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Sapphire", new string[] { "Uncut sapphire" }, new string[] { "Sapphire" }, 50, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Emerald", new string[] { "Uncut emerald" }, new string[] { "Emerald" }, 67.5, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Ruby", new string[] { "Uncut ruby" }, new string[] { "Ruby" }, 85, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Diamond", new string[] { "Uncut diamond" }, new string[] { "Diamond" }, 107.5, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Dragonstone", new string[] { "Uncut dragonstone" }, new string[] { "Dragonstone" }, 137.5, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Onyx", new string[] { "Uncut onyx" }, new string[] { "Onyx" }, 167.5, 2700);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Green D'hide", new string[] { "Green dragon leather","Green dragon leather","Green dragon leather","Thread" }, new string[] { "Green d'hide body" }, 186, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Blue D'hide", new string[] { "Blue dragon leather", "Blue dragon leather", "Blue dragon leather", "Thread" }, new string[] { "Blue d'hide body" }, 210, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Red D'hide", new string[] { "Red dragon leather", "Red dragon leather", "Red dragon leather", "Thread" }, new string[] { "Red d'hide body" }, 234, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Black D'hide", new string[] { "Black dragon leather", "Black dragon leather", "Black dragon leather", "Thread" }, new string[] { "Black d'hide body" }, 258, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Water Battlestaff", new string[] { "Battlestaff", "Water orb"}, new string[] { "Water battlestaff" }, 100, 2450);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Earth Battlestaff", new string[] { "Battlestaff", "Earth orb" }, new string[] { "Earth battlestaff" }, 112.5, 2450);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Fire Battlestaff", new string[] { "Battlestaff", "Fire orb" }, new string[] { "Fire battlestaff" }, 125, 2450);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Air Battlestaff", new string[] { "Battlestaff", "Air orb" }, new string[] { "Air battlestaff" }, 137.5, 2450);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Unpowered Orbs", new string[] { "Molten glass" }, new string[] { "Unpowered orb" }, 52.5, 1523);
        listOfMethods.Add(temp);
    }
}
public class SkillMethod {
    public String description;
    public ArrayList itemsToBuy;
    public ArrayList itemsToSell;
    public int totalbuyperaction = 0;
    public int totalsellperaction = 0;

    public double avgxperHour = 0;
    public double xpPerAction = 0;
    public int actionsPerHour = 0;
    public double gpperxp = 0;
    public int gpperAction = 0;

    public SkillMethod(String desc, String[] iToBuy, String[] iToSell, double xpaction, int actionhour) {
        description = desc;
        itemsToBuy = new ArrayList();
        for(int i = 0; i < iToBuy.Length;i++) {
            Item temp = ItemData.getItem(iToBuy[i]);
            itemsToBuy.Add(temp);
        }
        itemsToSell = new ArrayList();
        for (int i = 0; i < iToSell.Length; i++){
            Item temp = ItemData.getItem(iToSell[i]);
            itemsToSell.Add(temp);
        }
        xpPerAction = xpaction;
        actionsPerHour = actionhour;
        avgxperHour = xpPerAction * actionsPerHour;

        for (int i = 0; i < itemsToBuy.Count;i++) {
            totalbuyperaction += ((Item)(itemsToBuy[i])).overall_average;
        }
        for (int i = 0; i < itemsToSell.Count; i++){
            totalsellperaction += ((Item)(itemsToSell[i])).overall_average;
        }
        gpperAction = totalbuyperaction - totalsellperaction;
        gpperxp = (double)gpperAction / (double)xpPerAction;

    }

}