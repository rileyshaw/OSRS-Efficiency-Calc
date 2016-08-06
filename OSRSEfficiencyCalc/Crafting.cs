using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class CraftingViewItemComparer : IComparer
{
    private int col;
    public CraftingViewItemComparer(){
        col = 0;
    }
    public CraftingViewItemComparer(int column){
        col = column;
    }
    public int Compare(object x, object y){
        int returnVal = -1;
        if (col == 0){
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }else if(col == 3){
            String x1 = ((ListViewItem)x).SubItems[col].Text;
            String x2 = ((ListViewItem)y).SubItems[col].Text;
            double num1, num2;
            if (x1.Equals("")) {
                return 1;
            }else{
                num1 = double.Parse(x1);
            }
            if(x2.Equals("")){
                return -1;
            }else{
                num2 = double.Parse(x2);
            }
            if (num1 < num2){
                return 1;
            }else{
                return -1;
            }
        } else if(col == 5){
            String x1 = ((ListViewItem)x).SubItems[col].Text;
            String x2 = ((ListViewItem)y).SubItems[col].Text;
            x1 = x1.Remove(x1.Length - 3, 3);
            x2 = x2.Remove(x2.Length - 3, 3);
            double num1, num2;
            if (x1.Equals("")) {
                return 1;
            }else{
                num1 = double.Parse(x1);
            }
            if(x2.Equals("")){
                return -1;
            }else{
                num2 = double.Parse(x2);
            }
            if (num1 > num2){
                return 1;
            }else{
                return -1;
            }
        
        }else if(col == 6 || col == 7){
            String x1 = ((ListViewItem)x).SubItems[col].Text;
            String x2 = ((ListViewItem)y).SubItems[col].Text;
            x1 = x1.Remove(x1.Length - 6, 6);
            x2 = x2.Remove(x2.Length - 6, 6);
            double num1, num2;
            if (x1.Equals("")) {
                return 1;
            }else{
                num1 = double.Parse(x1);
            }
            if(x2.Equals("")){
                return -1;
            }else{
                num2 = double.Parse(x2);
            }
            if (num1 > num2){
                return 1;
            }else{
                return -1;
            }
        
        }else {
            try {
                String x1 = ((ListViewItem)x).SubItems[col].Text;
                String x2 = ((ListViewItem)y).SubItems[col].Text;
                double num1, num2;
                if (x1.Equals("")) {
                    return 1;
                }else{
                    num1 = double.Parse(x1);
                }
                if(x2.Equals("")){
                    return -1;
                }else{
                    num2 = double.Parse(x2);
                }
                if (num1 > num2){
                    return 1;
                }else{
                    return -1;
                }
            }catch(Exception e) {

            }
        }
        return returnVal;
    }
}

public class Crafting
{
    public static ArrayList listOfMethods;
    public static bool displayLevel = true;
    public Crafting()
    {
        listOfMethods = new ArrayList();
        SkillMethod temp = new SkillMethod("Gold amulet (unstrung)", new string[] { "Gold bar" }, new string[] { "Gold amulet (u)" }, 30, 1500);
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
        temp = new SkillMethod("Green D'hide", new string[] { "Green dragon leather", "Green dragon leather", "Green dragon leather", "Thread" }, new string[] { "Green d'hide body" }, 186, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Blue D'hide", new string[] { "Blue dragon leather", "Blue dragon leather", "Blue dragon leather", "Thread" }, new string[] { "Blue d'hide body" }, 210, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Red D'hide", new string[] { "Red dragon leather", "Red dragon leather", "Red dragon leather", "Thread" }, new string[] { "Red d'hide body" }, 234, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Black D'hide", new string[] { "Black dragon leather", "Black dragon leather", "Black dragon leather", "Thread" }, new string[] { "Black d'hide body" }, 258, 1650);
        listOfMethods.Add(temp);
        temp = new SkillMethod("Water Battlestaff", new string[] { "Battlestaff", "Water orb" }, new string[] { "Water battlestaff" }, 100, 2450);
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