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
            updateSkills();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void updateSkills()
        {
            listView1.Items.Clear();
            for (int i = 0; i < 23; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { statinfo[i, 0], curPlayer.levels[i].ToString(), curPlayer.curxp[i].ToString(), curPlayer.xpremaining[i].ToString() }));
            }
        }
        public void parseResponseFromHiScores(String str)
        {

        }
    }
}
public class Player
{
    String name;
    public int[] levels = new int[23];
    public int[] curxp = new int[23];
    public int[] xpremaining = new int[23];


    public Player()
    {
        name = "";
        for (int i = 0; i < 23; i++)
        {
            levels[i] = 1;
            curxp[i] = 0;
            xpremaining[i] = 83;
        }
    }
    public Player(String name,String response)
    {
        name = response.Replace("_", " ");
        char[] delimiterChars = { ',', '\n' };
        string[] words = response.Split(delimiterChars);
        for(int i = 0; i < 23; i++)
        {
            levels[i] = int.Parse(words[((i+1) * 3) + 1]);
            curxp[i] = int.Parse(words[((i + 1) * 3) + 2]);
            xpremaining[i] = getXpToLevel(curxp[i]);
        }
    }
    public int getXpToLevel(int curXp) {
        int lvl = 1;
        while (Definitions.xpreqs[lvl] < curXp)
        {
            lvl++;
            if(lvl == 99){
                return 0;
            }
        }
        return Definitions.xpreqs[lvl] - curXp;
    }

}
public class Definitions
{
    public static int[] xpreqs = {0,83,174,276,388,512,650,801,969,1154,
    1358,1584,1833,2107,2411,2746,3115,3523,3973,4470,5018,5624,6291,7028,
    7842,8740,9730,10824,12031,13363,14833,16456,18247,20224,22406,24815,27473,30408,
    33648,37224,41171,45529,50339,55649,61512,67983,75127,83014,91721,101333,
    111945,123660,136594,150872,166636,184040,203254,224466,247886,273742,302288,
    333804,368599,407015,449428,496254,547953,605032,668051,737627,814445,899257,992895,1096278,1210421,
    1336443,1475581,1629200,1798808,1986068,2192818,2421087,2673114,2951373,3258594,
    3597792,3972294,4385776,4842295,5346332,5902831,6517253,7195629,7944614,8771558,9684577,
    10692629,11805606,13034431};

}