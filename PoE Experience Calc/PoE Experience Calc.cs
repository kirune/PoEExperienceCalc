using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Experience_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Calc_Click(object sender, EventArgs e)
        {

            double SafeBand;
            double FinalExperience;
            double PlayerLevelNum;
            double MonsterLevelNum;
            double EffectiveDifference;
            double TopLevel;
            double LowerLevel;
            double Experience;

           if (PlayerLevel.Text == "" | MonsterLevel.Text == "")
            {
                ExperienceRange.Text = "Please enter a value for player level and monster/area level.";
            }


            else if (PlayerLevel.Text != "" && MonsterLevel.Text != "")
            {
                PlayerLevelNum = Convert.ToInt64(PlayerLevel.Text);
                MonsterLevelNum = Convert.ToInt64(MonsterLevel.Text);



                SafeBand = (int)((PlayerLevelNum / 16) + 3);
                TopLevel = (PlayerLevelNum + SafeBand);
                LowerLevel = (PlayerLevelNum - SafeBand);

                if (MonsterLevelNum < LowerLevel)
                {
                    ExperienceRange.Text = "";
                    //Results.Text = "";
                    EffectiveDifference = LowerLevel - MonsterLevelNum;
                    Experience = Math.Pow((PlayerLevelNum + 5) / (PlayerLevelNum + 5 + Math.Pow(EffectiveDifference, 2.5)), 1.5) * 100;
                    FinalExperience = Math.Round(Experience);
                    if (FinalExperience < 2)
                    { FinalExperience = 2; }
                    ///Results.Text = FinalExperience.ToString() + "%";
                    ExperienceRange.Text = "You get " + FinalExperience + "% experience for killing monsters level " + MonsterLevelNum + ". \r\n \r\nYou will gain 100% experience from killing monsters level " + LowerLevel + " - " + TopLevel;
                }

                else if (MonsterLevelNum > TopLevel)
                {
                    ExperienceRange.Text = "";
                    ///Results.Text = "";
                    EffectiveDifference = MonsterLevelNum - TopLevel;
                    Experience = Math.Pow((PlayerLevelNum + 5) / (PlayerLevelNum + 5 + Math.Pow(EffectiveDifference, 2.5)), 1.5) * 100;
                    FinalExperience = Math.Round(Experience);
                    if (FinalExperience < 2)
                    { FinalExperience = 2; }
                    ///Results.Text = FinalExperience.ToString() + "%";
                    ExperienceRange.Text = "You get " + FinalExperience + "% experience for killing monsters level " + MonsterLevelNum + ". \r\n \r\nYou will gain 100% experience from killing monsters level " + LowerLevel + " - " + TopLevel;
                }
                else if (MonsterLevelNum >= LowerLevel && MonsterLevelNum <= TopLevel)
                {
                    ExperienceRange.Text = "";
                    ///Results.Text = "";
                    EffectiveDifference = 0;
                    Experience = Math.Pow((PlayerLevelNum + 5) / (PlayerLevelNum + 5 + Math.Pow(EffectiveDifference, 2.5)), 1.5) * 100;
                    FinalExperience = Math.Round(Experience);
                    ///Results.Text = FinalExperience.ToString() + "%";
                    ExperienceRange.Text = "You get " + FinalExperience + "% experience for killing monsters level " + MonsterLevelNum + ". \r\n \r\nYou will gain 100% experience from killing monsters level " + LowerLevel + " - " + TopLevel;
                }


            }


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            MonsterLevel.Text = "";
            PlayerLevel.Text = "";
            PlayerLevel.Focus();
        }

       
    }

     
     
    }

