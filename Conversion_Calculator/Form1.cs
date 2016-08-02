using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Calculator
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertdistance_Click(object sender, EventArgs e)
        {
            double miles1=0;
            double feet1 = 0;
            double yards1 = 0;
            double capefeet1 = 0;
            double roods1 = 0;

            double miles2;
            miles2 = Convert.ToDouble(miles.Text);
            double feet2;
            feet2 = Convert.ToDouble(feet.Text);
            double yards2;
            yards2 = Convert.ToDouble(yards.Text);
            double capefeet2;
            capefeet2 = Convert.ToDouble(capefeet.Text);
            double roods2;
            roods2 = Convert.ToDouble(roods.Text);

            double milestom;
            double feettom;
            double yardstom;
            double capefeettom;
            double roodstom;
            double milestokm;

            milestom = miles1 + (miles2 * 1609.34);

            feettom = feet1 + (feet2 * 0.3048);
            yardstom = yards1 + (yards2 * 0.9144);
            capefeettom = capefeet1 + (capefeet2 * 0.31485558);
            roodstom = roods1 + (roods2 * 3.7782669);
            milestokm = (miles1 + (miles2 * 1609.34)/1000);

            string milesinm = Convert.ToString(milestom);
            milesm.Text = milesinm;

            string feetinm = Convert.ToString(feettom);
            feetm.Text = feetinm;

            string yardsinm = Convert.ToString(yardstom);
            yardsm.Text = yardsinm;

            string capefeetinm = Convert.ToString(capefeettom);
            capefeetm.Text = capefeetinm;

            string roodsinm = Convert.ToString(roodstom);
            roodsm.Text = roodsinm;

            string milesinkm = Convert.ToString(milestokm);
            mileskm.Text = milesinkm;

            double total;
            double milemeters;
            milemeters = Convert.ToDouble(milesm.Text);
            double yardmeters;
            yardmeters = Convert.ToDouble(yardsm.Text);
            double feetmeters;
            feetmeters = Convert.ToDouble(feetm.Text);
            double capefeetmeters;
            capefeetmeters = Convert.ToDouble(capefeetm.Text);
            double roodsmeters;
            roodsmeters = Convert.ToDouble(roodsm.Text);

            total = milemeters + yardmeters + feetmeters + capefeetmeters + roodsmeters;
            distancetotal.Text = Convert.ToString(total);




            //areaconverstion


            Double acres;
            acres = Convert.ToDouble(Acres.Text);

            Double perches;
            perches = Convert.ToDouble(Perches.Text);

            Double hectares;
            hectares = Convert.ToDouble(Hectares.Text);

            Double morgen;
            morgen = Convert.ToDouble(Morgen.Text);

            Double squareroods;
            squareroods = Convert.ToDouble(SquareRoods.Text);

            Double squarefeet;
            squarefeet = Convert.ToDouble(SquareFeet.Text);

            Double acresM;
            acresM = acres * 4046.8564;
            AcresMS.Text = Convert.ToString(acresM);
            double acreshect;
            acreshect = acresM / 10000;
            acrestohectare.Text = Convert.ToString(acreshect);

            Double perchesM;
            perchesM = perches * 25.29285264;
            PerchesMS.Text = Convert.ToString(perchesM);
            Double hectaresM;
            hectaresM = hectares * 10000;
            HectaresMS.Text = Convert.ToString(hectaresM);
            Double morgenM;
            morgenM = morgen * 8565.18047;
            MorgenMS.Text = Convert.ToString(morgenM);
            double morgenhect;
            morgenhect = morgenM / 10000;
            morgentohectares.Text = Convert.ToString(morgenhect);
            Double squareroodsM;
            squareroodsM = squareroods * 14.2753007821;
            SquareRoodsMS.Text = Convert.ToString(squareroodsM);
            Double squarefeetM;
            squarefeetM = squarefeet * 0.099136;
            SquareFeetMS.Text = Convert.ToString(squarefeetM);



            double acresmett;
            double perchesmtt;
            double hectaresmtt;
            double morgenmtt;
            double squarefeetmtt;
            double squareroodsmtt;
            acresmett = Convert.ToDouble(AcresMS.Text);
            perchesmtt = Convert.ToDouble(PerchesMS.Text);
            hectaresmtt = Convert.ToDouble(HectaresMS.Text);

            morgenmtt = Convert.ToDouble(MorgenMS.Text);
            squarefeetmtt = Convert.ToDouble(SquareFeetMS.Text);
            squareroodsmtt = Convert.ToDouble(SquareRoodsMS.Text);

            double areatotal;
            areatotal = acresmett + perchesmtt + hectaresmtt + morgenmtt + squarefeetmtt + squareroodsmtt;
            string areatotalstring;
            areatotalstring = Convert.ToString(areatotal);
            areatotaltext.Text = areatotalstring;
            double areatotalforhectaresbox;
            areatotalforhectaresbox = areatotal / 10000;
            areatotalhectares.Text = Convert.ToString(areatotalforhectaresbox);




        }

        private void Resetdistance_Click(object sender, EventArgs e)
        {
            //reset all boxes to 0
            mileskm.Text = Convert.ToString(0);
            milesm.Text = Convert.ToString(0);
            capefeetm.Text = Convert.ToString(0);
            feetm.Text = Convert.ToString(0);
            roodsm.Text = Convert.ToString(0);
            yardsm.Text = Convert.ToString(0);
            miles.Text = Convert.ToString(0);
            miles.Text = Convert.ToString(0);
            capefeet.Text = Convert.ToString(0);
            feet.Text = Convert.ToString(0);
            roods.Text = Convert.ToString(0);
            yards.Text = Convert.ToString(0);
            distancetotal.Text = Convert.ToString(0);
            //reset area
            acrestohectare.Text = Convert.ToString(0);
            morgentohectares.Text = Convert.ToString(0);
            AcresMS.Text = Convert.ToString(0);
            HectaresMS.Text = Convert.ToString(0);
            PerchesMS.Text = Convert.ToString(0);
            MorgenMS.Text = Convert.ToString(0);
            SquareFeetMS.Text = Convert.ToString(0);
            SquareRoodsMS.Text = Convert.ToString(0);
            Acres.Text = Convert.ToString(0);
            Hectares.Text = Convert.ToString(0);
            SquareRoods.Text = Convert.ToString(0);
            SquareFeet.Text = Convert.ToString(0);
            Perches.Text = Convert.ToString(0);
            Morgen.Text = Convert.ToString(0);
            areatotaltext.Text = Convert.ToString(0);

            areatotalhectares.Text = Convert.ToString(0);


        }

        private void totaldistance_Click(object sender, EventArgs e)
        {



          


        }

        private void ConvertArea_Click(object sender, EventArgs e)
        {

            Double acres;
            acres = Convert.ToDouble(Acres.Text);

            Double perches;
            perches = Convert.ToDouble(Perches.Text);

            Double hectares;
            hectares = Convert.ToDouble(Hectares.Text);

            Double morgen;
            morgen = Convert.ToDouble(Morgen.Text);

            Double squareroods;
            squareroods = Convert.ToDouble(SquareRoods.Text);

            Double squarefeet;
            squarefeet = Convert.ToDouble(SquareFeet.Text);

            Double acresM;
            acresM = acres * 4046.8564;
            AcresMS.Text = Convert.ToString(acresM);
            double acreshect;
            acreshect = acresM / 10000;
            acrestohectare.Text = Convert.ToString(acreshect);

            Double perchesM;
            perchesM = perches * 25.29285264;
            PerchesMS.Text = Convert.ToString(perchesM);
            Double hectaresM;
            hectaresM = hectares * 10000;
            HectaresMS.Text = Convert.ToString(hectaresM);
            Double morgenM;
            morgenM = morgen * 8565.18047;
            MorgenMS.Text = Convert.ToString(morgenM);
            double morgenhect;
            morgenhect = morgenM / 10000;
            morgentohectares.Text = Convert.ToString(morgenhect);
            Double squareroodsM;
            squareroodsM = squareroods * 14.2753007821;
            SquareRoodsMS.Text = Convert.ToString(squareroodsM);
            Double squarefeetM;
            squarefeetM = squarefeet * 0.099136;
            SquareFeetMS.Text = Convert.ToString(squarefeetM);



            double acresmett;
            double perchesmtt;
            double hectaresmtt;
            double morgenmtt;
            double squarefeetmtt;
            double squareroodsmtt;
            acresmett = Convert.ToDouble(AcresMS.Text);
            perchesmtt = Convert.ToDouble(PerchesMS.Text);
            hectaresmtt = Convert.ToDouble(HectaresMS.Text);

            morgenmtt = Convert.ToDouble(MorgenMS.Text);
            squarefeetmtt = Convert.ToDouble(SquareFeetMS.Text);
            squareroodsmtt = Convert.ToDouble(SquareRoodsMS.Text);

            double areatotal;
            areatotal = acresmett + perchesmtt + hectaresmtt + morgenmtt + squarefeetmtt + squareroodsmtt;
            string areatotalstring;
            areatotalstring = Convert.ToString(areatotal);
            areatotaltext.Text = areatotalstring;
            double areatotalforhectaresbox;
            areatotalforhectaresbox = areatotal / 10000;
            areatotalhectares.Text = Convert.ToString(areatotalforhectaresbox);

            








        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btntotalarea_Click(object sender, EventArgs e)
        {

           

        }

        private void resetarea_Click(object sender, EventArgs e)
        {
            acrestohectare.Text = Convert.ToString(0);
            morgentohectares.Text = Convert.ToString(0);
            AcresMS.Text = Convert.ToString(0);
            HectaresMS.Text = Convert.ToString(0);
            PerchesMS.Text = Convert.ToString(0);
            MorgenMS.Text = Convert.ToString(0);
            SquareFeetMS.Text = Convert.ToString(0);
            SquareRoodsMS.Text = Convert.ToString(0);
            Acres.Text = Convert.ToString(0);
            Hectares.Text = Convert.ToString(0);
            SquareRoods.Text = Convert.ToString(0);
            SquareFeet.Text = Convert.ToString(0);
            Perches.Text = Convert.ToString(0);
            Morgen.Text = Convert.ToString(0);
            areatotaltext.Text = Convert.ToString(0);

            areatotalhectares.Text = Convert.ToString(0);


        }

        private void yardsm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
