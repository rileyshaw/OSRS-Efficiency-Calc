using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSRSEfficiencyCalc
{

   
}
 public class ItemData
    {
        public static ArrayList itemList = new ArrayList();
        public ItemData()
        {
            itemList.Clear();
            WebRequest request = WebRequest.Create("https://rsbuddy.com/exchange/summary.json");
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            try
            {
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string jsonResponse = reader.ReadToEnd();

                //dynamic listOfItems = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
                char[] delimiterChars = { '{', '"',':',',','}' };
                String[] words = jsonResponse.Split(delimiterChars);
                words = words.Where(x => !x.Equals(" ") ).ToArray();
                words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                for(int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim(' ');
                }
                for(int i = 0; i< words.Length / 15; i++)
                {
                    int buy, sell, id, sp, avg;
                    String name;
                    bool mem = false;
                    //int buy,int sell, int _id, int _sp, String _name, bool _mem, int _avg
                    if (words[(i * 15) + 1].Equals("sp")){
                        sp = int.Parse(words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("sp")){
                        sp = int.Parse(words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("sp")){
                        sp = int.Parse(words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("sp")){
                        sp = int.Parse(words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("sp")){
                        sp = int.Parse(words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("sp")) { 
                        sp = int.Parse(words[(i * 15) + 12]);
                    }else{
                        sp = int.Parse(words[(i * 15) + 14]);
                    }

                    if (words[(i * 15) + 1].Equals("buy_average")) {
                        buy = int.Parse(words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("buy_average")){
                        buy = int.Parse(words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("buy_average")){
                        buy = int.Parse(words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("buy_average")){
                        buy = int.Parse(words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("buy_average")){
                        buy = int.Parse(words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("buy_average")){
                        buy = int.Parse(words[(i * 15) + 12]);
                    }else{
                        buy = int.Parse(words[(i * 15) + 14]);
                    }

                    if(words[(i * 15) + 1].Equals("id")) {
                        id = int.Parse(words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("id")){
                        id = int.Parse(words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("id")){
                        id = int.Parse(words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("id")){
                        id = int.Parse(words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("id")){
                        id = int.Parse(words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("id")){
                        id = int.Parse(words[(i * 15) + 12]);
                    }else{
                        id = int.Parse(words[(i * 15) + 14]);
                    }

                    if(words[(i * 15) + 1].Equals("sell_average")) {
                        sell = int.Parse(words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("sell_average")){
                        sell = int.Parse(words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("sell_average")){
                        sell = int.Parse(words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("sell_average")){
                        sell = int.Parse(words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("sell_average")){
                        sell = int.Parse(words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("sell_average")){
                        sell = int.Parse(words[(i * 15) + 12]);
                    }else{
                        sell = int.Parse(words[(i * 15) + 14]);
                    }

                    if(words[(i * 15) + 1].Equals("overall_average")) {
                        avg = int.Parse(words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("overall_average")){
                        avg = int.Parse(words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("overall_average")){
                        avg = int.Parse(words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("overall_average")){
                        avg = int.Parse(words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("overall_average")){
                        avg = int.Parse(words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("overall_average")){
                        avg = int.Parse(words[(i * 15) + 12]);
                    }else{
                        avg = int.Parse(words[(i * 15) + 14]);
                    }

                    if(words[(i * 15) + 1].Equals("name")) {
                        name = (words[(i * 15) + 2]);
                    }else if(words[(i * 15) + 3].Equals("name")){
                        name = (words[(i * 15) + 4]);
                    }else if (words[(i * 15) + 5].Equals("name")){
                        name = (words[(i * 15) + 6]);
                    }else if (words[(i * 15) + 7].Equals("name")){
                        name = (words[(i * 15) + 8]);
                    }else if (words[(i * 15) + 9].Equals("name")){
                        name = (words[(i * 15) + 10]);
                    }else if (words[(i * 15) + 11].Equals("name")){
                        name = (words[(i * 15) + 12]);
                    }else{
                        name = (words[(i * 15) + 14]);
                    }

                    if(words[(i * 15) + 1].Equals("members")) {
                        if((words[(i * 15) + 2]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else if(words[(i * 15) + 3].Equals("members")){
                      if((words[(i * 15) + 4]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else if (words[(i * 15) + 5].Equals("members")){
                       if((words[(i * 15) + 6]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else if (words[(i * 15) + 7].Equals("members")){
                       if((words[(i * 15) + 8]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else if (words[(i * 15) + 9].Equals("members")){
                        if((words[(i * 15) + 10]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else if (words[(i * 15) + 11].Equals("members")){
                        if((words[(i * 15) + 12]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }else{
                        if((words[(i * 15) + 14]).Equals("true")){
                            mem = true;
                        }else {
                            mem = false;
                        }
                    }


                    Item temp = new Item(buy, sell,id ,sp, name,mem, avg);
  
                    itemList.Add(temp);

                }
                reader.Close();
                response.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("OSBuddy price check is down");
            }
        }
        public static Item getItem(String name)
        {
            for(int i = 0;i < itemList.Count;i++) {
                if(((Item)itemList[i]).name.Equals(name)){
                    return ((Item)itemList[i]);
                }
            }
            MessageBox.Show("Couldnt Find item: " + name);
            return null;
        }

    }
class ItemViewItemComparer : IComparer
{
    private int col;
    public ItemViewItemComparer()
    {
        col = 0;
    }
    public ItemViewItemComparer(int column)
    {
        col = column;
    }
    public int Compare(object x, object y)
    {
        int returnVal = -1;
        if (col == 0)
        {
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
        else
        {
            String x1 = ((ListViewItem)x).SubItems[col].Text;
            String x2 = ((ListViewItem)y).SubItems[col].Text;
            double num1, num2;
            if (x1.Equals(""))
            {
                return 1;
            }
            else
            {
                x1 = x1.Replace('%', ' ');
                num1 = double.Parse(x1);
            }
            if (x2.Equals(""))
            {
                return -1;
            }
            else
            {
                x2 = x2.Replace('%', ' ');
                num2 = double.Parse(x2);
            }
            if (num1 < num2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        return returnVal;
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
public class Item
{
    public int buy_average;
    public int sell_average;
    public int id;
    public int sp;
    public String name;
    public bool members;
    public int overall_average;
    public double margin = 0;
    public String marginString;
    public Item(int buy, int sell, int _id, int _sp, String _name, bool _mem, int _avg)
    {
        buy_average = buy;
        sell_average = sell;
        id = _id;
        sp = _sp;
        name = _name;
        members = _mem;
        overall_average = _avg;
        if (buy != 0 && sell != 0)
        {
            if (buy > sell)
            {
                margin = ((double)buy / (double)sell) - 1;
            }
            else
            {
                margin = ((double)sell / (double)buy) - 1;
            }
            margin = margin * 100;
            marginString = String.Format("{0:0.00}", margin) + "%";
        }
    }

}
