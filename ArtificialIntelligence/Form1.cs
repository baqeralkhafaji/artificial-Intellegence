using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtificialIntelligence
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

        int [,] newpop;
        int size, length;
        int[,] pop;

        int[] chrom;
        int[] fit;
        int x;
        int[,] fitselect;
        int[] child1;
        int[] child2;
        void initailization(int size, int length)
        {
            chrom = new int[length];
            pop = new int[size, length];
            Random r = new Random();
            for (int y = 0; y < size; y++)
            {
                for (int i = 0; i < length; i++)
                {
                    chrom[i] = r.Next(0, 2);
                }

                for (int u = 0; u < length; u++)
                {
                    pop[y, u] = chrom[u];
                }
            }

        }


        void evaluation(int size, int length)
        {
            fit = new int[size];
            for (int i = 0; i < size; i++)
            {
                x = 0;
                for (int j = 0; j < length; j++)
                {
                    x += pop[i, j] * (int)Math.Pow(2, length - j - 1);
                }
                {
                    evatxt.Text += x.ToString() + "\r\n";
                    fit[i] = (x * x) - (2 * x) + 6;

                }
            }

            //In this code we will display the resualt of fitness
            for (int i = 0; i < size; i++)
            {
                fittxt.Text += fit[i].ToString() + "\r\n";
            }



        }

        void print(int size, int length)
        {

            for (int t = 0; t < size; t++)
            {
                for (int r = 0; r < length; r++)
                {
                    resualttxt.Text += pop[t, r].ToString();
                }
                resualttxt.Text += "\r\n";
            }

        }


        private void binary_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            initailization(size, length);
            print(size, length);

        }

        void select(int size, int length)
        {


            Random r = new Random();
            chrom = new int[size];
            int ind1, ind2;
            int i;



            for (i = 0; i < size; i++)
            {
                ind1 = r.Next(0, size);
                ind2 = r.Next(0, size);

                while (ind1 == ind2)
                {
                    ind2 = r.Next(0, size);
                }




                selecttxt.Text += ind1 + "  " + ind2 + " , ";

                if (fit[ind1] == fit[ind2])
                    chrom[i] = ind1;
                else
                    if (fit[ind1] > fit[ind2])
                    chrom[i] = ind1;
                else
                    chrom[i] = ind2;



            }
            fitselect = new int[size, length];
            for (i = 0; i < chrom.Length; i++)
            {
                textBox1.Text += chrom[i] + ") ";

                for (int j = 0; j < length; j++)
                {
                    fitselect[i, j] = pop[chrom[i], j];
                    textBox1.Text += fitselect[i, j];
                }
                textBox1.Text += "\r\n";
            }

        }
        void crossover1x(int size, int length)
        {
            child1 = new int[length];
            child2 = new int[length];
            Random r = new Random();
            int cutpoint = r.Next(1, length - 1);
            for (int i = 0; i < size; i += 2)
            {
                for (int j = 0; j < length; j++)
                {

                    if (j < cutpoint)
                    {
                        child1[j] = fitselect[i, j];
                        //child2[j] = fitselect[i + 1, j];
                    }
                    else
                    {

                        child1[j] = fitselect[i + 1, j];
                        //child2[j] = fitselect[i, j ];
                    }


                }

            }
            childtxt.Text += cutpoint.ToString() + "\r\n";
            for (int i = 0; i < length; i++)
            {
                childtxt.Text += child1[i];


            }
            childtxt.Text += "\r\n";
            /*for(int i = 0; i < length; i++)
            {
                childtxt.Text += child2[i];
            }*/
        }
        private void selectbu_Click(object sender, EventArgs e)
        {

            select(size, length);

        }

        private void fittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void crossoverbu_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            crossover1x(size, length);
        }
        void crossover2x(int size, int length)
        {
            int m;
            
            child1 = new int[length];
            child2 = new int[length];
            Random r = new Random();
            int cutpoint1 = r.Next(1, length - 2);
            int cutpoint2 = r.Next(1, length - 2);
            while (cutpoint2 < cutpoint1)
            {
                cutpoint2 = r.Next(1, length - 2);
            }
            for (int i = 0; i < size; i+=2)
            {

                m = i + 1;
                    for (int j = 0; j < length; j++)
                    {
                   
                        if (j < cutpoint1)
                        {

                            child1[j] = fitselect[i, j];
                        child2[j] = fitselect[m , j];

                        
                    }
                        else
                            if ((j > cutpoint1) && (j < cutpoint2))
                        {
                            child1[j] = fitselect[m , j];
                        child2[j] = fitselect[i, j];
                        
                        }
                        else
                            if (j > cutpoint2)
                        {
                            child1[j] = fitselect[i, j];
                        child2[j] = fitselect[m , j];
                       
                        }
                    
                    
                    }
                }
           newpop=new int [size, length];
            int k= 0;
            for(int i = 0; i < size; i+=2)
            {
                
                for(int j = 0; j < length; j++)
                {
                    k = i;
                    newpop[i, j] = child1[j];
                    newpop[k+=1, j] = child2[j];
                    
                }
                
            }
            

            childtxt.Text += "cutpoint1:" + cutpoint1.ToString() + "\r\n";

            childtxt.Text += "cutpoint2:" + cutpoint2.ToString() + "\r\n";
           
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    childtxt.Text += newpop[i,j];
                }
                childtxt.Text += "\r\n";

            }




        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            crossover2x(size, length);
            

        }
        void mutatin(int size,int length)
        {
            Random r = new Random();
            int index = r.Next(1, length - 2);
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j == index)
                    {
                        if (pop[i,j] == 1)
                        {
                            pop[i,j] = 0;
                        }
                        else
                        {
                            newpop[i,j] = 1;
                        }
                    }
                }
                
            }
            mutatintxt.Text += "index:" + index.ToString() + "\r\n";
            for(int j = 0; j < length; j++)
            {
                mutatintxt.Text += child1[j];
            }
            
        }
        private void mutationbu_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            mutatin(size, length);
        }
        void mutation2x(int size,int length)
        {
            Random r = new Random();
            int index1 = r.Next(1, length - 2);
            int index2 = r.Next(1, length - 2);
            int g=0;
        

            while (index2 < index1)
            {
                index2 = r.Next(1, length - 2);
            }
            
            for (int i = 0; i < size; i++)
            {
                
               
                        g = newpop[i, index1];
                        newpop[i, index1] = newpop[i, index2];
                        newpop[i, index2] = g;
                    

            }
          

            
            mutatintxt.Text += "index1:" + index1.ToString() + "\r\n";
            mutatintxt.Text += "index2:" + index2.ToString() + "\r\n";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    mutatintxt.Text += newpop[i,j];
                }
                mutatintxt.Text += "\r\n";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            mutation2x(size, length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < length; j++)
                {

                    textBox2.Text += newpop[i, j];


                }
                textBox2.Text += "\r\n";

            }
        }

        private void evabu_Click(object sender, EventArgs e)
        {
            size = int.Parse(sizetxt.Text);
            length = int.Parse(lengthtxt.Text);
            evaluation(size, length);
            

        }
    }
}
