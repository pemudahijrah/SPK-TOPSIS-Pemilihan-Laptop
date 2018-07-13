using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spk1
{
    public partial class FrmMulai : Form
    {

        Double nilaiharga1, nilaiharga2, nilaiharga3, nilaiLayar1, nilaiLayar2, nilaiLayar3, nilaiProc1, nilaiProc2, nilaiProc3,
                 nilaiRam1, nilaiRam2, nilaiRam3, nilaiDdr1, nilaiDdr2, nilaiDdr3, nilaiHdd1, nilaiHdd2, nilaiHdd3, nilaiBt1,
                 nilaiBt2, nilaiBt3, nilaiWbcam1, nilaiWbcam2, nilaiWbcam3;
        Double w1 = 4.1, w2 = 4.6, w3 = 3.3, w4 = 2.8, w5 = 5, w6 = 3.5, w7 = 4.6, w8 = 5;
        Double y1plus, y2plus, y3plus, y4plus, y5plus, y6plus, y7plus, y8plus, y1min, y2min, y3min, y4min, y5min, y6min, y7min, y8min;
        Double d1plus, d2plus, d3plus, d1min, d2min, d3min, v1, v2, v3;
        Double x1, x2, x3, x4, x5, x6, x7, x8, r11, r21, r31, r12, r22, r32, r13, r23, r33, r14, r24, r34, r15, r25, r35, r16, r26, r36,
               r17, r27, r37, r18, r28, r38;
        Double y11, y21, y31, y12, y22, y32, y13, y23, y33, y14, y24, y34, y15, y25, y35, y16, y26, y36, y17, y27, y37, y18,
               y28, y38;
        public String merk1, merk2, merk3;
        /*String[] harga = new String[10];
        double[] layar = new double[10];
        String[] proc = new String[10];
        double[] ram = new double[10];
        String[] ddr = new String[10];
        double[] hdd = new double[10];
        String[] bt = new String[10];
        String[] wbcam = new String[10];
        double[] temp = new double[10];
        */
        String harga0, harga1, harga2;
        Double layar0, layar1, layar2;
        String proc0, proc1, proc2;
        Double ram0, ram1, ram2;
        String ddr0, ddr1, ddr2;
        Double hdd0, hdd1, hdd2;
        String bt0, bt1, bt2;
        String wbcam0, wbcam1, wbcam2;

        public FrmMulai()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            reset();
            hitung(); 
            if ((txtMerk3.Enabled == true) && (v1 > v2) && (v1 > v3))
            {
                lblp1.Visible = true;
                lblp2.Visible = true;
                lblp3.Visible = true;
                txtnilai1.Visible = true;
                txtnilai2.Visible = true;
                txtnilai3.Visible = true;
                txtp1.Visible = true;
                txtp2.Visible = true;
                txtp3.Visible = true;
                if (v2 > v3)
                {
                    lblp1.Text = merk1;
                    lblp2.Text = merk2;
                    lblp3.Text = merk3;
                    txtnilai1.Text = Convert.ToString(v1);
                    txtnilai2.Text = Convert.ToString(v2);
                    txtnilai3.Text = Convert.ToString(v3);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
                else
                {
                    lblp1.Text = merk1;
                    lblp2.Text = merk3;
                    lblp3.Text = merk2;
                    txtnilai1.Text = Convert.ToString(v1);
                    txtnilai2.Text = Convert.ToString(v3);
                    txtnilai3.Text = Convert.ToString(v2);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
            }
            else if ((txtMerk3.Enabled == true) && (v2 > v1) && (v2 > v3))
            {
                lblp1.Visible = true;
                lblp2.Visible = true;
                lblp3.Visible = true;
                txtnilai1.Visible = true;
                txtnilai2.Visible = true;
                txtnilai3.Visible = true;
                txtp1.Visible = true;
                txtp2.Visible = true;
                txtp3.Visible = true;
                if (v1 > v3)
                {
                    lblp1.Text = merk2;
                    lblp2.Text = merk1;
                    lblp3.Text = merk3;
                    txtnilai1.Text = Convert.ToString(v2);
                    txtnilai2.Text = Convert.ToString(v1);
                    txtnilai3.Text = Convert.ToString(v3);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
                else
                {
                    lblp1.Text = merk2;
                    lblp2.Text = merk3;
                    lblp3.Text = merk1;
                    txtnilai1.Text = Convert.ToString(v2);
                    txtnilai2.Text = Convert.ToString(v3);
                    txtnilai3.Text = Convert.ToString(v1);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
            }
            else if ((txtMerk3.Enabled == true) && (v3 > v2) && (v3 > v1))
            {
                lblp1.Visible = true;
                lblp2.Visible = true;
                lblp3.Visible = true;
                txtnilai1.Visible = true;
                txtnilai2.Visible = true;
                txtnilai3.Visible = true;
                txtp1.Visible = true;
                txtp2.Visible = true;
                txtp3.Visible = true;
                if (v2 > v1)
                {
                    lblp1.Text = merk3;
                    lblp2.Text = merk2;
                    lblp3.Text = merk1;
                    txtnilai1.Text = Convert.ToString(v3);
                    txtnilai2.Text = Convert.ToString(v2);
                    txtnilai3.Text = Convert.ToString(v1);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
                else
                {
                    lblp1.Text = merk3;
                    lblp2.Text = merk1;
                    lblp3.Text = merk2;
                    txtnilai1.Text = Convert.ToString(v3);
                    txtnilai2.Text = Convert.ToString(v1);
                    txtnilai3.Text = Convert.ToString(v2);
                    txtp1.Text = "1";
                    txtp2.Text = "2";
                    txtp3.Text = "3";
                }
            }
             

            else if ((txtMerk3.Enabled == false) && (v1 > v2))
            {
                lblp1.Visible = true;
                lblp2.Visible = true;
                
                txtnilai1.Visible = true;
                txtnilai2.Visible = true;
                txtp1.Visible = true;
                txtp2.Visible = true;
                lblp1.Text = merk1;
                lblp2.Text = merk2;
                txtnilai1.Text = Convert.ToString(v1);
                txtnilai2.Text = Convert.ToString(v2);
                txtp1.Text = "1";
                txtp2.Text = "2";
            }
            else
            {
                lblp1.Visible = true;
                lblp2.Visible = true;
                txtnilai1.Visible = true;
                txtnilai2.Visible = true;
                txtp1.Visible = true;
                txtp2.Visible = true;
                lblp1.Text = merk2;
                lblp2.Text = merk1;
                txtnilai1.Text = Convert.ToString(v2);
                txtnilai2.Text = Convert.ToString(v1);
                txtp1.Text = "1";
                txtp2.Text = "2";
            }        
          }
        public void reset()
        {
            lblp1.Text = "";
            lblp2.Text = "";
            lblp3.Text = "";
            txtnilai1.Text = "";
            txtnilai2.Text = "";
            txtnilai3.Text = "";
            txtp1.Text = "";
            txtp2.Text = "";
            txtp3.Text = "";
        }
        public void hitung()
        {
            merk1 = txtMerk1.Text;
            merk2 = txtMerk2.Text;
            merk3 = txtMerk3.Text;
            if (txtMerk3.Enabled == true)
            {
                harga0 = Convert.ToString(cbHarga1.SelectedIndex);
                harga1 = Convert.ToString(cbHarga2.SelectedIndex);
                harga2 = Convert.ToString(cbHarga3.SelectedIndex);
                layar0 = Convert.ToDouble(cbLayar1.SelectedIndex);
                layar1 = Convert.ToDouble(cbLayar2.SelectedIndex);
                layar2 = Convert.ToDouble(cbHarga3.SelectedIndex);
                proc0 = Convert.ToString(cbPro1.SelectedIndex);
                proc1 = Convert.ToString(cbPro2.SelectedIndex);
                proc2 = Convert.ToString(cbPro3.SelectedIndex);
                ram0 = Convert.ToDouble(cbRam1.SelectedIndex);
                ram1 = Convert.ToDouble(cbRam2.SelectedIndex);
                ram2 = Convert.ToDouble(cbRam3.SelectedIndex);
                ddr0 = Convert.ToString(cbDdr1.SelectedIndex);
                ddr1 = Convert.ToString(cbDdr2.SelectedIndex);
                ddr2 = Convert.ToString(cbDdr3.SelectedIndex);
                hdd0 = Convert.ToDouble(cbHard1.SelectedIndex);
                hdd1 = Convert.ToDouble(cbHard2.SelectedIndex);
                hdd2 = Convert.ToDouble(cbHard3.SelectedIndex);
                bt0 = Convert.ToString(cbBlue1.SelectedIndex);
                bt1 = Convert.ToString(cbBlue2.SelectedIndex);
                bt2 = Convert.ToString(cbBlue3.SelectedIndex);
                wbcam0 = Convert.ToString(cbWeb1.SelectedIndex);
                wbcam1 = Convert.ToString(cbWeb2.SelectedIndex);
                wbcam2 = Convert.ToString(cbWeb3.SelectedIndex);

                if (harga0 == ">=15 - 23 juta")
                {
                    nilaiharga1 = 1;
                }
                else if (harga0 == "8,5 - 15 juta")
                {
                    nilaiharga1 = 2;
                }
                else if (harga0 == "7 - 8,5 juta")
                {
                    nilaiharga1 = 3;
                }
                else if (harga0 == "5,5 - 7 juta")
                {
                    nilaiharga1 = 4;
                }
                else
                {
                    nilaiharga1 = 5;
                }

                if (harga1 == ">=15 - 23 juta")
                {
                    nilaiharga2 = 1;
                }
                else if (harga1 == "8,5 - 15 juta")
                {
                    nilaiharga2 = 2;
                }
                else if (harga1 == "7 - 8,5 juta")
                {
                    nilaiharga2 = 3;
                }
                else if (harga1 == "5,5 - 7 juta")
                {
                    nilaiharga2 = 4;
                }
                else
                {
                    nilaiharga2 = 5;
                }

                if (harga2 == ">=15 - 23 juta")
                {
                    nilaiharga3 = 1;
                }
                else if (harga2 == "8,5 - 15 juta")
                {
                    nilaiharga3 = 2;
                }
                else if (harga2 == "7 - 8,5 juta")
                {
                    nilaiharga3 = 3;
                }
                else if (harga2 == "5,5 - 7 juta")
                {
                    nilaiharga3 = 4;
                }
                else
                {
                    nilaiharga3 = 5;
                }

                if (layar0 == 15 || layar0 == 17)
                {
                    nilaiLayar1 = 1;
                }
                else if (layar0 == 11 || layar0 == 12)
                {
                    nilaiLayar1 = 2;
                }

                else if (layar0 == 13)
                {
                    nilaiLayar1 = 3;
                }
                else if (layar0 == 10)
                {
                    nilaiLayar1 = 4;
                }
                else
                {
                    nilaiLayar1 = 5;
                }
                if (layar1 == 15 || layar1 == 17)
                {
                    nilaiLayar2 = 1;
                }
                else if (layar1 == 11 || layar1 == 12)
                {
                    nilaiLayar2 = 2;
                }
                else if (layar1 == 13)
                {
                    nilaiLayar2 = 3;
                }
                else if (layar1 == 10)
                {
                    nilaiLayar2 = 4;
                }
                else
                {
                    nilaiLayar2 = 5;
                }
                if (layar2 == 15 || layar2 == 17)
                {
                    nilaiLayar3 = 1;
                }
                else if (layar2 == 11 || layar2 == 12)
                {
                    nilaiLayar3 = 2;
                }
                else if (layar2 == 13)
                {
                    nilaiLayar3 = 3;
                }
                else if (layar2 == 10)
                {
                    nilaiLayar3 = 4;
                }
                else
                {
                    nilaiLayar3 = 5;
                }

                if (proc0 == "Pentium")
                {
                    nilaiProc1 = 1;
                }
                else if (proc0 == "Atom" || proc0 == "Core 2 Duo" || proc0 == "Dual Core")
                {
                    nilaiProc1 = 2;
                }
                else if (proc0 == "Core i3")
                {
                    nilaiProc1 = 3;
                }
                else if (proc0 == "Core i5")
                {
                    nilaiProc1 = 4;
                }
                else
                {
                    nilaiProc1 = 5;
                }
                if (proc1 == "Pentium")
                {
                    nilaiProc2 = 1;
                }
                else if (proc1 == "Atom" || proc1 == "Core 2 Duo" || proc1 == "Dual Core")
                {
                    nilaiProc2 = 2;
                }
                else if (proc1 == "Core i3")
                {
                    nilaiProc2 = 3;
                }
                else if (proc1 == "Core i5")
                {
                    nilaiProc2 = 4;
                }
                else
                {
                    nilaiProc2 = 5;
                }
                if (proc2 == "Pentium")
                {
                    nilaiProc3 = 1;
                }
                else if (proc2 == "Atom" || proc2 == "Core 2 Duo" || proc2 == "Dual Core")
                {
                    nilaiProc3 = 2;
                }
                else if (proc2 == "Core i3")
                {
                    nilaiProc3 = 3;
                }
                else if (proc2 == "Core i5")
                {
                    nilaiProc3 = 4;
                }
                else
                {
                    nilaiProc3 = 5;
                }

                if (ram0 == 1)
                {
                    nilaiRam1 = 1;
                }
                else if (ram0 == 2)
                {
                    nilaiRam1 = 2;
                }
                else if (ram0 == 3)
                {
                    nilaiRam1 = 3;
                }
                else if (ram0 == 4)
                {
                    nilaiRam1 = 4;
                }
                else
                {
                    nilaiRam1 = 5;
                }
                if (ram1 == 1)
                {
                    nilaiRam2 = 1;
                }
                else if (ram1 == 2)
                {
                    nilaiRam2 = 2;
                }
                else if (ram1 == 3)
                {
                    nilaiRam2 = 3;
                }
                else if (ram1 == 4)
                {
                    nilaiRam2 = 4;
                }
                else
                {
                    nilaiRam2 = 5;
                }
                if (ram2 == 1)
                {
                    nilaiRam3 = 1;
                }
                else if (ram2 == 2)
                {
                    nilaiRam3 = 2;
                }
                else if (ram2 == 3)
                {
                    nilaiRam3 = 3;
                }
                else if (ram2 == 4)
                {
                    nilaiRam3 = 4;
                }
                else
                {
                    nilaiRam3 = 5;
                }

                if (ddr0 == "DDR 2")
                {
                    nilaiDdr1 = 3;
                }
                else
                {
                    nilaiDdr1 = 5;
                }
                if (ddr1 == "DDR 2")
                {
                    nilaiDdr2 = 3;
                }
                else
                {
                    nilaiDdr2 = 5;
                }
                if (ddr2 == "DDR 2")
                {
                    nilaiDdr3 = 3;
                }
                else
                {
                    nilaiDdr3 = 5;
                }

                if (hdd0 == 250)
                {
                    nilaiHdd1 = 1;
                }
                else if (hdd0 == 320)
                {
                    nilaiHdd1 = 2;
                }
                else if (hdd0 == 500)
                {
                    nilaiHdd1 = 3;
                }
                else if (hdd0 == 640)
                {
                    nilaiHdd1 = 4;
                }
                else
                {
                    nilaiHdd1 = 5;
                }
                if (hdd1 == 250)
                {
                    nilaiHdd2 = 1;
                }
                else if (hdd1 == 320)
                {
                    nilaiHdd2 = 2;
                }
                else if (hdd1 == 500)
                {
                    nilaiHdd2 = 3;
                }
                else if (hdd1 == 640)
                {
                    nilaiHdd2 = 4;
                }
                else
                {
                    nilaiHdd2 = 5;
                }
                if (hdd2 == 250)
                {
                    nilaiHdd3 = 1;
                }
                else if (hdd2 == 320)
                {
                    nilaiHdd3 = 2;
                }
                else if (hdd2 == 500)
                {
                    nilaiHdd3 = 3;
                }
                else if (hdd2 == 640)
                {
                    nilaiHdd3 = 4;
                }
                else
                {
                    nilaiHdd3 = 5;
                }

                if (bt0 == "Ada")
                {
                    nilaiBt1 = 5;
                }
                else
                {
                    nilaiBt1 = 3;
                }
                if (bt1 == "Ada")
                {
                    nilaiBt2 = 5;
                }
                else
                {
                    nilaiBt2 = 3;
                }
                if (bt2 == "Ada")
                {
                    nilaiBt3 = 5;
                }
                else
                {
                    nilaiBt3 = 3;
                }

                if (wbcam0 == "Ada")
                {
                    nilaiWbcam1 = 5;
                }
                else
                {
                    nilaiWbcam1 = 3;
                }
                if (wbcam1 == "Ada")
                {
                    nilaiWbcam2 = 5;
                }
                else
                {
                    nilaiWbcam2 = 3;
                }
                if (wbcam2 == "Ada")
                {
                    nilaiWbcam3 = 5;
                }
                else
                {
                    nilaiWbcam3 = 3;
                }
                x1 = Math.Abs(Math.Sqrt(Math.Pow(nilaiharga1, 2) + Math.Pow(nilaiharga2, 2) + Math.Pow(nilaiharga3, 2)));
                x2 = Math.Abs(Math.Sqrt(Math.Pow(nilaiLayar1, 2) + Math.Pow(nilaiLayar2, 2) + Math.Pow(nilaiLayar3, 2)));
                x3 = Math.Abs(Math.Sqrt(Math.Pow(nilaiProc1, 2) + Math.Pow(nilaiProc2, 2) + Math.Pow(nilaiProc3, 2)));
                x4 = Math.Abs(Math.Sqrt(Math.Pow(nilaiRam1, 2) + Math.Pow(nilaiRam2, 2) + Math.Pow(nilaiRam3, 2)));
                x5 = Math.Abs(Math.Sqrt(Math.Pow(nilaiDdr1, 2) + Math.Pow(nilaiDdr2, 2) + Math.Pow(nilaiDdr3, 2)));
                x6 = Math.Abs(Math.Sqrt(Math.Pow(nilaiHdd1, 2) + Math.Pow(nilaiHdd2, 2) + Math.Pow(nilaiHdd3, 2)));
                x7 = Math.Abs(Math.Sqrt(Math.Pow(nilaiBt1, 2) + Math.Pow(nilaiBt2, 2) + Math.Pow(nilaiBt3, 2)));
                x8 = Math.Abs(Math.Sqrt(Math.Pow(nilaiWbcam1, 2) + Math.Pow(nilaiWbcam2, 2) + Math.Pow(nilaiWbcam3, 2)));
                r11 = nilaiharga1 / x1;
                r21 = nilaiharga2 / x1;
                r31 = nilaiharga3 / x1;
                r12 = nilaiLayar1 / x2;
                r22 = nilaiLayar2 / x2;
                r32 = nilaiLayar3 / x2;
                r13 = nilaiProc1 / x3;
                r23 = nilaiProc2 / x3;
                r33 = nilaiProc3 / x3;
                r14 = nilaiRam1 / x4;
                r24 = nilaiRam2 / x4;
                r34 = nilaiRam3 / x4;
                r15 = nilaiDdr1 / x5;
                r25 = nilaiDdr2 / x5;
                r35 = nilaiDdr3 / x5;
                r16 = nilaiHdd1 / x6;
                r26 = nilaiHdd2 / x6;
                r36 = nilaiHdd3 / x6;
                r17 = nilaiBt1 / x7;
                r27 = nilaiBt2 / x7;
                r37 = nilaiBt3 / x7;
                r18 = nilaiWbcam1 / x8;
                r28 = nilaiWbcam2 / x8;
                r38 = nilaiWbcam3 / x8;

                y11 = r11 * w1;
                y21 = r21 * w1;
                y31 = r31 * w1;
                y12 = r12 * w2;
                y22 = r22 * w2;
                y32 = r32 * w2;
                y13 = r13 * w3;
                y23 = r23 * w3;
                y33 = r33 * w3;
                y14 = r14 * w4;
                y24 = r24 * w4;
                y34 = r34 * w4;
                y15 = r15 * w5;
                y25 = r25 * w5;
                y35 = r35 * w5;
                y16 = r16 * w6;
                y26 = r26 * w6;
                y36 = r36 * w6;
                y17 = r17 * w7;
                y27 = r27 * w7;
                y37 = r37 * w7;
                y18 = r18 * w8;
                y28 = r28 * w8;
                y38 = r38 * w8;

                if ((y11 >= y21) && (y11 >= y31))
                {
                    y1plus = y11;
                }
                else if ((y21 >= y11) && (y21 >= y31))
                {
                    y1plus = y21;
                }
                else
                {
                    y1plus = y31;
                }

                if ((y12 >= y22) && (y12 >= y32))
                {
                    y2plus = y12;
                }
                else if ((y22 >= y12) && (y22 >= y32))
                {
                    y2plus = y22;
                }
                else
                {
                    y2plus = y32;
                }

                if ((y13 >= y23) && (y13 >= y33))
                {
                    y3plus = y13;
                }
                else if ((y23 >= y13) && (y23 >= y33))
                {
                    y3plus = y23;
                }
                else
                {
                    y3plus = y33;
                }

                if ((y14 >= y24) && (y14 >= y34))
                {
                    y4plus = y14;
                }
                else if ((y24 >= y14) && (y24 >= y34))
                {
                    y4plus = y24;
                }
                else
                {
                    y4plus = y34;
                }

                if ((y15 >= y25) && (y15 >= y35))
                {
                    y5plus = y15;
                }
                else if ((y25 >= y15) && (y25 >= y35))
                {
                    y5plus = y25;
                }
                else
                {
                    y5plus = y35;
                }

                if ((y16 >= y26) && (y16 >= y36))
                {
                    y6plus = y16;
                }
                else if ((y26 >= y16) && (y26 >= y36))
                {
                    y6plus = y26;
                }
                else
                {
                    y6plus = y36;
                }

                if ((y17 >= y27) && (y17 >= y37))
                {
                    y7plus = y17;
                }
                else if (y27 >= y17 && (y27 >= y37))
                {
                    y7plus = y27;
                }
                else
                {
                    y7plus = y37;
                }

                if ((y18 >= y28) && (y18 >= y38))
                {
                    y8plus = y18;
                }
                else if ((y28 >= y18) && (y28 >= y38))
                {
                    y8plus = y28;
                }
                else
                {
                    y8plus = y38;
                }

                if ((y11 <= y21) && (y11 <= y31))
                {
                    y1min = y11;
                }
                else if ((y21 <= y11) && (y21 <= y31))
                {
                    y1min = y21;
                }
                else
                {
                    y1min = y31;
                }

                if ((y12 <= y22) && (y12 <= y32))
                {
                    y2min = y12;
                }
                else if ((y22 <= y12) && (y22 <= y32))
                {
                    y2min = y22;
                }
                else
                {
                    y2min = y32;
                }

                if ((y13 <= y23) && (y13 <= y33))
                {
                    y3min = y13;
                }
                else if ((y23 <= y13) && (y23 <= y33))
                {
                    y3min = y23;
                }
                else
                {
                    y3min = y33;
                }

                if ((y14 <= y24) && (y14 <= y34))
                {
                    y4min = y14;
                }
                else if ((y24 <= y14) && (y24 <= y34))
                {
                    y4min = y24;
                }
                else
                {
                    y4min = y34;
                }

                if ((y15 <= y25) && (y15 <= y35))
                {
                    y5min = y15;
                }
                else if ((y25 <= y15) && (y25 <= y35))
                {
                    y5min = y25;
                }
                else
                {
                    y5min = y35;
                }

                if ((y16 <= y26) && (y16 <= y36))
                {
                    y6min = y16;
                }
                else if ((y26 <= y16) && (y26 <= y36))
                {
                    y6min = y26;
                }
                else
                {
                    y6min = y36;
                }

                if ((y17 <= y27) && (y17 <= y37))
                {
                    y7min = y17;
                }
                else if (y27 <= y17 && (y27 <= y37))
                {
                    y7min = y27;
                }
                else
                {
                    y7min = y37;
                }

                if ((y18 <= y28) && (y18 <= y38))
                {
                    y8min = y18;
                }
                else if ((y28 <= y18) && (y28 <= y38))
                {
                    y8min = y28;
                }
                else
                {
                    y8min = y38;
                }

                d1plus = Math.Sqrt(Math.Pow((y11 - y1plus), 2) + Math.Pow((y12 - y2plus), 2) + Math.Pow((y13 - y3plus), 2) + Math.Pow((y14 - y4plus), 2) + Math.Pow((y15 - y5plus), 2) + Math.Pow((y16 - y6plus), 2) + Math.Pow((y17 - y7plus), 2) + Math.Pow((y18 - y8plus), 2));
                d2plus = Math.Sqrt(Math.Pow((y21 - y1plus), 2) + Math.Pow((y22 - y2plus), 2) + Math.Pow((y23 - y3plus), 2) + Math.Pow((y24 - y4plus), 2) + Math.Pow((y25 - y5plus), 2) + Math.Pow((y26 - y6plus), 2) + Math.Pow((y27 - y7plus), 2) + Math.Pow((y28 - y8plus), 2));
                d3plus = Math.Sqrt(Math.Pow((y31 - y1plus), 2) + Math.Pow((y32 - y2plus), 2) + Math.Pow((y33 - y3plus), 2) + Math.Pow((y34 - y4plus), 2) + Math.Pow((y35 - y5plus), 2) + Math.Pow((y36 - y6plus), 2) + Math.Pow((y37 - y7plus), 2) + Math.Pow((y38 - y8plus), 2));
                d1min = Math.Sqrt(Math.Pow((y11 - y1min), 2) + Math.Pow((y12 - y2min), 2) + Math.Pow((y13 - y3min), 2) + Math.Pow((y14 - y4min), 2) + Math.Pow((y15 - y5min), 2) + Math.Pow((y16 - y6min), 2) + Math.Pow((y17 - y7min), 2) + Math.Pow((y18 - y8min), 2));
                d2min = Math.Sqrt(Math.Pow((y21 - y1min), 2) + Math.Pow((y22 - y2min), 2) + Math.Pow((y23 - y3min), 2) + Math.Pow((y24 - y4min), 2) + Math.Pow((y25 - y5min), 2) + Math.Pow((y26 - y6min), 2) + Math.Pow((y27 - y7min), 2) + Math.Pow((y28 - y8min), 2));
                d3min = Math.Sqrt(Math.Pow((y31 - y1min), 2) + Math.Pow((y32 - y2min), 2) + Math.Pow((y33 - y3min), 2) + Math.Pow((y34 - y4min), 2) + Math.Pow((y35 - y5min), 2) + Math.Pow((y36 - y6min), 2) + Math.Pow((y37 - y7min), 2) + Math.Pow((y38 - y8min), 2));

                v1 = d1min / (d1min + d1plus);
                v2 = d2min / (d2min + d2plus);
                v3 = d3min / (d3min + d3plus);

            }
            else
            {
                harga0 = Convert.ToString(cbHarga1.SelectedIndex);
                harga1 = Convert.ToString(cbHarga2.SelectedIndex);
                layar0 = Convert.ToDouble(cbLayar1.SelectedIndex);
                layar1 = Convert.ToDouble(cbLayar2.SelectedIndex);
                proc0 = Convert.ToString(cbPro1.SelectedIndex);
                proc1 = Convert.ToString(cbPro2.SelectedIndex);
                ram0 = Convert.ToDouble(cbRam1.SelectedIndex);
                ram1 = Convert.ToDouble(cbRam2.SelectedIndex);
                ddr0 = Convert.ToString(cbDdr1.SelectedIndex);
                ddr1 = Convert.ToString(cbDdr2.SelectedIndex);
                hdd0 = Convert.ToDouble(cbHard1.SelectedIndex);
                hdd1 = Convert.ToDouble(cbHard2.SelectedIndex);
                bt0 = Convert.ToString(cbBlue1.SelectedIndex);
                bt1 = Convert.ToString(cbBlue2.SelectedIndex);
                wbcam0 = Convert.ToString(cbWeb1.SelectedIndex);
                wbcam1 = Convert.ToString(cbWeb2.SelectedIndex);

                if (harga0 == ">=15 - 23 juta")
                {
                    nilaiharga1 = 1;
                }
                else if (harga0 == "8,5 - 15 juta")
                {
                    nilaiharga1 = 2;
                }
                else if (harga0 == "7 - 8,5 juta")
                {
                    nilaiharga1 = 3;
                }
                else if (harga0 == "5,5 - 7 juta")
                {
                    nilaiharga1 = 4;
                }
                else
                {
                    nilaiharga1 = 5;
                }
                if (harga1 == ">=15 - 23 juta")
                {
                    nilaiharga2 = 1;
                }
                else if (harga1 == "8,5 - 15 juta")
                {
                    nilaiharga2 = 2;
                }
                else if (harga1 == "7 - 8,5 juta")
                {
                    nilaiharga2 = 3;
                }
                else if (harga1 == "5,5 - 7 juta")
                {
                    nilaiharga2 = 4;
                }
                else
                {
                    nilaiharga2 = 5;
                }
                if (layar0 == 15 || layar0 == 17)
                {
                    nilaiLayar1 = 1;
                }
                else if (layar0 == 11 || layar0 == 12)
                {
                    nilaiLayar1 = 2;
                }

                else if (layar0 == 13)
                {
                    nilaiLayar1 = 3;
                }
                else if (layar0 == 10)
                {
                    nilaiLayar1 = 4;
                }
                else
                {
                    nilaiLayar1 = 5;
                }
                if (layar1 == 15 || layar1 == 17)
                {
                    nilaiLayar2 = 1;
                }
                else if (layar1 == 11 || layar1 == 12)
                {
                    nilaiLayar2 = 2;
                }
                else if (layar1 == 13)
                {
                    nilaiLayar2 = 3;
                }
                else if (layar1 == 10)
                {
                    nilaiLayar2 = 4;
                }
                else
                {
                    nilaiLayar2 = 5;
                }

                if (proc0 == "Pentium")
                {
                    nilaiProc1 = 1;
                }
                else if (proc0 == "Atom" || proc0 == "Core 2 Duo" || proc0 == "Dual Core")
                {
                    nilaiProc1 = 2;
                }
                else if (proc0 == "Core i3")
                {
                    nilaiProc1 = 3;
                }
                else if (proc0 == "Core i5")
                {
                    nilaiProc1 = 4;
                }
                else
                {
                    nilaiProc1 = 5;
                }
                if (proc1 == "Pentium")
                {
                    nilaiProc2 = 1;
                }
                else if (proc1 == "Atom" || proc1 == "Core 2 Duo" || proc1 == "Dual Core")
                {
                    nilaiProc2 = 2;
                }
                else if (proc1 == "Core i3")
                {
                    nilaiProc2 = 3;
                }
                else if (proc1 == "Core i5")
                {
                    nilaiProc2 = 4;
                }
                else
                {
                    nilaiProc2 = 5;
                }

                if (ram0 == 1)
                {
                    nilaiRam1 = 1;
                }
                else if (ram0 == 2)
                {
                    nilaiRam1 = 2;
                }
                else if (ram0 == 3)
                {
                    nilaiRam1 = 3;
                }
                else if (ram0 == 4)
                {
                    nilaiRam1 = 4;
                }
                else
                {
                    nilaiRam1 = 5;
                }
                if (ram1 == 1)
                {
                    nilaiRam2 = 1;
                }
                else if (ram1 == 2)
                {
                    nilaiRam2 = 2;
                }
                else if (ram1 == 3)
                {
                    nilaiRam2 = 3;
                }
                else if (ram1 == 4)
                {
                    nilaiRam2 = 4;
                }
                else
                {
                    nilaiRam2 = 5;
                }

                if (ddr0 == "DDR 2")
                {
                    nilaiDdr1 = 3;
                }
                else
                {
                    nilaiDdr1 = 5;
                }
                if (ddr1 == "DDR 2")
                {
                    nilaiDdr2 = 3;
                }
                else
                {
                    nilaiDdr2 = 5;
                }

                if (hdd0 == 250)
                {
                    nilaiHdd1 = 1;
                }
                else if (hdd0 == 320)
                {
                    nilaiHdd1 = 2;
                }
                else if (hdd0 == 500)
                {
                    nilaiHdd1 = 3;
                }
                else if (hdd0 == 640)
                {
                    nilaiHdd1 = 4;
                }
                else
                {
                    nilaiHdd1 = 5;
                }
                if (hdd1 == 250)
                {
                    nilaiHdd2 = 1;
                }
                else if (hdd1 == 320)
                {
                    nilaiHdd2 = 2;
                }
                else if (hdd1 == 500)
                {
                    nilaiHdd2 = 3;
                }
                else if (hdd1 == 640)
                {
                    nilaiHdd2 = 4;
                }
                else
                {
                    nilaiHdd2 = 5;
                }

                if (bt0 == "Ada")
                {
                    nilaiBt1 = 5;
                }
                else
                {
                    nilaiBt1 = 3;
                }
                if (bt1 == "Ada")
                {
                    nilaiBt2 = 5;
                }
                else
                {
                    nilaiBt2 = 3;
                }

                if (wbcam0 == "Ada")
                {
                    nilaiWbcam1 = 5;
                }
                else
                {
                    nilaiWbcam1 = 3;
                }
                if (wbcam1 == "Ada")
                {
                    nilaiWbcam2 = 5;
                }
                else
                {
                    nilaiWbcam2 = 3;
                }
                x1 = Math.Abs(Math.Sqrt(Math.Pow(nilaiharga1, 2) + Math.Pow(nilaiharga2, 2)));
                x2 = Math.Abs(Math.Sqrt(Math.Pow(nilaiLayar1, 2) + Math.Pow(nilaiLayar2, 2)));
                x3 = Math.Abs(Math.Sqrt(Math.Pow(nilaiProc1, 2) + Math.Pow(nilaiProc2, 2)));
                x4 = Math.Abs(Math.Sqrt(Math.Pow(nilaiRam1, 2) + Math.Pow(nilaiRam2, 2)));
                x5 = Math.Abs(Math.Sqrt(Math.Pow(nilaiDdr1, 2) + Math.Pow(nilaiDdr2, 2)));
                x6 = Math.Abs(Math.Sqrt(Math.Pow(nilaiHdd1, 2) + Math.Pow(nilaiHdd2, 2)));
                x7 = Math.Abs(Math.Sqrt(Math.Pow(nilaiBt1, 2) + Math.Pow(nilaiBt2, 2)));
                x8 = Math.Abs(Math.Sqrt(Math.Pow(nilaiWbcam1, 2) + Math.Pow(nilaiWbcam2, 2)));
                r11 = nilaiharga1 / x1;
                r21 = nilaiharga2 / x1;
                r12 = nilaiLayar1 / x2;
                r22 = nilaiLayar2 / x2;
                r13 = nilaiProc1 / x3;
                r23 = nilaiProc2 / x3;
                r14 = nilaiRam1 / x4;
                r24 = nilaiRam2 / x4;
                r15 = nilaiDdr1 / x5;
                r25 = nilaiDdr2 / x5;
                r16 = nilaiHdd1 / x6;
                r26 = nilaiHdd2 / x6;
                r17 = nilaiBt1 / x7;
                r27 = nilaiBt2 / x7;
                r18 = nilaiWbcam1 / x8;
                r28 = nilaiWbcam2 / x8;

                y11 = r11 * w1;
                y21 = r21 * w1;
                y12 = r12 * w2;
                y22 = r22 * w2;
                y13 = r13 * w3;
                y23 = r23 * w3;
                y14 = r14 * w4;
                y24 = r24 * w4;
                y15 = r15 * w5;
                y25 = r25 * w5;
                y16 = r16 * w6;
                y26 = r26 * w6;
                y17 = r17 * w7;
                y27 = r27 * w7;
                y18 = r18 * w8;
                y28 = r28 * w8;

                if (y11 >= y21)
                {
                    y1plus = y11;
                }
                else if (y21 >= y11)
                {
                    y1plus = y21;
                }
                else if (y12 >= y22)
                {
                    y2plus = y12;
                }
                else if (y22 >= y12)
                {
                    y2plus = y22;
                }
                else if (y13 >= y23)
                {
                    y3plus = y13;
                }
                else if (y23 >= y13)
                {
                    y3plus = y23;
                }
                else if (y14 >= y24)
                {
                    y4plus = y14;
                }
                else if (y24 >= y14)
                {
                    y4plus = y24;
                }
                else if (y15 >= y25)
                {
                    y5plus = y15;
                }
                else if (y25 >= y15)
                {
                    y5plus = y25;
                }
                else if (y16 >= y26)
                {
                    y6plus = y16;
                }
                else if (y26 >= y16)
                {
                    y6plus = y26;
                }
                else if (y17 >= y27)
                {
                    y7plus = y17;
                }
                else if (y27 >= y17)
                {
                    y7plus = y27;
                }
                else if (y18 >= y28)
                {
                    y8plus = y18;
                }
                else if (y28 >= y18)
                {
                    y8plus = y28;
                }

                else if (y11 < y21)
                {
                    y1min = y11;
                }
                else if (y21 < y11)
                {
                    y1min = y21;
                }
                else if (y12 < y22)
                {
                    y2min = y12;
                }
                else if (y22 < y12)
                {
                    y2min = y22;
                }
                else if (y13 < y23)
                {
                    y3min = y13;
                }
                else if (y23 < y13)
                {
                    y3min = y23;
                }
                else if (y14 < y24)
                {
                    y4min = y14;
                }
                else if (y24 < y14)
                {
                    y4min = y24;
                }
                else if (y15 < y25)
                {
                    y5min = y15;
                }
                else if (y25 < y15)
                {
                    y5min = y25;
                }
                else if (y16 < y26)
                {
                    y6min = y16;
                }
                else if (y26 < y16)
                {
                    y6min = y26;
                }
                else if (y17 < y27)
                {
                    y7min = y17;
                }
                else if (y27 < y17)
                {
                    y7min = y27;
                }
                else if (y18 < y28)
                {
                    y8min = y18;
                }
                else if (y28 < y18)
                {
                    y8min = y28;
                }

                d1plus = Math.Sqrt(Math.Pow((y11 - y1plus), 2) + Math.Pow((y12 - y2plus), 2) + Math.Pow((y13 - y3plus), 2) + Math.Pow((y14 - y4plus), 2) + Math.Pow((y15 - y5plus), 2) + Math.Pow((y16 - y6plus), 2) + Math.Pow((y17 - y7plus), 2) + Math.Pow((y18 - y8plus), 2));
                d2plus = Math.Sqrt(Math.Pow((y21 - y1plus), 2) + Math.Pow((y22 - y2plus), 2) + Math.Pow((y23 - y3plus), 2) + Math.Pow((y24 - y4plus), 2) + Math.Pow((y25 - y5plus), 2) + Math.Pow((y26 - y6plus), 2) + Math.Pow((y27 - y7plus), 2) + Math.Pow((y28 - y8plus), 2));
                d1min = Math.Sqrt(Math.Pow((y11 - y1min), 2) + Math.Pow((y12 - y2min), 2) + Math.Pow((y13 - y3min), 2) + Math.Pow((y14 - y4min), 2) + Math.Pow((y15 - y5min), 2) + Math.Pow((y16 - y6min), 2) + Math.Pow((y17 - y7min), 2) + Math.Pow((y18 - y8min), 2));
                d2min = Math.Sqrt(Math.Pow((y21 - y1min), 2) + Math.Pow((y22 - y2min), 2) + Math.Pow((y23 - y3min), 2) + Math.Pow((y24 - y4min), 2) + Math.Pow((y25 - y5min), 2) + Math.Pow((y26 - y6min), 2) + Math.Pow((y27 - y7min), 2) + Math.Pow((y28 - y8min), 2));

                v1 = d1min / (d1min + d1plus);
                v2 = d2min / (d2min + d2plus);


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmutama fu = new frmutama();
            fu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMerk3.Visible = true;
            txtMerk3.Enabled = true;
            cbBlue3.Enabled = true;
            cbBlue3.Visible = true;
            cbHard3.Visible = true;
            cbHard3.Enabled = true;
            cbHarga3.Enabled = true;
            cbHarga3.Visible = true;
            cbDdr3.Visible = true;
            cbDdr3.Enabled = true;
            cbLayar3.Enabled = true;
            cbLayar3.Visible = true;
            cbPro3.Visible = true;
            cbPro3.Enabled = true;
            cbRam3.Enabled = true;
            cbRam3.Visible = true;
            cbWeb3.Visible = true;
            cbWeb3.Enabled = true;
        }

        private void FrmMulai_Load(object sender, EventArgs e)
        {
           
        }
    }
}
