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
            initCrafting();

        }
        private void itemView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            this.itemView.ListViewItemSorter = new ItemViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            itemView.Sort();
        }
        private void craftingView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            this.craftingList.ListViewItemSorter = new CraftingViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            craftingList.Sort();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userName = this.playerText.Text;
            loadPlayer(userName);
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
        public void initCrafting() {
            craftingLoadPlayer.Text = userName;
            if(Crafting.displayLevel) {
                craftingCurLevel.Text = curPlayer.levels[12].ToString();
                if(curPlayer.levels[12] >= 99) {
                    craftingTargetLevel.Text = "99";
                }else {
                    craftingTargetLevel.Text = (curPlayer.levels[12] +1).ToString();
                }
            }else {
                 craftingCurLevel.Text = curPlayer.curxp[12].ToString();
                if(curPlayer.curxp[12] >= Definitions.xpreqs[98]) {
                    craftingTargetLevel.Text = Definitions.xpreqs[98].ToString();
                }else {
                    craftingTargetLevel.Text = (Definitions.xpreqs[curPlayer.levels[12]]).ToString();
                }
            }
            new Crafting();
            craftingList.Items.Clear();
            for (int i = 0; i < Crafting.listOfMethods.Count; i++)
            {
                craftingList.Items.Add(new ListViewItem(new string[] { ((SkillMethod)(Crafting.listOfMethods[i])).description, ((SkillMethod)(Crafting.listOfMethods[i])).totalbuyperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).totalsellperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).avgxperHour.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).gpperxpString }));
            }
            updateCrafting();
        }
        public void loadPlayer(String name) {
            userName = name;
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
                updateCrafting();
                reader.Close();
                response.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Player lookup failed.");
            }
        }
        public void updateSkills()
        {
            playerText.Text = userName;
            listView1.Items.Clear();
            for (int i = 0; i < 23; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { statinfo[i, 0], curPlayer.levels[i].ToString(), curPlayer.curxp[i].ToString("N0"), curPlayer.xpremaining[i].ToString("N0") }));
            }
        }
        public void updateCrafting() {
            craftingLoadPlayer.Text = userName;
            double bestGPHour = double.Parse(bestgpText.Text);
            if(bestGPHour <= 0.0) {
                bestGPHour = 0.1;
                bestgpText.Text = bestGPHour.ToString();
            }
            int totalcost;
            int goalxp, curxp;
            int current = int.Parse(craftingCurLevel.Text);
            int target = int.Parse(craftingTargetLevel.Text);
            if(Crafting.displayLevel) {
                if(curPlayer.levels[12] == current) {
                    curxp = curPlayer.curxp[12];
                    if(target > 0 && target <= 99) {
                        goalxp = Definitions.xpreqs[target - 1];
                    }else {
                        goalxp = curxp;
                    }
                }else {
                    if(current > 0 && current <= 99) {
                        curxp = Definitions.xpreqs[current - 1];
                    }else {
                        if(curPlayer != null) {
                            curxp = curPlayer.curxp[12];
                        }else {
                            curxp = 0;
                        }
                    }
                    if(target > 0 && target <= 99) {
                        goalxp = Definitions.xpreqs[target - 1];
                    }else {
                        goalxp = curxp;
                    }
                }
            }else {
                if(current > 0) {
                    curxp = current;
                }else {
                    curxp = 0;
                }
                if(target > current) {
                    goalxp = target;
                }else {
                    goalxp = current;
                }
            }
            int xptogain = goalxp - curxp;
            double timemoneymaking;
            double totaltimespent;
            String totalcostString;
            String timemoneymakingString;
            String totaltimespentString;
            craftingList.Items.Clear();
            for (int i = 0; i < Crafting.listOfMethods.Count;i++) {
                totalcost = (int)(xptogain * ((SkillMethod)Crafting.listOfMethods[i]).gpperxp);
                totalcostString = totalcost.ToString("N0") + " gp";
                timemoneymaking = (double)totalcost / (bestGPHour * 1000000);
                if(timemoneymaking < 0) {
                    timemoneymaking = 0;
                }
                timemoneymakingString = String.Format("{0:0.00}", timemoneymaking) + " Hours";
                totaltimespent = (xptogain / ((SkillMethod)Crafting.listOfMethods[i]).avgxperHour) + timemoneymaking;
                totaltimespentString = String.Format("{0:0.00}", totaltimespent) + " Hours";
                craftingList.Items.Add(new ListViewItem(new string[] { ((SkillMethod)(Crafting.listOfMethods[i])).description, ((SkillMethod)(Crafting.listOfMethods[i])).totalbuyperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).totalsellperaction.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).avgxperHour.ToString("N0"), ((SkillMethod)(Crafting.listOfMethods[i])).gpperxpString, totalcostString, timemoneymakingString,totaltimespentString}));
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

        private void craftingCalculate_Click(object sender, EventArgs e)
        {

            updateCrafting();
        }

        private void craftingLoad_Click(object sender, EventArgs e)
        {
            userName = craftingLoadPlayer.Text;
            loadPlayer(userName);
            initCrafting();
        }

        private void craftingRadioLevel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            if(temp.Checked) {
                Crafting.displayLevel = true;
                int temps = int.Parse(craftingCurLevel.Text);
                 if(temps < 0 || temps > Definitions.xpreqs[98]) {
                    craftingCurLevel.Text = "0";
                }else {
                    temps = Player.convertXpToLevel(temps);
                    craftingCurLevel.Text = temps.ToString();
                }
                temps = int.Parse(craftingTargetLevel.Text);
                if(temps < 0 || temps > Definitions.xpreqs[98]) {
                    craftingTargetLevel.Text = "0";
                }else {
                    temps = Player.convertXpToLevel(temps);
                    craftingTargetLevel.Text = temps.ToString();
                }
            }else {
                Crafting.displayLevel = false;
                int temps = int.Parse(craftingCurLevel.Text);
                if(temps < 1 || temps > 99) {
                    craftingCurLevel.Text = "0";
                }else {
                    craftingCurLevel.Text = Definitions.xpreqs[temps-1].ToString();
                }
                temps = int.Parse(craftingTargetLevel.Text);
                if(temps < 1 || temps > 99) {
                    craftingTargetLevel.Text = "0";
                }else {
                    craftingTargetLevel.Text = Definitions.xpreqs[temps-1].ToString();
                }
            }
        }
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
    public String gpperxpString;
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
        gpperxpString = String.Format("{0:0.00}", gpperxp);

    }

}