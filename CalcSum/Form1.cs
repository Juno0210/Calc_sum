using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            // Read input values from textboxes
            int baseCost = int.Parse(tb_baseCost.Text);
            int currentLevel = int.Parse(tb_curLvl.Text);
            int availableResources = int.Parse(tb_resource.Text);
            double x = double.Parse(tb_X.Text);

            // Determine how many levels can be bought with the available resources
            //int maxLevel = (int)Math.Floor(Math.Log(availableResources / baseCost, x) - currentLevel);

            // Calculate the total cost of upgrading to the maximum level
            //double totalCost = baseCost * (Math.Pow(x, maxLevel + currentLevel) - Math.Pow(x, currentLevel)) / (x - 1);

            int maxLevel = (int)Math.Floor(Math.Log(availableResources / baseCost * (x - 1) / (baseCost * x - availableResources) + 1) / Math.Log(x));
            double totalCost = (baseCost * (Math.Pow(x, maxLevel) - 1)) / (x - 1);

            
            // Display the result
            tb_maxLvl.Text = maxLevel.ToString();
            tb_total.Text = totalCost.ToString("###,###,###.##");

        }

        private double UpgradeCost(double baseCost, int level, double x)
        {
            return (baseCost + baseCost * level) * Math.Pow(x, level);
        }

        private int GetMaxLevel(double baseCost, int currentLevel, double availableResources, double x)
        {
            double cost = UpgradeCost(baseCost, currentLevel, x);

            if (cost > availableResources)
            {
                return currentLevel - 1;
            }

            return GetMaxLevel(baseCost, currentLevel + 1, availableResources - cost, x);
        }

        private double GetTotalCost(double baseCost, int currentLevel, int maxLevel, double x)
        {
            if (currentLevel > maxLevel)
            {
                return 0;
            }

            double cost = UpgradeCost(baseCost, currentLevel, x);
            return cost + GetTotalCost(baseCost, currentLevel + 1, maxLevel, x);
        }

        private void btn_calc1_Click(object sender, EventArgs e)
        {
            // Read input values from textboxes
            double baseCost = double.Parse(tb_baseCost.Text);
            int currentLevel = int.Parse(tb_curLvl.Text);
            double availableResources = double.Parse(tb_resource.Text);
            double x = double.Parse(tb_X.Text);
            //double baseCost = 5000;
            //int currentLevel = 0;
            //double availableResources = 10000000;
            //double x = 1.01;

            int maxLevel = GetMaxLevel(baseCost, currentLevel, availableResources, x);
            double totalCost = GetTotalCost(baseCost, currentLevel, maxLevel, x);


            // Display the result
            tb_maxLvl.Text = maxLevel.ToString();
            tb_total.Text = totalCost.ToString("N0");
        }
    }
}
