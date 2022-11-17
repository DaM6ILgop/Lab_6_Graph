using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Lab_6_graph
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1(){
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pictureBox1.BackColor = Color.DarkBlue;
        }       
        public  void drawHull() {//Отрисовака корпуса
            SolidBrush dot = new SolidBrush(Color.White);
            g.FillEllipse(Data.myBak, 300, 300, 450, 190);
            g.FillEllipse(Data.nose, 301, 335, 150, 120);
            g.FillEllipse(Data.nose, 640, 335, 150, 110);
            //////////////////////////////////////////////////////
            g.FillEllipse(dot, 435, 370, 10, 10);//1-я заклепака //
                                                                 //
            g.FillEllipse(dot, 420, 351, 10, 10);//2-я заклепка  //
                                                                 //           
            g.FillEllipse(dot, 400, 340, 10, 10);//3-я заклепка  //
                                                                 //   
            g.FillEllipse(dot, 375, 336, 10, 10);//4-я заклепка  //         Часть заклепок верхней стороны
                                                                 //
            g.FillEllipse(dot, 435, 370, 10, 10);//5-я заклепка  //
                                                                 //
            g.FillEllipse(dot, 350, 338, 10, 10);//6 -я заклепка //
            //////////////////////////////////////////////////////
            ///
            //////////////////////////////////////////////////////
            g.FillEllipse(dot, 440, 395, 10, 10);//1-я заклепака //
                                                                 //
            g.FillEllipse(dot, 430, 418, 10, 10);//2-я заклепка  //
                                                                 //           
            g.FillEllipse(dot, 410, 435, 10, 10);//3-я заклепка  //
                                                                 //   
            g.FillEllipse(dot, 385, 443, 10, 10);//4-я заклепка  //         Часть заклепок нижней стороны 
                                                                 //
            g.FillEllipse(dot, 360, 445, 10, 10);//5 -я заклепка //
                                                                 //
            g.FillEllipse(dot, 335, 439, 10, 10);//6-я заклепка  //                     
        }                                                        //
        //////////////////////////////////////////////////////////

        public void foot() {
            g.FillRectangle(Data.myBak, 640, 335, 150, 110);// вроде бы кусок хвостового элемента, запутался
            g.FillRectangle(Data.myBak, 755, 365, 50, 50);//тоже кусок хвостового сегмента 
            g.FillEllipse(Data.forCrew, 810, 335, 10, 60); // частичка винта
            g.FillEllipse(Data.forCrew, 810, 385, 10, 60); // частичка винта
            g.FillRectangle(Data.myBak, 795, 385, 20, 10);//крепление винта (маленький стержень)
        }

        public void window() {
            SolidBrush blick = new SolidBrush(Color.White);
            g.FillEllipse(Data.forWindowBG, 475, 360, 50, 50);//рамка окна 1
            g.FillEllipse(Data.forWindowGlasses, 480, 365, 40,40 );//окно
            g.FillEllipse(blick, 504,370, 10, 10);//блик

            g.FillEllipse(Data.forWindowBG, 575, 360, 50, 50);//рамка окна 2       
            g.FillEllipse(Data.forWindowGlasses, 580, 365, 40, 40);//окно
            g.FillEllipse(blick, 604, 370, 10, 10);//блик
        }
        public void head() { 
            g.FillRectangle (Data.head, 450, 270, 150, 110); //отрисовка выпирающей части, по центру которая 
            g.FillEllipse(Data.head, 400, 270, 10, 60);// отрисовка планки вертикаль
            g.FillRectangle(Data.head, 404, 270, 50, 2);// отрисовка планки горизонталь

            g.FillRectangle(Data.head, 460, 170, 4, 100);//антенка 1
            g.FillRectangle(Data.head, 480, 230, 4, 50);//антенка 2
        }

        public void buble() {
            g.DrawEllipse(Data.buble, 845, 375, 15, 15);
            g.DrawEllipse(Data.buble, 855, 383, 15, 15);
            g.DrawEllipse(Data.buble, 865, 392, 15, 15);
            g.DrawEllipse(Data.buble, 876, 354, 15, 15);
            g.DrawEllipse(Data.buble, 886, 350, 15, 15);
            g.DrawEllipse(Data.buble, 965, 360, 15, 15);
            g.DrawEllipse(Data.buble, 877, 374, 15, 15);
            g.DrawEllipse(Data.buble, 895, 387, 15, 15);
            g.DrawEllipse(Data.buble, 943, 343, 15, 15);
            g.DrawEllipse(Data.buble, 830, 323, 15, 15);
        }
        private void button1_Click(object sender, EventArgs e){
           
            foot();        
            head();
            drawHull();
            window();
            buble();
        }

       
    }
}
