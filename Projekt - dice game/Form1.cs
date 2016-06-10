using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt___dice_game
{
    public partial class Form1 : Form
    {
        #region zmienne
        Image[] kostkaImages;
        int[] kostka;
        Random rand;
        int iloscRzutow = 0, runda = 1;
        int posredniePkt1 = 0, posredniePkt2 = 0, posredniePkt3 = 0, posredniePkt4 = 0, posredniePkt5 = 0;
        bool sprawdz1 = false, sprawdz2 = false, sprawdz3 = false, sprawdz4 = false, sprawdz5 = false, wymusWybor = false;
        bool status = false;
        int gracz = 1, wynik = 0, wynikSzkola1 = 0, wynikSzkola2 = 0, wynikKoniec1 = 0, wynikKoniec2 = 0;
        int wynikSzkola1_r2 = 0, wynikSzkola2_r2 = 0, wynikKoniec1_r2 = 0, wynikKoniec2_r2 = 0;
        int wynikSzkola1_r3 = 0, wynikSzkola2_r3 = 0, wynikKoniec1_r3 = 0, wynikKoniec2_r3 = 0;
        int posredniWynik1 = 0, posredniWynik2 = 0, posredniWynik3 = 0, posredniWynik4 = 0, posredniWynik5 = 0, posredniWynik6 = 0;
        int trzeciaRunda = 0, ostatniWynik1 = 0, ostatniWynik2 =0;
        #endregion

        #region Formy
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kostkaImages = new Image[7];
            kostkaImages[0] = Properties.Resources.dice_blank;
            kostkaImages[1] = Properties.Resources.dice_1;
            kostkaImages[2] = Properties.Resources.dice_2;
            kostkaImages[3] = Properties.Resources.dice_3;
            kostkaImages[4] = Properties.Resources.dice_4;
            kostkaImages[5] = Properties.Resources.dice_5;
            kostkaImages[6] = Properties.Resources.dice_6;

            kostka = new int[5] { 0, 0, 0, 0, 0 };

            rand = new Random();
            sumaSzkola1.Text = "";
            sumaSzkola2.Text = "";
            gracz1Suma.Text = "";
            gracz2Suma.Text = "";
            

        }
        #endregion

        #region buttony

        //ROLLBUTTON
        private void rollButton_Click(object sender, EventArgs e)
        {
            sprawdzRadio();
            if (runda == 1)
            {
                if (wymusWybor == false)
                {
                    if (iloscRzutow < 3)
                    {
                        iloscRzutowLabel.Text = "Rzut: " + (iloscRzutow + 1).ToString();
                        if (zostaw1.Checked == false && sprawdz1 == true)
                        {
                            sprawdz1 = false;
                        }
                        if (zostaw2.Checked == false && sprawdz2 == true)
                        {
                            sprawdz2 = false;
                        }
                        if (zostaw3.Checked == false && sprawdz3 == true)
                        {
                            sprawdz3 = false;
                        }
                        if (zostaw4.Checked == false && sprawdz4 == true)
                        {
                            sprawdz4 = false;
                        }
                        if (zostaw5.Checked == false && sprawdz5 == true)
                        {
                            sprawdz5 = false;
                        }

                        RzutKostka();

                        if (iloscRzutow == 0)
                        {
                            warunekLabel.Text = "Wybierz co chcesz rzucać!";
                            wymusWybor = true;
                        }
                        else if (iloscRzutow == 2)
                        {
                            warunekLabel.Text = "            Wpisz wynik!";
                        }
                        else warunekLabel.Text = "";
                        iloscRzutow++;
                        sumaSzkola1.Text = wynikSzkola1.ToString();
                        sumaSzkola2.Text = wynikSzkola2.ToString();
                    }
                }
            }
            else if (runda == 2)
            {
                if (iloscRzutow < 3)
                {
                    iloscRzutowLabel.Text = "Rzut: " + (iloscRzutow + 1).ToString();
                    if (zostaw1.Checked == false && sprawdz1 == true)
                    {
                        sprawdz1 = false;
                    }
                    if (zostaw2.Checked == false && sprawdz2 == true)
                    {
                        sprawdz2 = false;
                    }
                    if (zostaw3.Checked == false && sprawdz3 == true)
                    {
                        sprawdz3 = false;
                    }
                    if (zostaw4.Checked == false && sprawdz4 == true)
                    {
                        sprawdz4 = false;
                    }
                    if (zostaw5.Checked == false && sprawdz5 == true)
                    {
                        sprawdz5 = false;
                    }

                    RzutKostka();

                    if (iloscRzutow == 2)
                    {
                        warunekLabel.Text = "            Wpisz wynik!";
                    }
                    else warunekLabel.Text = "";
                    iloscRzutow++;
                }
            }
            else if (runda == 3)
            {
                if (iloscRzutow < 3)
                {
                    iloscRzutowLabel.Text = "Rzut: " + (iloscRzutow + 1).ToString();
                    if (zostaw1.Checked == false && sprawdz1 == true)
                    {
                        sprawdz1 = false;
                    }
                    if (zostaw2.Checked == false && sprawdz2 == true)
                    {
                        sprawdz2 = false;
                    }
                    if (zostaw3.Checked == false && sprawdz3 == true)
                    {
                        sprawdz3 = false;
                    }
                    if (zostaw4.Checked == false && sprawdz4 == true)
                    {
                        sprawdz4 = false;
                    }
                    if (zostaw5.Checked == false && sprawdz5 == true)
                    {
                        sprawdz5 = false;
                    }

                    RzutKostka();

                    if (iloscRzutow == 2)
                    {
                        warunekLabel.Text = "            Wpisz wynik!";
                    }
                    else warunekLabel.Text = "";
                    iloscRzutow++;
                }
            }
        }

        //WPISZBUTTON
        private void wpiszButton_Click(object sender, EventArgs e)
        {
            if (runda == 1) 
            {
                if (radioButton1.Checked == true)
                    liczJeden();
                else if (radioButton2.Checked == true)
                    liczDwa();
                else if (radioButton3.Checked == true)
                    liczTrzy();
                else if (radioButton4.Checked == true)
                    liczCztery();
                else if (radioButton5.Checked == true)
                    liczPiec();
                else if (radioButton6.Checked == true)
                    liczSzesc();
                else if (jednaParaRadio.Checked == true)
                    para();
                else if (dwieParyRadio.Checked == true)
                    dwiePary();
                else if (trojkaRadio.Checked == true)
                    trojka();
                else if (malyRadio.Checked == true)
                    maly();
                else if (duzyRadio.Checked == true)
                    duzy();
                else if (fullRadio.Checked == true)
                    full();
                else if (karetaRadio.Checked == true)
                    kareta();
                else if (pokerRadio.Checked == true)
                    poker();
                else if (szansaRadio.Checked == true)
                    szansa();

                sumaSzkola1.Text = wynikSzkola1.ToString();
                sumaSzkola2.Text = wynikSzkola2.ToString();
            }
            else if (runda == 2)
            {
                if (radioButton1.Checked == true)
                    liczJeden2();
                else if (radioButton2.Checked == true)
                    liczDwa2();
                else if (radioButton3.Checked == true)
                    liczTrzy2();
                else if (radioButton4.Checked == true)
                    liczCztery2();
                else if (radioButton5.Checked == true)
                    liczPiec2();
                else if (radioButton6.Checked == true)
                    liczSzesc2();
                else if (jednaParaRadio.Checked == true)
                    para2();
                else if (dwieParyRadio.Checked == true)
                    dwiePary2();
                else if (trojkaRadio.Checked == true)
                    trojka2();
                else if (malyRadio.Checked == true)
                    maly2();
                else if (duzyRadio.Checked == true)
                    duzy2();
                else if (fullRadio.Checked == true)
                    full2();
                else if (karetaRadio.Checked == true)
                    kareta2();
                else if (pokerRadio.Checked == true)
                    poker2();
                else if (szansaRadio.Checked == true)
                    szansa2();

                sumaSzkola1_r2.Text = wynikSzkola1_r2.ToString();
                sumaSzkola2_r2.Text = wynikSzkola2_r2.ToString();
            }
            else if (runda == 3)
            {
                
                if(trzeciaRunda == 0)
                {
                                       
                    wykluczanie();
                    liczJeden3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        radioButton2.Checked = true;
                    } 
                }
                else if (trzeciaRunda == 1)
                {
                    wykluczanie();
                    liczDwa3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        radioButton3.Checked = true;
                    }
                }

                else if(trzeciaRunda == 2)
                {
                    wykluczanie();
                    liczTrzy3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        radioButton4.Checked = true;
                    }
                }

                else if (trzeciaRunda == 3)
                {
                    wykluczanie();
                    liczCztery3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        radioButton5.Checked = true;
                    }
                }

                else if (trzeciaRunda == 4)
                {
                    wykluczanie();
                    liczPiec3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        radioButton6.Checked = true;
                    }
                }

                else if (trzeciaRunda == 5)
                {
                    wykluczanie();
                    liczSzesc3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        jednaParaRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 6)
                {
                    wykluczanie();
                    para3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        dwieParyRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 7)
                {
                    wykluczanie();
                    dwiePary3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        trojkaRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 8)
                {
                    wykluczanie();
                    trojka3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        malyRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 9)
                {
                    wykluczanie();
                    maly3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        duzyRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 10)
                {
                    wykluczanie();
                    duzy3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        fullRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 11)
                {
                    wykluczanie();
                    full3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        karetaRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 12)
                {
                    wykluczanie();
                    kareta3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        pokerRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 13)
                {
                    wykluczanie();
                    poker3();
                    kasowanieCheck();
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                        szansaRadio.Checked = true;
                    }
                }

                else if (trzeciaRunda == 14)
                {
                    wykluczanie();
                    szansa3();
                    kasowanieCheck();        
                    if (gracz == 2)
                    {
                        trzeciaRunda++;
                    }
                }

                sumaSzkola1_r3.Text = wynikSzkola1_r3.ToString();
                sumaSzkola2_r3.Text = wynikSzkola2_r3.ToString();
            }
            

            //zmiana graczy
            if (runda == 1)
            {
                if (gracz == 1)
                {
                    gracz = 2;
                    ktoryGraczLabel.Text = "Gracz 2";
                    gracz2_label.BackColor = Color.Orange;
                    gracz1_label.BackColor = Color.ForestGreen;
                }
                else
                {
                    gracz = 1;
                    ktoryGraczLabel.Text = "Gracz 1";
                    gracz2_label.BackColor = Color.ForestGreen;
                    gracz1_label.BackColor = Color.Orange;
                }

                iloscRzutow = 0;
                iloscRzutowLabel.Text = "Rzut: 0";
                warunekLabel.Text = "";
                wynik = 0;
                kasowanieRadioCheck();
                wymusWybor = false;
                status = false;
                
                //wykluczanie
                if (gracz == 1)
                {
                    wykluczanieGracz1();
                }
                else if (gracz == 2)
                {
                    wykluczanieGracz2();
                }
                lbl_dice1.Image = Properties.Resources.dice_blank;
                lbl_dice2.Image = Properties.Resources.dice_blank;
                lbl_dice3.Image = Properties.Resources.dice_blank;
                lbl_dice4.Image = Properties.Resources.dice_blank;
                lbl_dice5.Image = Properties.Resources.dice_blank;
                czyKoniec();
                
            }
            else if (runda == 2)
            {
                if (gracz == 1)
                {
                    gracz = 2;
                    ktoryGraczLabel.Text = "Gracz 2";
                    gracz2_label_r2.BackColor = Color.Orange;
                    gracz1_label_r2.BackColor = Color.Firebrick;
                }
                else
                {
                    gracz = 1;
                    ktoryGraczLabel.Text = "Gracz 1";
                    gracz2_label_r2.BackColor = Color.Firebrick;
                    gracz1_label_r2.BackColor = Color.Orange;
                }

                iloscRzutow = 0;
                iloscRzutowLabel.Text = "Rzut: 0";
                warunekLabel.Text = "";
                wynik = 0;
                kasowanieRadioCheck2();
                status = false;

                //wykluczanie
                if (gracz == 1)
                {
                    wykluczanieGracz1_r2();
                }
                else if (gracz == 2)
                {
                    wykluczanieGracz2_r2();
                }
                lbl_dice1.Image = Properties.Resources.dice_blank;
                lbl_dice2.Image = Properties.Resources.dice_blank;
                lbl_dice3.Image = Properties.Resources.dice_blank;
                lbl_dice4.Image = Properties.Resources.dice_blank;
                lbl_dice5.Image = Properties.Resources.dice_blank;

                czyKoniec2();
            }
            else if (runda == 3)
            {
                if (gracz == 1)
                {
                    gracz = 2;
                    ktoryGraczLabel.Text = "Gracz 2";
                    gracz2_label_r3.BackColor = Color.Orange;
                    gracz1_label_r3.BackColor = Color.LightSeaGreen;
                }
                else
                {
                    gracz = 1;
                    ktoryGraczLabel.Text = "Gracz 1";
                    gracz2_label_r3.BackColor = Color.LightSeaGreen;
                    gracz1_label_r3.BackColor = Color.Orange;
                }

                iloscRzutow = 0;
                iloscRzutowLabel.Text = "Rzut: 0";
                warunekLabel.Text = "";
                wynik = 0;
                //kasowanieRadioCheck3();
                status = false;

                //wykluczanie
                if (gracz == 1)
                {
                    wykluczanieGracz1_r3();
                }
                else if (gracz == 2)
                {
                    wykluczanieGracz2_r3();
                }
                lbl_dice1.Image = Properties.Resources.dice_blank;
                lbl_dice2.Image = Properties.Resources.dice_blank;
                lbl_dice3.Image = Properties.Resources.dice_blank;
                lbl_dice4.Image = Properties.Resources.dice_blank;
                lbl_dice5.Image = Properties.Resources.dice_blank;

                czyKoniec3();
            }
            
        }
        //czy koniec gry
        public void czyKoniec()
        {
            int sprawdz = 0;
            if (gracz2_1.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_4.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_5.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_6.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Jedna.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Dwie.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Trojka.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Maly.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Duzy.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Full.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Kareta.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Poker.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Szansa.Text != "")
            {
                sprawdz++;
            }
            //15
            if (sprawdz == 15)
            {
                liczenie1();
                liczenie2();
                runda++;
                kasowanieRadioCheck2();
                gracz1_label.BackColor = Color.ForestGreen;
                gracz2_label.BackColor = Color.ForestGreen;
                gracz1_label_r2.BackColor = Color.Orange;
                if(wynikSzkola1<-9)
                {
                    wynikSzkola1 -= 50;
                    sumaSzkola1.Text = wynikSzkola1.ToString();
                    //wynikKoniec1 -= 50;
                }
                else if (wynikSzkola1 >9)
                {
                    wynikSzkola1 += 50;
                    sumaSzkola1.Text = wynikSzkola1.ToString();
                    //wynikKoniec1 += 50;
                }

                if (wynikSzkola2 < -9)
                {
                    wynikSzkola2 -= 50;
                    sumaSzkola2.Text = wynikSzkola2.ToString();
                    //wynikKoniec2 -= 50;
                }
                else if (wynikSzkola2 > 9)
                {
                    wynikSzkola2 += 50;
                    sumaSzkola2.Text = wynikSzkola2.ToString();
                    //wynikKoniec2 += 50;
                }
                wynikKoniec1 += wynikSzkola1;
                wynikKoniec2 += wynikSzkola2;
                gracz1Suma.Text = wynikKoniec1.ToString();
                gracz2Suma.Text = wynikKoniec2.ToString();
                
            }
        }

        public void czyKoniec2()
        {
            int sprawdz = 0;
            if (gracz2_1_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_2_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_3_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_4_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_5_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_6_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Jedna_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Dwie_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Trojka_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Maly_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Duzy_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Full_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Kareta_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Poker_r2.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Szansa_r2.Text != "")
            {
                sprawdz++;
            }
            //15
            if (sprawdz == 15)
            {
                liczenie1_r2();
                liczenie2_r2();
                runda++;
                kasowanieRadioCheck3();
                gracz1_label_r2.BackColor = Color.Firebrick;
                gracz2_label_r2.BackColor = Color.Firebrick;
                gracz1_label_r3.BackColor = Color.Orange;
                if (wynikSzkola1_r2 < -9)
                {
                    wynikSzkola1_r2 -= 50;
                    sumaSzkola1_r2.Text = wynikSzkola1_r2.ToString();
                    //wynikKoniec1_r2 -= 50;
                }
                else if (wynikSzkola1_r2 > 9)
                {
                    wynikSzkola1_r2 += 50;
                    sumaSzkola1_r2.Text = wynikSzkola1_r2.ToString();
                    //wynikKoniec1_r2 += 50;
                }

                if (wynikSzkola2_r2 < -9)
                {
                    wynikSzkola2_r2 -= 50;
                    sumaSzkola2_r2.Text = wynikSzkola2_r2.ToString();
                    //wynikKoniec2_r2 -= 50;
                }
                else if (wynikSzkola2_r2 > 9)
                {
                    wynikSzkola2_r2 += 50;
                    sumaSzkola2_r2.Text = wynikSzkola2_r2.ToString();
                    //wynikKoniec2_r2 += 50;
                    
                }
                wynikKoniec1_r2 += wynikSzkola1_r2;
                wynikKoniec2_r2 += wynikSzkola2_r2;
                gracz2Suma_r2.Text = wynikKoniec2_r2.ToString();
                gracz1Suma_r2.Text = wynikKoniec1_r2.ToString();
                radioButton1.Checked = true;
            }
        }

        public void czyKoniec3()
        {
            int sprawdz = 0;
            if (gracz2_1_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_2_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_3_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_4_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_5_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2_6_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Jedna_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Dwie_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Trojka_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Maly_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Duzy_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Full_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Kareta_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Poker_r3.Text != "")
            {
                sprawdz++;
            }
            if (gracz2Szansa_r3.Text != "")
            {
                sprawdz++;
            }
            //15
            if (sprawdz == 15)
            {
                liczenie1_r3();
                liczenie2_r3();
                if (wynikSzkola1_r3 < -9)
                {
                    wynikSzkola1_r3 -= 50;
                    sumaSzkola1_r3.Text = wynikSzkola1_r3.ToString();
                    //wynikKoniec1_r3 -= 50;

                }
                else if (wynikSzkola1_r3 > 9)
                {
                    wynikSzkola1_r3 += 50;
                    sumaSzkola1_r3.Text = wynikSzkola1_r3.ToString();
                    //wynikKoniec1_r3 += 50;
                }

                if (wynikSzkola2_r3 < -9)
                {
                    wynikSzkola2_r3 -= 50;
                    sumaSzkola2_r3.Text = wynikSzkola2_r3.ToString();
                    //wynikKoniec2_r3 -= 50;
                }
                else if (wynikSzkola2_r3 > 9)
                {
                    wynikSzkola2_r3 += 50;
                    sumaSzkola2_r3.Text = wynikSzkola2_r3.ToString();
                    //wynikKoniec2_r3 += 50;
                    
                }
                wynikKoniec1_r3 += wynikSzkola1_r3;
                wynikKoniec2_r3 += wynikSzkola2_r3;
                gracz2Suma_r3.Text = wynikKoniec2_r3.ToString();
                gracz1Suma_r3.Text = wynikKoniec1_r3.ToString();

                posredniWynik1 = Int32.Parse(gracz1Suma.Text);
                posredniWynik2 = Int32.Parse(gracz2Suma.Text);
                posredniWynik3 = Int32.Parse(gracz1Suma_r2.Text);
                posredniWynik4 = Int32.Parse(gracz2Suma_r2.Text);
                posredniWynik5 = Int32.Parse(gracz1Suma_r3.Text);
                posredniWynik6 = Int32.Parse(gracz2Suma_r3.Text);

                ostatniWynik1 = posredniWynik1 + posredniWynik3 + posredniWynik5;
                ostatniWynik2 = posredniWynik2 + posredniWynik4 + posredniWynik6;

                if (ostatniWynik1 > ostatniWynik2)
                    MessageBox.Show("Gracz 1: " + ostatniWynik1 + "\nGracz 2: " + ostatniWynik2 + "\nWYGRAŁ GRACZ 1");
                else if (ostatniWynik2 > ostatniWynik1)
                    MessageBox.Show("Gracz 1: " + ostatniWynik1 + "\nGracz 2: " + ostatniWynik2 + "\nWYGRAŁ GRACZ 2");
                else if (ostatniWynik1 == ostatniWynik2)
                    MessageBox.Show("Gracz 1: " + ostatniWynik1 + "\nGracz 2: " + ostatniWynik2 + "\nREMIS");
            }
        }

        
           
        #endregion

        #region rzut
        //RZUTY
        private void RzutKostka()
        {
            if (runda == 1)
            {
                if (gracz == 1)
                {
                    gracz2_label.BackColor = Color.ForestGreen;
                    gracz1_label.BackColor = Color.Orange;
                }
                else if (gracz == 2)
                {
                    gracz2_label.BackColor = Color.Orange;
                    gracz1_label.BackColor = Color.ForestGreen;
                }
            }
            else if (runda == 2)
            {
                if (gracz == 1)
                {
                    gracz2_label_r2.BackColor = Color.Firebrick;
                    gracz1_label_r2.BackColor = Color.Orange;
                }
                else if (gracz == 2)
                {
                    gracz2_label_r2.BackColor = Color.Orange;
                    gracz1_label_r2.BackColor = Color.Firebrick;
                }
            }
            else if (runda == 3)
            {
                if (gracz == 1)
                {
                    gracz2_label_r3.BackColor = Color.LightSeaGreen;
                    gracz1_label_r3.BackColor = Color.Orange;
                }
                else if (gracz == 2)
                {
                    gracz2_label_r3.BackColor = Color.Orange;
                    gracz1_label_r3.BackColor = Color.LightSeaGreen;
                }
            }
            //losowanie obrazkow
            for (int i=0; i <kostka.Length; i++)
            {
                kostka[i] = rand.Next(1, 7);
            }

            //pierwsza kostka
            if (zostaw1.Checked == false && sprawdz1 == false)
            {
                lbl_dice1.Image = kostkaImages[kostka[0]];
                posredniePkt1 = kostka[0];
            }
            else if (zostaw1.Checked == true)
            {
                sprawdz1 = true;
            }

            //druga kostka
            if (zostaw2.Checked == false && sprawdz2 == false) 
            { 
                lbl_dice2.Image = kostkaImages[kostka[1]];
                posredniePkt2 = kostka[1];
            } 
            else if(zostaw2.Checked == true)
            {
                sprawdz2 = true;
            }

            //trzecia kostka
            if (zostaw3.Checked == false && sprawdz3 == false) 
            { 
                lbl_dice3.Image = kostkaImages[kostka[2]];
                posredniePkt3 = kostka[2];
            } 
            else if(zostaw3.Checked == true)
            {
                sprawdz3 = true;
            }

            //czwarta kostka
            if (zostaw4.Checked == false && sprawdz4 == false) 
            { 
                lbl_dice4.Image = kostkaImages[kostka[3]];
                posredniePkt4 = kostka[3];
            }
            else if(zostaw4.Checked == true)
            {
                sprawdz4 = true;
            }

            //piąta kostka
            if (zostaw5.Checked == false && sprawdz5 == false) 
            { 
                lbl_dice5.Image = kostkaImages[kostka[4]];
                posredniePkt5 = kostka[4];
            }
            else if(zostaw5.Checked == true)
            {
                sprawdz5 = true;
            }

        }
        #endregion

        #region szkola kombinacje
        //jedynki
        public void liczJeden()
        {
                if (posredniePkt1 == 1)
                    wynik += 1;
                if (posredniePkt2 == 1)
                    wynik += 1;
                if (posredniePkt3 == 1)
                    wynik += 1;
                if (posredniePkt4 == 1)
                    wynik += 1;
                if (posredniePkt5 == 1)
                    wynik += 1;
            if(gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_1.Text = "-3";
                    wynikSzkola1 -= 3;
                    wynikKoniec1 -= 3;
                }
                if (wynik == 1)
                {
                    gracz1_1.Text = "-2";
                    wynikSzkola1 -= 2;
                    wynikKoniec1 -= 2;
                }
                if (wynik == 2)
                {
                    gracz1_1.Text = "-1";
                    wynikSzkola1 -= 1;
                    wynikKoniec1 -= 1;
                }
                if (wynik == 3)
                    gracz1_1.Text = "x";

                if (wynik == 4)
                {
                    gracz1_1.Text = "1";
                    wynikSzkola1 += 1;
                    wynikKoniec1 += 1;
                }
                if (wynik == 5)
                {
                    gracz1_1.Text = "2";
                    wynikSzkola1 += 2;
                    wynikKoniec1 += 2;
                }
            } 
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_1.Text = "-3";
                    wynikSzkola2 -= 3;
                    wynikKoniec2 -= 3;
                }
                if (wynik == 1)
                {
                    gracz2_1.Text = "-2";
                    wynikSzkola2 -= 2;
                    wynikKoniec2 -= 2;
                }
                if (wynik == 2)
                {
                    gracz2_1.Text = "-1";
                    wynikSzkola2 -= 1;
                    wynikKoniec2 -= 1;
                }
                if (wynik == 3)
                    gracz2_1.Text = "x";

                if (wynik == 4)
                {
                    gracz2_1.Text = "1";
                    wynikSzkola2 += 1;
                    wynikKoniec2 += 1;
                }
                if (wynik == 5)
                {
                    gracz2_1.Text = "2";
                    wynikSzkola2 += 2;
                    wynikKoniec2 += 2;
                }
            }
        }
        //dwójki
        public void liczDwa()
        {
            if (posredniePkt1 == 2)
                wynik += 2;
            if (posredniePkt2 == 2)
                wynik += 2;
            if (posredniePkt3 == 2)
                wynik += 2;
            if (posredniePkt4 == 2)
                wynik += 2;
            if (posredniePkt5 == 2)
                wynik += 2;
            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_2.Text = "-6";
                    wynikSzkola1 -= 6;
                    wynikKoniec1 -= 6;
                }
                if (wynik == 2)
                {
                    gracz1_2.Text = "-4";
                    wynikSzkola1 -= 4;
                    wynikKoniec1 -= 4;
                }
                if (wynik == 4)
                {
                    gracz1_2.Text = "-2";
                    wynikSzkola1 -= 2;
                    wynikKoniec1 -= 2;
                }
                if (wynik == 6)
                    gracz1_2.Text = "x";

                if (wynik == 8)
                {
                    gracz1_2.Text = "2";
                    wynikSzkola1 += 2;
                    wynikKoniec1 += 2;
                }
                if (wynik == 10)
                {
                    gracz1_2.Text = "4";
                    wynikSzkola1 += 4;
                    wynikKoniec1 += 4;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_2.Text = "-6";
                    wynikSzkola2 -= 6;
                    wynikKoniec2 -= 6;
                }
                if (wynik == 2)
                {
                    gracz2_2.Text = "-4";
                    wynikSzkola2 -= 4;
                    wynikKoniec2 -= 4;
                }
                if (wynik == 4)
                {
                    gracz2_2.Text = "-2";
                    wynikSzkola2 -= 2;
                    wynikKoniec2 -= 2;
                }
                if (wynik == 6)
                    gracz2_2.Text = "x";

                if (wynik == 8)
                {
                    gracz2_2.Text = "2";
                    wynikSzkola2 += 2;
                    wynikKoniec2 += 2;
                }
                if (wynik == 10)
                {
                    gracz2_2.Text = "4";
                    wynikSzkola2 += 4;
                    wynikKoniec2 += 4;
                }
            }
        }
        //trójki
        public void liczTrzy()
        {
            if (posredniePkt1 == 3)
                wynik += 3;
            if (posredniePkt2 == 3)
                wynik += 3;
            if (posredniePkt3 == 3)
                wynik += 3;
            if (posredniePkt4 == 3)
                wynik += 3;
            if (posredniePkt5 == 3)
                wynik += 3;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_3.Text = "-9";
                    wynikSzkola1 -= 9;
                    wynikKoniec1 -= 9;
                }
                if (wynik == 3)
                {
                    gracz1_3.Text = "-6";
                    wynikSzkola1 -= 6;
                    wynikKoniec1 -= 6;
                }
                if (wynik == 6)
                {
                    gracz1_3.Text = "-3";
                    wynikSzkola1 -= 3;
                    wynikKoniec1 -= 3;
                }
                if (wynik == 9)
                    gracz1_3.Text = "x";

                if (wynik == 12)
                {
                    gracz1_3.Text = "3";
                    wynikSzkola1 += 3;
                    wynikKoniec1 += 3;
                }
                if (wynik == 15)
                {
                    gracz1_3.Text = "6";
                    wynikSzkola1 += 6;
                    wynikKoniec1 += 6;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_3.Text = "-9";
                    wynikSzkola2 -= 9;
                    wynikKoniec2 -= 9;
                }
                if (wynik == 3)
                {
                    gracz2_3.Text = "-6";
                    wynikSzkola2 -= 6;
                    wynikKoniec2 -= 6;
                }
                if (wynik == 6)
                {
                    gracz2_3.Text = "-3";
                    wynikSzkola2 -= 3;
                    wynikKoniec2 -= 3;
                }
                if (wynik == 9)
                    gracz2_3.Text = "x";

                if (wynik == 12)
                {
                    gracz2_3.Text = "3";
                    wynikSzkola2 += 3;
                    wynikKoniec2 += 3;
                }
                if (wynik == 15)
                {
                    gracz2_3.Text = "6";
                    wynikSzkola2 += 6;
                    wynikKoniec2 += 6;
                }
            }
        }
        //czwórki
        public void liczCztery()
        {
            if (posredniePkt1 == 4)
                wynik += 4;
            if (posredniePkt2 == 4)
                wynik += 4;
            if (posredniePkt3 == 4)
                wynik += 4;
            if (posredniePkt4 == 4)
                wynik += 4;
            if (posredniePkt5 == 4)
                wynik += 4;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_4.Text = "-12";
                    wynikSzkola1 -= 12;
                    wynikKoniec1 -= 12;
                }
                if (wynik == 4)
                {
                    gracz1_4.Text = "-8";
                    wynikSzkola1 -= 8;
                    wynikKoniec1 -= 8;
                }
                if (wynik == 8)
                {
                    gracz1_4.Text = "-4";
                    wynikSzkola1 -= 4;
                    wynikKoniec1 -= 4;
                }
                if (wynik == 12)
                    gracz1_4.Text = "x";

                if (wynik == 16)
                {
                    gracz1_4.Text = "4";
                    wynikSzkola1 += 4;
                    wynikKoniec1 += 4;
                }
                if (wynik == 20)
                {
                    gracz1_4.Text = "8";
                    wynikSzkola1 += 8;
                    wynikKoniec1 += 8;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_4.Text = "-12";
                    wynikSzkola2 -= 12;
                    wynikKoniec2 -= 12;
                }
                if (wynik == 4)
                {
                    gracz2_4.Text = "-8";
                    wynikSzkola2 -= 8;
                    wynikKoniec2 -= 8;
                }
                if (wynik == 8)
                {
                    gracz2_4.Text = "-4";
                    wynikSzkola2 -= 4;
                    wynikKoniec2 -= 4;
                }
                if (wynik == 12)
                    gracz2_4.Text = "x";

                if (wynik == 16)
                {
                    gracz2_4.Text = "4";
                    wynikSzkola2 += 4;
                    wynikKoniec2 += 4;
                }
                if (wynik == 20)
                {
                    gracz2_4.Text = "8";
                    wynikSzkola2 += 8;
                    wynikKoniec2 += 8;
                }
            }
        }
        //piątki
        public void liczPiec()
        {
            if (posredniePkt1 == 5)
                wynik += 5;
            if (posredniePkt2 == 5)
                wynik += 5;
            if (posredniePkt3 == 5)
                wynik += 5;
            if (posredniePkt4 == 5)
                wynik += 5;
            if (posredniePkt5 == 5)
                wynik += 5;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_5.Text = "-15";
                    wynikSzkola1 -= 15;
                    wynikKoniec1 -= 15;
                }
                if (wynik == 5)
                {
                    gracz1_5.Text = "-10";
                    wynikSzkola1 -= 10;
                    wynikKoniec1 -= 10;
                }
                if (wynik == 10)
                {
                    gracz1_5.Text = "-5";
                    wynikSzkola1 -= 5;
                    wynikKoniec1 -= 5;
                }
                if (wynik == 15)
                    gracz1_5.Text = "x";

                if (wynik == 20)
                {
                    gracz1_5.Text = "5";
                    wynikSzkola1 += 5;
                    wynikKoniec1 += 5;
                }
                if (wynik == 25)
                {
                    gracz1_5.Text = "10";
                    wynikSzkola1 += 10;
                    wynikKoniec1 += 10;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_5.Text = "-15";
                    wynikSzkola2 -= 15;
                    wynikKoniec2 -= 15;
                }
                if (wynik == 5)
                {
                    gracz2_5.Text = "-10";
                    wynikSzkola2 -= 10;
                    wynikKoniec2 -= 10;
                }
                if (wynik == 10)
                {
                    gracz2_5.Text = "-5";
                    wynikSzkola2 -= 5;
                    wynikKoniec2 -= 5;
                }
                if (wynik == 15)
                    gracz2_5.Text = "x";

                if (wynik == 20)
                {
                    gracz2_5.Text = "5";
                    wynikSzkola2 += 5;
                    wynikKoniec2 += 5;
                }
                if (wynik == 25)
                {
                    gracz2_5.Text = "10";
                    wynikSzkola2 += 10;
                    wynikKoniec2 += 10;
                }
            }
        }
        //szóstki
        public void liczSzesc()
        {
            if (posredniePkt1 == 6)
                wynik += 6;
            if (posredniePkt2 == 6)
                wynik += 6;
            if (posredniePkt3 == 6)
                wynik += 6;
            if (posredniePkt4 == 6)
                wynik += 6;
            if (posredniePkt5 == 6)
                wynik += 6;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_6.Text = "-18";
                    wynikSzkola1 -= 18;
                    wynikKoniec1 -= 18;
                }
                if (wynik == 6)
                {
                    gracz1_6.Text = "-12";
                    wynikSzkola1 -= 12;
                    wynikKoniec1 -= 12;
                }
                if (wynik == 12)
                {
                    gracz1_6.Text = "-6";
                    wynikSzkola1 -= 6;
                    wynikKoniec1 -= 6;
                }
                if (wynik == 18)
                    gracz1_6.Text = "x";

                if (wynik == 24)
                {
                    gracz1_6.Text = "6";
                    wynikSzkola1 += 6;
                    wynikKoniec1 += 6;
                }
                if (wynik == 30)
                {
                    gracz1_6.Text = "12";
                    wynikSzkola1 += 12;
                    wynikKoniec1 += 12;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_6.Text = "-18";
                    wynikSzkola2 -= 18;
                    wynikKoniec2 -= 18;
                }
                if (wynik == 6)
                {
                    gracz2_6.Text = "-12";
                    wynikSzkola2 -= 12;
                    wynikKoniec2 -= 12;
                }
                if (wynik == 12)
                {
                    gracz2_6.Text = "-6";
                    wynikSzkola2 -= 6;
                    wynikKoniec2 -= 6;
                }
                if (wynik == 18)
                    gracz2_6.Text = "x";

                if (wynik == 24)
                {
                    gracz2_6.Text = "6";
                    wynikSzkola2 += 6;
                    wynikKoniec2 += 6;
                }
                if (wynik == 30)
                {
                    gracz2_6.Text = "12";
                    wynikSzkola2 += 12;
                    wynikKoniec2 += 12;
                }
            }
        }

        //jedynki
        public void liczJeden2()
        {
            if (posredniePkt1 == 1)
                wynik += 1;
            if (posredniePkt2 == 1)
                wynik += 1;
            if (posredniePkt3 == 1)
                wynik += 1;
            if (posredniePkt4 == 1)
                wynik += 1;
            if (posredniePkt5 == 1)
                wynik += 1;
            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_1_r2.Text = "-3";
                    wynikSzkola1_r2 -= 3;
                    wynikKoniec1_r2 -= 3;
                }
                if (wynik == 1)
                {
                    gracz1_1_r2.Text = "-2";
                    wynikSzkola1_r2 -= 2;
                    wynikKoniec1_r2 -= 2;
                }
                if (wynik == 2)
                {
                    gracz1_1_r2.Text = "-1";
                    wynikSzkola1_r2 -= 1;
                    wynikKoniec1_r2 -= 1;
                }
                if (wynik == 3)
                    gracz1_1_r2.Text = "x";

                if (wynik == 4)
                {
                    gracz1_1_r2.Text = "1";
                    wynikSzkola1_r2 += 1;
                    wynikKoniec1_r2 += 1;
                }
                if (wynik == 5)
                {
                    gracz1_1_r2.Text = "2";
                    wynikSzkola1_r2 += 2;
                    wynikKoniec1_r2 += 2;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_1_r2.Text = "-3";
                    wynikSzkola2_r2 -= 3;
                    wynikKoniec2_r2 -= 3;
                }
                if (wynik == 1)
                {
                    gracz2_1_r2.Text = "-2";
                    wynikSzkola2_r2 -= 2;
                    wynikKoniec2_r2 -= 2;
                }
                if (wynik == 2)
                {
                    gracz2_1_r2.Text = "-1";
                    wynikSzkola2_r2 -= 1;
                    wynikKoniec2_r2 -= 1;
                }
                if (wynik == 3)
                    gracz2_1_r2.Text = "x";

                if (wynik == 4)
                {
                    gracz2_1_r2.Text = "1";
                    wynikSzkola2_r2 += 1;
                    wynikKoniec2_r2 += 1;
                }
                if (wynik == 5)
                {
                    gracz2_1_r2.Text = "2";
                    wynikSzkola2_r2 += 2;
                    wynikKoniec2_r2 += 2;
                }
            }
        }
        //dwójki
        public void liczDwa2()
        {
            if (posredniePkt1 == 2)
                wynik += 2;
            if (posredniePkt2 == 2)
                wynik += 2;
            if (posredniePkt3 == 2)
                wynik += 2;
            if (posredniePkt4 == 2)
                wynik += 2;
            if (posredniePkt5 == 2)
                wynik += 2;
            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_2_r2.Text = "-6";
                    wynikSzkola1_r2 -= 6;
                    wynikKoniec1_r2 -= 6;
                }
                if (wynik == 2)
                {
                    gracz1_2_r2.Text = "-4";
                    wynikSzkola1_r2 -= 4;
                    wynikKoniec1_r2 -= 4;
                }
                if (wynik == 4)
                {
                    gracz1_2_r2.Text = "-2";
                    wynikSzkola1_r2 -= 2;
                    wynikKoniec1_r2 -= 2;
                }
                if (wynik == 6)
                    gracz1_2_r2.Text = "x";

                if (wynik == 8)
                {
                    gracz1_2_r2.Text = "2";
                    wynikSzkola1_r2 += 2;
                    wynikKoniec1_r2 += 2;
                }
                if (wynik == 10)
                {
                    gracz1_2_r2.Text = "4";
                    wynikSzkola1_r2 += 4;
                    wynikKoniec1_r2 += 4;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_2_r2.Text = "-6";
                    wynikSzkola2_r2 -= 6;
                    wynikKoniec2_r2 -= 6;
                }
                if (wynik == 2)
                {
                    gracz2_2_r2.Text = "-4";
                    wynikSzkola2_r2 -= 4;
                    wynikKoniec2_r2 -= 4;
                }
                if (wynik == 4)
                {
                    gracz2_2_r2.Text = "-2";
                    wynikSzkola2_r2 -= 2;
                    wynikKoniec2_r2 -= 2;
                }
                if (wynik == 6)
                    gracz2_2_r2.Text = "x";

                if (wynik == 8)
                {
                    gracz2_2_r2.Text = "2";
                    wynikSzkola2_r2 += 2;
                    wynikKoniec2_r2 += 2;
                }
                if (wynik == 10)
                {
                    gracz2_2_r2.Text = "4";
                    wynikSzkola2_r2 += 4;
                    wynikKoniec2_r2 += 4;
                }
            }
        }
        //trójki
        public void liczTrzy2()
        {
            if (posredniePkt1 == 3)
                wynik += 3;
            if (posredniePkt2 == 3)
                wynik += 3;
            if (posredniePkt3 == 3)
                wynik += 3;
            if (posredniePkt4 == 3)
                wynik += 3;
            if (posredniePkt5 == 3)
                wynik += 3;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_3_r2.Text = "-9";
                    wynikSzkola1_r2 -= 9;
                    wynikKoniec1_r2 -= 9;
                }
                if (wynik == 3)
                {
                    gracz1_3_r2.Text = "-6";
                    wynikSzkola1_r2 -= 6;
                    wynikKoniec1_r2 -= 6;
                }
                if (wynik == 6)
                {
                    gracz1_3_r2.Text = "-3";
                    wynikSzkola1_r2 -= 3;
                    wynikKoniec1_r2 -= 3;
                }
                if (wynik == 9)
                    gracz1_3_r2.Text = "x";

                if (wynik == 12)
                {
                    gracz1_3_r2.Text = "3";
                    wynikSzkola1_r2 += 3;
                    wynikKoniec1_r2 += 3;
                }
                if (wynik == 15)
                {
                    gracz1_3_r2.Text = "6";
                    wynikSzkola1_r2 += 6;
                    wynikKoniec1_r2 += 6;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_3_r2.Text = "-9";
                    wynikSzkola2_r2 -= 9;
                    wynikKoniec2_r2 -= 9;
                }
                if (wynik == 3)
                {
                    gracz2_3_r2.Text = "-6";
                    wynikSzkola2_r2 -= 6;
                    wynikKoniec2_r2 -= 6;
                }
                if (wynik == 6)
                {
                    gracz2_3_r2.Text = "-3";
                    wynikSzkola2_r2 -= 3;
                    wynikKoniec2_r2 -= 3;
                }
                if (wynik == 9)
                    gracz2_3_r2.Text = "x";

                if (wynik == 12)
                {
                    gracz2_3_r2.Text = "3";
                    wynikSzkola2_r2 += 3;
                    wynikKoniec2_r2 += 3;
                }
                if (wynik == 15)
                {
                    gracz2_3_r2.Text = "6";
                    wynikSzkola2_r2 += 6;
                    wynikKoniec2_r2 += 6;
                }
            }
        }
        //czwórki
        public void liczCztery2()
        {
            if (posredniePkt1 == 4)
                wynik += 4;
            if (posredniePkt2 == 4)
                wynik += 4;
            if (posredniePkt3 == 4)
                wynik += 4;
            if (posredniePkt4 == 4)
                wynik += 4;
            if (posredniePkt5 == 4)
                wynik += 4;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_4_r2.Text = "-12";
                    wynikSzkola1_r2 -= 12;
                    wynikKoniec1_r2 -= 12;
                }
                if (wynik == 4)
                {
                    gracz1_4_r2.Text = "-8";
                    wynikSzkola1_r2 -= 8;
                    wynikKoniec1_r2 -= 8;
                }
                if (wynik == 8)
                {
                    gracz1_4_r2.Text = "-4";
                    wynikSzkola1_r2 -= 4;
                    wynikKoniec1_r2 -= 4;
                }
                if (wynik == 12)
                    gracz1_4_r2.Text = "x";

                if (wynik == 16)
                {
                    gracz1_4_r2.Text = "4";
                    wynikSzkola1_r2 += 4;
                    wynikKoniec1_r2 += 4;
                }
                if (wynik == 20)
                {
                    gracz1_4_r2.Text = "8";
                    wynikSzkola1_r2 += 8;
                    wynikKoniec1_r2 += 8;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_4_r2.Text = "-12";
                    wynikSzkola2_r2 -= 12;
                    wynikKoniec2_r2 -= 12;
                }
                if (wynik == 4)
                {
                    gracz2_4_r2.Text = "-8";
                    wynikSzkola2_r2 -= 8;
                    wynikKoniec2_r2 -= 8;
                }
                if (wynik == 8)
                {
                    gracz2_4_r2.Text = "-4";
                    wynikSzkola2_r2 -= 4;
                    wynikKoniec2_r2 -= 4;
                }
                if (wynik == 12)
                    gracz2_4_r2.Text = "x";

                if (wynik == 16)
                {
                    gracz2_4_r2.Text = "4";
                    wynikSzkola2_r2 += 4;
                    wynikKoniec2_r2 += 4;
                }
                if (wynik == 20)
                {
                    gracz2_4_r2.Text = "8";
                    wynikSzkola2_r2 += 8;
                    wynikKoniec2_r2 += 8;
                }
            }
        }
        //piątki
        public void liczPiec2()
        {
            if (posredniePkt1 == 5)
                wynik += 5;
            if (posredniePkt2 == 5)
                wynik += 5;
            if (posredniePkt3 == 5)
                wynik += 5;
            if (posredniePkt4 == 5)
                wynik += 5;
            if (posredniePkt5 == 5)
                wynik += 5;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_5_r2.Text = "-15";
                    wynikSzkola1_r2 -= 15;
                    wynikKoniec1_r2 -= 15;
                }
                if (wynik == 5)
                {
                    gracz1_5_r2.Text = "-10";
                    wynikSzkola1_r2 -= 10;
                    wynikKoniec1_r2 -= 10;
                }
                if (wynik == 10)
                {
                    gracz1_5_r2.Text = "-5";
                    wynikSzkola1_r2 -= 5;
                    wynikKoniec1_r2 -= 5;
                }
                if (wynik == 15)
                    gracz1_5_r2.Text = "x";

                if (wynik == 20)
                {
                    gracz1_5_r2.Text = "5";
                    wynikSzkola1_r2 += 5;
                    wynikKoniec1_r2 += 5;
                }
                if (wynik == 25)
                {
                    gracz1_5_r2.Text = "10";
                    wynikSzkola1_r2 += 10;
                    wynikKoniec1_r2 += 10;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_5_r2.Text = "-15";
                    wynikSzkola2_r2 -= 15;
                    wynikKoniec2_r2 -= 15;
                }
                if (wynik == 5)
                {
                    gracz2_5_r2.Text = "-10";
                    wynikSzkola2_r2 -= 10;
                    wynikKoniec2_r2 -= 10;
                }
                if (wynik == 10)
                {
                    gracz2_5_r2.Text = "-5";
                    wynikSzkola2_r2 -= 5;
                    wynikKoniec2_r2 -= 5;
                }
                if (wynik == 15)
                    gracz2_5_r2.Text = "x";

                if (wynik == 20)
                {
                    gracz2_5_r2.Text = "5";
                    wynikSzkola2_r2 += 5;
                    wynikKoniec2_r2 += 5;
                }
                if (wynik == 25)
                {
                    gracz2_5_r2.Text = "10";
                    wynikSzkola2_r2 += 10;
                    wynikKoniec2_r2 += 10;
                }
            }
        }
        //szóstki
        public void liczSzesc2()
        {
            if (posredniePkt1 == 6)
                wynik += 6;
            if (posredniePkt2 == 6)
                wynik += 6;
            if (posredniePkt3 == 6)
                wynik += 6;
            if (posredniePkt4 == 6)
                wynik += 6;
            if (posredniePkt5 == 6)
                wynik += 6;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_6_r2.Text = "-18";
                    wynikSzkola1_r2 -= 18;
                    wynikKoniec1_r2 -= 18;
                }
                if (wynik == 6)
                {
                    gracz1_6_r2.Text = "-12";
                    wynikSzkola1_r2 -= 12;
                    wynikKoniec1_r2 -= 12;
                }
                if (wynik == 12)
                {
                    gracz1_6_r2.Text = "-6";
                    wynikSzkola1_r2 -= 6;
                    wynikKoniec1_r2 -= 6;
                }
                if (wynik == 18)
                    gracz1_6_r2.Text = "x";

                if (wynik == 24)
                {
                    gracz1_6_r2.Text = "6";
                    wynikSzkola1_r2 += 6;
                    wynikKoniec1_r2 += 6;
                }
                if (wynik == 30)
                {
                    gracz1_6_r2.Text = "12";
                    wynikSzkola1_r2 += 12;
                    wynikKoniec1_r2 += 12;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_6_r2.Text = "-18";
                    wynikSzkola2_r2 -= 18;
                    wynikKoniec2_r2 -= 18;
                }
                if (wynik == 6)
                {
                    gracz2_6_r2.Text = "-12";
                    wynikSzkola2_r2 -= 12;
                    wynikKoniec2_r2 -= 12;
                }
                if (wynik == 12)
                {
                    gracz2_6_r2.Text = "-6";
                    wynikSzkola2_r2 -= 6;
                    wynikKoniec2_r2 -= 6;
                }
                if (wynik == 18)
                    gracz2_6_r2.Text = "x";

                if (wynik == 24)
                {
                    gracz2_6_r2.Text = "6";
                    wynikSzkola2_r2 += 6;
                    wynikKoniec2_r2 += 6;
                }
                if (wynik == 30)
                {
                    gracz2_6_r2.Text = "12";
                    wynikSzkola2_r2 += 12;
                    wynikKoniec2_r2 += 12;
                }
            }
        }

        //jedynki
        public void liczJeden3()
        {
            if (posredniePkt1 == 1)
                wynik += 1;
            if (posredniePkt2 == 1)
                wynik += 1;
            if (posredniePkt3 == 1)
                wynik += 1;
            if (posredniePkt4 == 1)
                wynik += 1;
            if (posredniePkt5 == 1)
                wynik += 1;
            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_1_r3.Text = "-3";
                    wynikSzkola1_r3 -= 3;
                    wynikKoniec1_r3 -= 3;
                }
                if (wynik == 1)
                {
                    gracz1_1_r3.Text = "-2";
                    wynikSzkola1_r3 -= 2;
                    wynikKoniec1_r3 -= 2;
                }
                if (wynik == 2)
                {
                    gracz1_1_r3.Text = "-1";
                    wynikSzkola1_r3 -= 1;
                    wynikKoniec1_r3 -= 1;
                }
                if (wynik == 3)
                    gracz1_1_r3.Text = "x";

                if (wynik == 4)
                {
                    gracz1_1_r3.Text = "1";
                    wynikSzkola1_r3 += 1;
                    wynikKoniec1_r3 += 1;
                }
                if (wynik == 5)
                {
                    gracz1_1_r3.Text = "2";
                    wynikSzkola1_r3 += 2;
                    wynikKoniec1_r3 += 2;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_1_r3.Text = "-3";
                    wynikSzkola2_r3 -= 3;
                    wynikKoniec2_r3 -= 3;
                }
                if (wynik == 1)
                {
                    gracz2_1_r3.Text = "-2";
                    wynikSzkola2_r3 -= 2;
                    wynikKoniec2_r3 -= 2;
                }
                if (wynik == 2)
                {
                    gracz2_1_r3.Text = "-1";
                    wynikSzkola2_r3 -= 1;
                    wynikKoniec2_r3 -= 1;
                }
                if (wynik == 3)
                    gracz2_1_r3.Text = "x";

                if (wynik == 4)
                {
                    gracz2_1_r3.Text = "1";
                    wynikSzkola2_r3 += 1;
                    wynikKoniec2_r3 += 1;
                }
                if (wynik == 5)
                {
                    gracz2_1_r3.Text = "2";
                    wynikSzkola2_r3 += 2;
                    wynikKoniec2_r3 += 2;
                }
            }           
        }
        //dwójki
        public void liczDwa3()
        {
            if (posredniePkt1 == 2)
                wynik += 2;
            if (posredniePkt2 == 2)
                wynik += 2;
            if (posredniePkt3 == 2)
                wynik += 2;
            if (posredniePkt4 == 2)
                wynik += 2;
            if (posredniePkt5 == 2)
                wynik += 2;
            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_2_r3.Text = "-6";
                    wynikSzkola1_r3 -= 6;
                    wynikKoniec1_r3 -= 6;
                }
                if (wynik == 2)
                {
                    gracz1_2_r3.Text = "-4";
                    wynikSzkola1_r3 -= 4;
                    wynikKoniec1_r3 -= 4;
                }
                if (wynik == 4)
                {
                    gracz1_2_r3.Text = "-2";
                    wynikSzkola1_r3 -= 2;
                    wynikKoniec1_r3 -= 2;
                }
                if (wynik == 6)
                    gracz1_2_r3.Text = "x";

                if (wynik == 8)
                {
                    gracz1_2_r3.Text = "2";
                    wynikSzkola1_r3 += 2;
                    wynikKoniec1_r3 += 2;
                }
                if (wynik == 10)
                {
                    gracz1_2_r3.Text = "4";
                    wynikSzkola1_r3 += 4;
                    wynikKoniec1_r3 += 4;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_2_r3.Text = "-6";
                    wynikSzkola2_r3 -= 6;
                    wynikKoniec2_r3 -= 6;
                }
                if (wynik == 2)
                {
                    gracz2_2_r3.Text = "-4";
                    wynikSzkola2_r3 -= 4;
                    wynikKoniec2_r3 -= 4;
                }
                if (wynik == 4)
                {
                    gracz2_2_r3.Text = "-2";
                    wynikSzkola2_r3 -= 2;
                    wynikKoniec2_r3 -= 2;
                }
                if (wynik == 6)
                    gracz2_2_r3.Text = "x";

                if (wynik == 8)
                {
                    gracz2_2_r3.Text = "2";
                    wynikSzkola2_r3 += 2;
                    wynikKoniec2_r3 += 2;
                }
                if (wynik == 10)
                {
                    gracz2_2_r3.Text = "4";
                    wynikSzkola2_r3 += 4;
                    wynikKoniec2_r3 += 4;
                }
            }
        }
        //trójki
        public void liczTrzy3()
        {
            if (posredniePkt1 == 3)
                wynik += 3;
            if (posredniePkt2 == 3)
                wynik += 3;
            if (posredniePkt3 == 3)
                wynik += 3;
            if (posredniePkt4 == 3)
                wynik += 3;
            if (posredniePkt5 == 3)
                wynik += 3;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_3_r3.Text = "-9";
                    wynikSzkola1_r3 -= 9;
                    wynikKoniec1_r3 -= 9;
                }
                if (wynik == 3)
                {
                    gracz1_3_r3.Text = "-6";
                    wynikSzkola1_r3 -= 6;
                    wynikKoniec1_r3 -= 6;
                }
                if (wynik == 6)
                {
                    gracz1_3_r3.Text = "-3";
                    wynikSzkola1_r3 -= 3;
                    wynikKoniec1_r3 -= 3;
                }
                if (wynik == 9)
                    gracz1_3_r3.Text = "x";

                if (wynik == 12)
                {
                    gracz1_3_r3.Text = "3";
                    wynikSzkola1_r3 += 3;
                    wynikKoniec1_r3 += 3;
                }
                if (wynik == 15)
                {
                    gracz1_3_r3.Text = "6";
                    wynikSzkola1_r3 += 6;
                    wynikKoniec1_r3 += 6;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_3_r3.Text = "-9";
                    wynikSzkola2_r3 -= 9;
                    wynikKoniec2_r3 -= 9;
                }
                if (wynik == 3)
                {
                    gracz2_3_r3.Text = "-6";
                    wynikSzkola2_r3 -= 6;
                    wynikKoniec2_r3 -= 6;
                }
                if (wynik == 6)
                {
                    gracz2_3_r3.Text = "-3";
                    wynikSzkola2_r3 -= 3;
                    wynikKoniec2_r3 -= 3;
                }
                if (wynik == 9)
                    gracz2_3_r3.Text = "x";

                if (wynik == 12)
                {
                    gracz2_3_r3.Text = "3";
                    wynikSzkola2_r3 += 3;
                    wynikKoniec2_r3 += 3;
                }
                if (wynik == 15)
                {
                    gracz2_3_r3.Text = "6";
                    wynikSzkola2_r3 += 6;
                    wynikKoniec2_r3 += 6;
                }
            }
        }
        //czwórki
        public void liczCztery3()
        {
            if (posredniePkt1 == 4)
                wynik += 4;
            if (posredniePkt2 == 4)
                wynik += 4;
            if (posredniePkt3 == 4)
                wynik += 4;
            if (posredniePkt4 == 4)
                wynik += 4;
            if (posredniePkt5 == 4)
                wynik += 4;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_4_r3.Text = "-12";
                    wynikSzkola1_r3 -= 12;
                    wynikKoniec1_r3 -= 12;
                }
                if (wynik == 4)
                {
                    gracz1_4_r3.Text = "-8";
                    wynikSzkola1_r3 -= 8;
                    wynikKoniec1_r3 -= 8;
                }
                if (wynik == 8)
                {
                    gracz1_4_r3.Text = "-4";
                    wynikSzkola1_r3 -= 4;
                    wynikKoniec1_r3 -= 4;
                }
                if (wynik == 12)
                    gracz1_4_r3.Text = "x";

                if (wynik == 16)
                {
                    gracz1_4_r3.Text = "4";
                    wynikSzkola1_r3 += 4;
                    wynikKoniec1_r3 += 4;
                }
                if (wynik == 20)
                {
                    gracz1_4_r3.Text = "8";
                    wynikSzkola1_r3 += 8;
                    wynikKoniec1_r3 += 8;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_4_r3.Text = "-12";
                    wynikSzkola2_r3 -= 12;
                    wynikKoniec2_r3 -= 12;
                }
                if (wynik == 4)
                {
                    gracz2_4_r3.Text = "-8";
                    wynikSzkola2_r3 -= 8;
                    wynikKoniec2_r3 -= 8;
                }
                if (wynik == 8)
                {
                    gracz2_4_r3.Text = "-4";
                    wynikSzkola2_r3 -= 4;
                    wynikKoniec2_r3 -= 4;
                }
                if (wynik == 12)
                    gracz2_4_r3.Text = "x";

                if (wynik == 16)
                {
                    gracz2_4_r3.Text = "4";
                    wynikSzkola2_r3 += 4;
                    wynikKoniec2_r3 += 4;
                }
                if (wynik == 20)
                {
                    gracz2_4_r3.Text = "8";
                    wynikSzkola2_r3 += 8;
                    wynikKoniec2_r3 += 8;
                }
            }
        }
        //piątki
        public void liczPiec3()
        {
            if (posredniePkt1 == 5)
                wynik += 5;
            if (posredniePkt2 == 5)
                wynik += 5;
            if (posredniePkt3 == 5)
                wynik += 5;
            if (posredniePkt4 == 5)
                wynik += 5;
            if (posredniePkt5 == 5)
                wynik += 5;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_5_r3.Text = "-15";
                    wynikSzkola1_r3 -= 15;
                    wynikKoniec1_r3 -= 15;
                }
                if (wynik == 5)
                {
                    gracz1_5_r3.Text = "-10";
                    wynikSzkola1_r3 -= 10;
                    wynikKoniec1_r3 -= 10;
                }
                if (wynik == 10)
                {
                    gracz1_5_r3.Text = "-5";
                    wynikSzkola1_r3 -= 5;
                    wynikKoniec1_r3 -= 5;
                }
                if (wynik == 15)
                    gracz1_5_r3.Text = "x";

                if (wynik == 20)
                {
                    gracz1_5_r3.Text = "5";
                    wynikSzkola1_r3 += 5;
                    wynikKoniec1_r3 += 5;
                }
                if (wynik == 25)
                {
                    gracz1_5_r3.Text = "10";
                    wynikSzkola1_r3 += 10;
                    wynikKoniec1_r3 += 10;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_5_r3.Text = "-15";
                    wynikSzkola2_r3 -= 15;
                    wynikKoniec2_r3 -= 15;
                }
                if (wynik == 5)
                {
                    gracz2_5_r3.Text = "-10";
                    wynikSzkola2_r3 -= 10;
                    wynikKoniec2_r3 -= 10;
                }
                if (wynik == 10)
                {
                    gracz2_5_r3.Text = "-5";
                    wynikSzkola2_r3 -= 5;
                    wynikKoniec2_r3 -= 5;
                }
                if (wynik == 15)
                    gracz2_5_r3.Text = "x";

                if (wynik == 20)
                {
                    gracz2_5_r3.Text = "5";
                    wynikSzkola2_r3 += 5;
                    wynikKoniec2_r3 += 5;
                }
                if (wynik == 25)
                {
                    gracz2_5_r3.Text = "10";
                    wynikSzkola2_r3 += 10;
                    wynikKoniec2_r3 += 10;
                }
            }
        }
        //szóstki
        public void liczSzesc3()
        {
            if (posredniePkt1 == 6)
                wynik += 6;
            if (posredniePkt2 == 6)
                wynik += 6;
            if (posredniePkt3 == 6)
                wynik += 6;
            if (posredniePkt4 == 6)
                wynik += 6;
            if (posredniePkt5 == 6)
                wynik += 6;

            if (gracz == 1)
            {
                if (wynik == 0)
                {
                    gracz1_6_r3.Text = "-18";
                    wynikSzkola1_r3 -= 18;
                    wynikKoniec1_r3 -= 18;
                }
                if (wynik == 6)
                {
                    gracz1_6_r3.Text = "-12";
                    wynikSzkola1_r3 -= 12;
                    wynikKoniec1_r3 -= 12;
                }
                if (wynik == 12)
                {
                    gracz1_6_r3.Text = "-6";
                    wynikSzkola1_r3 -= 6;
                    wynikKoniec1_r3 -= 6;
                }
                if (wynik == 18)
                    gracz1_6_r3.Text = "x";

                if (wynik == 24)
                {
                    gracz1_6_r3.Text = "6";
                    wynikSzkola1_r3 += 6;
                    wynikKoniec1_r3 += 6;
                }
                if (wynik == 30)
                {
                    gracz1_6_r3.Text = "12";
                    wynikSzkola1_r3 += 12;
                    wynikKoniec1_r3 += 12;
                }
            }
            else if (gracz == 2)
            {
                if (wynik == 0)
                {
                    gracz2_6_r3.Text = "-18";
                    wynikSzkola2_r3 -= 18;
                    wynikKoniec2_r3 -= 18;
                }
                if (wynik == 6)
                {
                    gracz2_6_r3.Text = "-12";
                    wynikSzkola2_r3 -= 12;
                    wynikKoniec2_r3 -= 12;
                }
                if (wynik == 12)
                {
                    gracz2_6_r3.Text = "-6";
                    wynikSzkola2_r3 -= 6;
                    wynikKoniec2_r3 -= 6;
                }
                if (wynik == 18)
                    gracz2_6_r3.Text = "x";

                if (wynik == 24)
                {
                    gracz2_6_r3.Text = "6";
                    wynikSzkola2_r3 += 6;
                    wynikKoniec2_r3 += 6;
                }
                if (wynik == 30)
                {
                    gracz2_6_r3.Text = "12";
                    wynikSzkola2_r3 += 12;
                    wynikKoniec2_r3 += 12;
                }
            }
        }

        #endregion

        #region reszta kombinacji
        //Jedna para
        public void para()
        {
            //1
                if (posredniePkt1 == posredniePkt2)
                {
                    if (wynik < (posredniePkt1 * 2))
                    {
                        wynik = (posredniePkt1 * 2);
                        
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        } 
                        else if(gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //2
                if (posredniePkt1 == posredniePkt3)
                {
                    if (wynik < (posredniePkt1 * 2))
                    {
                        wynik = (posredniePkt1 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //3
                if (posredniePkt1 == posredniePkt4)
                {
                    if (wynik < (posredniePkt1 * 2))
                    {
                        wynik = (posredniePkt1 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //4
                if (posredniePkt1 == posredniePkt5)
                {
                    if (wynik < (posredniePkt1 * 2))
                    {
                        wynik = (posredniePkt1 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //5
                if (posredniePkt2 == posredniePkt3)
                {
                    if (wynik < (posredniePkt2 * 2))
                    {
                        wynik = (posredniePkt2 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //6
                if (posredniePkt2 == posredniePkt4)
                {
                    if (wynik < (posredniePkt2 * 2))
                    {
                        wynik = (posredniePkt2 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //7
                if (posredniePkt2 == posredniePkt5)
                {
                    if (wynik < (posredniePkt2 * 2))
                    {
                        wynik = (posredniePkt2 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //8
                if (posredniePkt3 == posredniePkt4)
                {
                    if (wynik < (posredniePkt3 * 2))
                    {
                        wynik = (posredniePkt3 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //9
                if (posredniePkt3 == posredniePkt5)
                {
                    if (wynik < (posredniePkt3 * 2))
                    {
                        wynik = (posredniePkt3 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }
                }
            //10
                if (posredniePkt4 == posredniePkt5)
                {
                    if (wynik < (posredniePkt4 * 2))
                    {
                        wynik = (posredniePkt4 * 2);
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Jedna.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Jedna.Text = wynik.ToString();
                        }
                    }

                }              
            //11
                if(status == false)
                {
                    if(gracz == 1)
                    {
                        gracz1Jedna.Text = "x";
                    }
                    if (gracz == 2)
                    {
                        gracz2Jedna.Text = "x";
                    }
                }
        }
        //Dwie pary
        public void dwiePary()
        {
            //pierwsze
                //1
                if(posredniePkt2 == posredniePkt3 && posredniePkt4 == posredniePkt5)
                {
                    if(wynik < ((posredniePkt2 * 2)+(posredniePkt4 * 2)))
                    {
                        wynik = ((posredniePkt2 * 2) + (posredniePkt4 * 2));
                        status = true;
                        if(gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //2
                if (posredniePkt2 == posredniePkt4 && posredniePkt3 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //3
                if (posredniePkt2 == posredniePkt5 && posredniePkt3 == posredniePkt4)
                {
                    if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }

            //drugie
                //1
                if (posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //2
                if (posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //3
                if (posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }

            //trzecie
                //1
                if (posredniePkt1 == posredniePkt2 && posredniePkt4 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //2
                if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //3
                if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }

            //czwarte
                //1
                if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //2
                if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt5)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //3
                if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }

            //piate
                //1
                if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //2
                if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt4)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
                //3
                if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt3)
                {
                    if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                    {
                        wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                        status = true;
                        if (gracz == 1)
                        {
                            gracz1Dwie.Text = wynik.ToString();
                        }
                        else if (gracz == 2)
                        {
                            gracz2Dwie.Text = wynik.ToString();
                        }
                    }
                }
            //status
                if(status == false)
                {
                    if(gracz == 1)
                    {
                        gracz1Dwie.Text = "x";
                    }
                    if(gracz == 2)
                    {
                        gracz2Dwie.Text = "x";
                    }
                }
        }
        //Trójka
        public void trojka()
        {
            //1
            if(posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if(gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if(gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = (posredniePkt3 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Trojka.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Trojka.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Trojka.Text = "x";
                }
            }
        }
        //Mały strit
        public void maly()
        {
            bool jest1 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if(posredniePkt1 == 1 || posredniePkt2 == 1 || posredniePkt3 == 1 || posredniePkt4 == 1 || posredniePkt5 == 1)
                jest1 = true;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;

            if(jest1 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if(gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Maly.Text = "30";
                    }
                    else gracz1Maly.Text = "15";
                    
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Maly.Text = "30";
                    }
                    else gracz2Maly.Text = "15";
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Maly.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Maly.Text = "x";
                }
            }
            
        }
        //Duży strit
        public void duzy()
        {
            bool jest6 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;
            if(posredniePkt1 == 6 || posredniePkt2 == 6 || posredniePkt3 == 6 || posredniePkt4 == 6 || posredniePkt5 == 6)
                jest6 = true;

            if(jest6 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if(gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Duzy.Text = "40";
                    }
                    else gracz1Duzy.Text = "20";
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Duzy.Text = "40";
                    }
                    else gracz2Duzy.Text = "20";
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Duzy.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Duzy.Text = "x";
                }
            }
            
        }
        //Full
        public void full()
        {
            //1
            if(posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt4 * 2));
                status = true;
                if(gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //5
            if(posredniePkt1==posredniePkt3 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt4)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt3)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 3));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Full.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Full.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Full.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Full.Text = "x";
                }
            }
        }
        //Kareta
        public void kareta()
        {
            //1
            if(posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if(gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Kareta.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Kareta.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Kareta.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Kareta.Text = "x";
                }
            }
        }
        //Poker
        public void poker()
        {
            //1
            if(posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 5) + 50);
                status = true;
                if(gracz == 1)
                {
                    gracz1Poker.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Poker.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Poker.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Poker.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Poker.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Poker.Text = "x";
                }
            }
        }
        //Szansa
        public void szansa()
        {
            //1
            wynik = (posredniePkt1 + posredniePkt2 + posredniePkt3 + posredniePkt4 + posredniePkt5);
            if(gracz == 1)
            {
                gracz1Szansa.Text = wynik.ToString();
            }
            else if(gracz == 2)
            {
                gracz2Szansa.Text = wynik.ToString();
            }
            
        }

        //Jedna para
        public void para2()
        {
            //1
            if (posredniePkt1 == posredniePkt2)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt4)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //4
            if (posredniePkt1 == posredniePkt5)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //5
            if (posredniePkt2 == posredniePkt3)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //6
            if (posredniePkt2 == posredniePkt4)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //7
            if (posredniePkt2 == posredniePkt5)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //8
            if (posredniePkt3 == posredniePkt4)
            {
                if (wynik < (posredniePkt3 * 2))
                {
                    wynik = (posredniePkt3 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //9
            if (posredniePkt3 == posredniePkt5)
            {
                if (wynik < (posredniePkt3 * 2))
                {
                    wynik = (posredniePkt3 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }
            }
            //10
            if (posredniePkt4 == posredniePkt5)
            {
                if (wynik < (posredniePkt4 * 2))
                {
                    wynik = (posredniePkt4 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r2.Text = wynik.ToString();
                    }
                }

            }
            //11
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Jedna_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Jedna_r2.Text = "x";
                }
            }
        }
        //Dwie pary
        public void dwiePary2()
        {
            //pierwsze
            //1
            if (posredniePkt2 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt2 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt2 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }

            //drugie
            //1
            if (posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }

            //trzecie
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }

            //czwarte
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }

            //piate
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt3)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r2.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r2.Text = wynik.ToString();
                    }
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Dwie_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Dwie_r2.Text = "x";
                }
            }

        }
        //Trójka
        public void trojka2()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = (posredniePkt3 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Trojka_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r2.Text = "x";
                }
            }
        }
        //Mały strit
        public void maly2()
        {
            bool jest1 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if (posredniePkt1 == 1 || posredniePkt2 == 1 || posredniePkt3 == 1 || posredniePkt4 == 1 || posredniePkt5 == 1)
                jest1 = true;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;

            if (jest1 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if (gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Maly_r2.Text = "30";
                    }
                    else gracz1Maly_r2.Text = "15";
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Maly_r2.Text = "30";
                    }
                    else gracz2Maly_r2.Text = "15";
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Maly_r2.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Maly_r2.Text = "x";
                }
            }
            
        }
        //Duży strit
        public void duzy2()
        {
            bool jest6 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;
            if (posredniePkt1 == 6 || posredniePkt2 == 6 || posredniePkt3 == 6 || posredniePkt4 == 6 || posredniePkt5 == 6)
                jest6 = true;

            if (jest6 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if (gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Duzy_r2.Text = "40";
                    }
                    else gracz1Duzy_r2.Text = "20"; 
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Duzy_r2.Text = "40";
                    }
                    else gracz2Duzy_r2.Text = "20";
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Duzy_r2.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Duzy_r2.Text = "x";
                }
            } 
            
        }
        //Full
        public void full2()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt4 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt4)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt3)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 3));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Full_r2.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Full_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Full_r2.Text = "x";
                }
            }
        }
        //Kareta
        public void kareta2()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Kareta_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Kareta_r2.Text = "x";
                }
            }
        }
        //Poker
        public void poker2()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 5) + 50);
                status = true;
                if (gracz == 1)
                {
                    gracz1Poker_r2.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Poker_r2.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Poker_r2.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Poker_r2.Text = wynik.ToString(); ;
                }
            }

            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Poker_r2.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Poker_r2.Text = "x";
                }
            }
        }
        //Szansa
        public void szansa2()
        {
            //1
            wynik = (posredniePkt1 + posredniePkt2 + posredniePkt3 + posredniePkt4 + posredniePkt5);
            if (gracz == 1)
            {
                gracz1Szansa_r2.Text = wynik.ToString();
            }
            else if (gracz == 2)
            {
                gracz2Szansa_r2.Text = wynik.ToString();
            }
        }

        //Jedna para
        public void para3()
        {
            //1
            if (posredniePkt1 == posredniePkt2)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt4)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //4
            if (posredniePkt1 == posredniePkt5)
            {
                if (wynik < (posredniePkt1 * 2))
                {
                    wynik = (posredniePkt1 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //5
            if (posredniePkt2 == posredniePkt3)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //6
            if (posredniePkt2 == posredniePkt4)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //7
            if (posredniePkt2 == posredniePkt5)
            {
                if (wynik < (posredniePkt2 * 2))
                {
                    wynik = (posredniePkt2 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //8
            if (posredniePkt3 == posredniePkt4)
            {
                if (wynik < (posredniePkt3 * 2))
                {
                    wynik = (posredniePkt3 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //9
            if (posredniePkt3 == posredniePkt5)
            {
                if (wynik < (posredniePkt3 * 2))
                {
                    wynik = (posredniePkt3 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }
            }
            //10
            if (posredniePkt4 == posredniePkt5)
            {
                if (wynik < (posredniePkt4 * 2))
                {
                    wynik = (posredniePkt4 * 2);
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Jedna_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Jedna_r3.Text = wynik.ToString();
                    }
                }

            }
            //11
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Jedna_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Jedna_r3.Text = "x";
                }
            }
        }
        //Dwie pary
        public void dwiePary3()
        {
            //pierwsze
            //1
            if (posredniePkt2 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt2 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt2 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt2 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt2 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }

            //drugie
            //1
            if (posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }

            //trzecie
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt4 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt4 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt4 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }

            //czwarte
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt5)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }

            //piate
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt3 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //2
            if (posredniePkt1 == posredniePkt3 && posredniePkt2 == posredniePkt4)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //3
            if (posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt3)
            {
                if (wynik < ((posredniePkt1 * 2) + (posredniePkt2 * 2)))
                {
                    wynik = ((posredniePkt1 * 2) + (posredniePkt2 * 2));
                    status = true;
                    if (gracz == 1)
                    {
                        gracz1Dwie_r3.Text = wynik.ToString();
                    }
                    else if (gracz == 2)
                    {
                        gracz2Dwie_r3.Text = wynik.ToString();
                    }
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Dwie_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Dwie_r3.Text = "x";
                }
            }

        }
        //Trójka
        public void trojka3()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = (posredniePkt3 * 3);
                status = true;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString();
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Trojka_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Trojka_r3.Text = "x";
                }
            }
            
        }
        //Mały strit
        public void maly3()
        {
            bool jest1 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if (posredniePkt1 == 1 || posredniePkt2 == 1 || posredniePkt3 == 1 || posredniePkt4 == 1 || posredniePkt5 == 1)
                jest1 = true;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;

            if (jest1 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if (gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Maly_r3.Text = "30";
                    }
                    else gracz1Maly_r3.Text = "15";
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Maly_r3.Text = "30";
                    }
                    else gracz2Maly_r3.Text = "15";
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Maly_r3.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Maly_r3.Text = "x";
                }
            }
            
        }
        //Duży strit
        public void duzy3()
        {
            bool jest6 = false, jest2 = false, jest3 = false, jest4 = false, jest5 = false;
            if (posredniePkt1 == 2 || posredniePkt2 == 2 || posredniePkt3 == 2 || posredniePkt4 == 2 || posredniePkt5 == 2)
                jest2 = true;
            if (posredniePkt1 == 3 || posredniePkt2 == 3 || posredniePkt3 == 3 || posredniePkt4 == 3 || posredniePkt5 == 3)
                jest3 = true;
            if (posredniePkt1 == 4 || posredniePkt2 == 4 || posredniePkt3 == 4 || posredniePkt4 == 4 || posredniePkt5 == 4)
                jest4 = true;
            if (posredniePkt1 == 5 || posredniePkt2 == 5 || posredniePkt3 == 5 || posredniePkt4 == 5 || posredniePkt5 == 5)
                jest5 = true;
            if (posredniePkt1 == 6 || posredniePkt2 == 6 || posredniePkt3 == 6 || posredniePkt4 == 6 || posredniePkt5 == 6)
                jest6 = true;

            if (jest6 == true && jest2 == true && jest3 == true && jest4 == true && jest5 == true)
            {
                if (gracz == 1)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz1Duzy_r3.Text = "40";
                    }
                    else gracz1Duzy_r3.Text = "20"; 
                }
                else if (gracz == 2)
                {
                    if (iloscRzutow == 1)
                    {
                        gracz2Duzy_r3.Text = "40";
                    }
                    else gracz2Duzy_r3.Text = "20"; 
                }
            }
            else
            {
                if (gracz == 1)
                {
                    gracz1Duzy_r3.Text = "x";
                }
                else if (gracz == 2)
                {
                    gracz2Duzy_r3.Text = "x";
                }
            }
            
        }
        //Full
        public void full3()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt4 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt4 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt5 && posredniePkt3 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt3 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt4)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //6
            if (posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5 && posredniePkt2 == posredniePkt3)
            {
                wynik = ((posredniePkt1 * 3) + (posredniePkt2 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //7
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //8
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt4)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //9
            if (posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5 && posredniePkt1 == posredniePkt3)
            {
                wynik = ((posredniePkt2 * 3) + (posredniePkt1 * 2));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            //10
            if (posredniePkt1 == posredniePkt2 && posredniePkt3 == posredniePkt4 && posredniePkt3 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 2) + (posredniePkt3 * 3));
                status = true;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Full_r3.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Full_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Full_r3.Text = "x";
                }
            }
        }
        //Kareta
        public void kareta3()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString();
                }
            }
            //2
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString();
                }
            }
            //3
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString();
                }
            }
            //4
            if (posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = (posredniePkt1 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString();
                }
            }
            //5
            if (posredniePkt2 == posredniePkt3 && posredniePkt2 == posredniePkt4 && posredniePkt2 == posredniePkt5)
            {
                wynik = (posredniePkt2 * 4);
                status = true;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString();
                }
            }
            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = wynik.ToString(); ;
                }
            }
            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Kareta_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Kareta_r3.Text = "x";
                }
            }
        }
        //Poker
        public void poker3()
        {
            //1
            if (posredniePkt1 == posredniePkt2 && posredniePkt1 == posredniePkt3 && posredniePkt1 == posredniePkt4 && posredniePkt1 == posredniePkt5)
            {
                wynik = ((posredniePkt1 * 5) + 50);
                status = true;
                if (gracz == 1)
                {
                    gracz1Poker_r3.Text = wynik.ToString();
                }
                else if (gracz == 2)
                {
                    gracz2Poker_r3.Text = wynik.ToString();
                }
            }

            if (iloscRzutow == 1)
            {
                wynik = wynik * 2;
                if (gracz == 1)
                {
                    gracz1Poker_r3.Text = wynik.ToString(); ;
                }
                if (gracz == 2)
                {
                    gracz2Poker_r3.Text = wynik.ToString(); ;
                }
            }

            //status
            if (status == false)
            {
                if (gracz == 1)
                {
                    gracz1Poker_r3.Text = "x";
                }
                if (gracz == 2)
                {
                    gracz2Poker_r3.Text = "x";
                }
            }
        }
        //Szansa
        public void szansa3()
        {
            //1
            wynik = (posredniePkt1 + posredniePkt2 + posredniePkt3 + posredniePkt4 + posredniePkt5);
            if (gracz == 1)
            {
                gracz1Szansa_r3.Text = wynik.ToString();
            }
            else if (gracz == 2)
            {
                gracz2Szansa_r3.Text = wynik.ToString();
            }
        }

        #endregion

        #region operacje na radio
        public void sprawdzRadio()
        {
            if (radioButton1.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (radioButton2.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (radioButton3.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (radioButton4.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (radioButton5.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (radioButton6.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (jednaParaRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (dwieParyRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (trojkaRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (malyRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (duzyRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (fullRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (karetaRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (pokerRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }
            else if (szansaRadio.Checked == true)
            {
                wymusWybor = false;
                wykluczanie();
            }

        }

        public void kasowanieRadioCheck()
        {
            //enable
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            jednaParaRadio.Enabled = true;
            dwieParyRadio.Enabled = true;
            trojkaRadio.Enabled = true;
            malyRadio.Enabled = true;
            duzyRadio.Enabled = true;
            fullRadio.Enabled = true;
            karetaRadio.Enabled = true;
            pokerRadio.Enabled = true;
            szansaRadio.Enabled = true;
            //backColor
            radioButton1.BackColor = Color.ForestGreen;
            radioButton2.BackColor = Color.ForestGreen;
            radioButton3.BackColor = Color.ForestGreen;
            radioButton4.BackColor = Color.ForestGreen;
            radioButton5.BackColor = Color.ForestGreen;
            radioButton6.BackColor = Color.ForestGreen;
            jednaParaRadio.BackColor = Color.ForestGreen;
            dwieParyRadio.BackColor = Color.ForestGreen;
            trojkaRadio.BackColor = Color.ForestGreen;
            malyRadio.BackColor = Color.ForestGreen;
            duzyRadio.BackColor = Color.ForestGreen;
            fullRadio.BackColor = Color.ForestGreen;
            karetaRadio.BackColor = Color.ForestGreen;
            pokerRadio.BackColor = Color.ForestGreen;
            szansaRadio.BackColor = Color.ForestGreen;
            //checkRadio
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            jednaParaRadio.Checked = false;
            dwieParyRadio.Checked = false;
            trojkaRadio.Checked = false;
            malyRadio.Checked = false;
            duzyRadio.Checked = false;
            fullRadio.Checked = false;
            karetaRadio.Checked = false;
            pokerRadio.Checked = false;
            szansaRadio.Checked = false;
            //checkCheck
            zostaw1.Checked = false;
            zostaw2.Checked = false;
            zostaw3.Checked = false;
            zostaw4.Checked = false;
            zostaw5.Checked = false;
        }

        public void kasowanieRadioCheck2()
        {
            //enable
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            jednaParaRadio.Enabled = true;
            dwieParyRadio.Enabled = true;
            trojkaRadio.Enabled = true;
            malyRadio.Enabled = true;
            duzyRadio.Enabled = true;
            fullRadio.Enabled = true;
            karetaRadio.Enabled = true;
            pokerRadio.Enabled = true;
            szansaRadio.Enabled = true;
            //backColor
            radioButton1.BackColor = Color.Firebrick;
            radioButton2.BackColor = Color.Firebrick;
            radioButton3.BackColor = Color.Firebrick;
            radioButton4.BackColor = Color.Firebrick;
            radioButton5.BackColor = Color.Firebrick;
            radioButton6.BackColor = Color.Firebrick;
            jednaParaRadio.BackColor = Color.Firebrick;
            dwieParyRadio.BackColor = Color.Firebrick;
            trojkaRadio.BackColor = Color.Firebrick;
            malyRadio.BackColor = Color.Firebrick;
            duzyRadio.BackColor = Color.Firebrick;
            fullRadio.BackColor = Color.Firebrick;
            karetaRadio.BackColor = Color.Firebrick;
            pokerRadio.BackColor = Color.Firebrick;
            szansaRadio.BackColor = Color.Firebrick;
            //checkRadio
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            jednaParaRadio.Checked = false;
            dwieParyRadio.Checked = false;
            trojkaRadio.Checked = false;
            malyRadio.Checked = false;
            duzyRadio.Checked = false;
            fullRadio.Checked = false;
            karetaRadio.Checked = false;
            pokerRadio.Checked = false;
            szansaRadio.Checked = false;
            //checkCheck
            zostaw1.Checked = false;
            zostaw2.Checked = false;
            zostaw3.Checked = false;
            zostaw4.Checked = false;
            zostaw5.Checked = false;
        }

        public void kasowanieRadioCheck3()
        {
            //enable
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            jednaParaRadio.Enabled = true;
            dwieParyRadio.Enabled = true;
            trojkaRadio.Enabled = true;
            malyRadio.Enabled = true;
            duzyRadio.Enabled = true;
            fullRadio.Enabled = true;
            karetaRadio.Enabled = true;
            pokerRadio.Enabled = true;
            szansaRadio.Enabled = true;
            //backColor
            radioButton1.BackColor = Color.LightSeaGreen;
            radioButton2.BackColor = Color.LightSeaGreen;
            radioButton3.BackColor = Color.LightSeaGreen;
            radioButton4.BackColor = Color.LightSeaGreen;
            radioButton5.BackColor = Color.LightSeaGreen;
            radioButton6.BackColor = Color.LightSeaGreen;
            jednaParaRadio.BackColor = Color.LightSeaGreen;
            dwieParyRadio.BackColor = Color.LightSeaGreen;
            trojkaRadio.BackColor = Color.LightSeaGreen;
            malyRadio.BackColor = Color.LightSeaGreen;
            duzyRadio.BackColor = Color.LightSeaGreen;
            fullRadio.BackColor = Color.LightSeaGreen;
            karetaRadio.BackColor = Color.LightSeaGreen;
            pokerRadio.BackColor = Color.LightSeaGreen;
            szansaRadio.BackColor = Color.LightSeaGreen;
            //checkRadio
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            jednaParaRadio.Checked = false;
            dwieParyRadio.Checked = false;
            trojkaRadio.Checked = false;
            malyRadio.Checked = false;
            duzyRadio.Checked = false;
            fullRadio.Checked = false;
            karetaRadio.Checked = false;
            pokerRadio.Checked = false;
            szansaRadio.Checked = false;
            //checkCheck
            zostaw1.Checked = false;
            zostaw2.Checked = false;
            zostaw3.Checked = false;
            zostaw4.Checked = false;
            zostaw5.Checked = false;
        }

        public void kasowanieCheck()
        {
            zostaw1.Checked = false;
            zostaw2.Checked = false;
            zostaw3.Checked = false;
            zostaw4.Checked = false;
            zostaw5.Checked = false;
        }

        public void wykluczanie()
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled= false;
            jednaParaRadio.Enabled = false;
            dwieParyRadio.Enabled = false;
            trojkaRadio.Enabled = false;
            malyRadio.Enabled = false;
            duzyRadio.Enabled = false;
            fullRadio.Enabled = false;
            karetaRadio.Enabled = false;
            pokerRadio.Enabled = false;
            szansaRadio.Enabled = false;
        }

        public void wykluczanieGracz1()
        {
            if (gracz1_1.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz1_2.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz1_3.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz1_4.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz1_5.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz1_6.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz1Jedna.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz1Dwie.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz1Trojka.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz1Maly.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz1Duzy.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz1Full.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz1Kareta.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz1Poker.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz1Szansa.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        public void wykluczanieGracz2()
        {
            if (gracz2_1.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz2_2.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz2_3.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz2_4.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz2_5.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz2_6.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz2Jedna.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz2Dwie.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz2Trojka.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz2Maly.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz2Duzy.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz2Full.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz2Kareta.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz2Poker.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz2Szansa.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        public void wykluczanieGracz1_r2()
        {
            if (gracz1_1_r2.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz1_2_r2.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz1_3_r2.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz1_4_r2.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz1_5_r2.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz1_6_r2.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz1Jedna_r2.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz1Dwie_r2.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz1Trojka_r2.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz1Maly_r2.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz1Duzy_r2.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz1Full_r2.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz1Kareta_r2.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz1Poker_r2.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz1Szansa_r2.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        public void wykluczanieGracz2_r2()
        {
            if (gracz2_1_r2.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz2_2_r2.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz2_3_r2.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz2_4_r2.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz2_5_r2.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz2_6_r2.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz2Jedna_r2.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz2Dwie_r2.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz2Trojka_r2.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz2Maly_r2.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz2Duzy_r2.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz2Full_r2.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz2Kareta_r2.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz2Poker_r2.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz2Szansa_r2.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        public void wykluczanieGracz1_r3()
        {
            if (gracz1_1_r3.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz1_2_r3.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz1_3_r3.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz1_4_r3.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz1_5_r3.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz1_6_r3.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz1Jedna_r3.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz1Dwie_r3.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz1Trojka_r3.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz1Maly_r3.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz1Duzy_r3.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz1Full_r3.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz1Kareta_r3.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz1Poker_r3.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz1Szansa_r3.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        public void wykluczanieGracz2_r3()
        {
            if (gracz2_1_r3.Text != "")
            {
                radioButton1.Enabled = false;
                radioButton1.BackColor = Color.Gray;
            }
            if (gracz2_2_r3.Text != "")
            {
                radioButton2.Enabled = false;
                radioButton2.BackColor = Color.Gray;
            }
            if (gracz2_3_r3.Text != "")
            {
                radioButton3.Enabled = false;
                radioButton3.BackColor = Color.Gray;
            }
            if (gracz2_4_r3.Text != "")
            {
                radioButton4.Enabled = false;
                radioButton4.BackColor = Color.Gray;
            }
            if (gracz2_5_r3.Text != "")
            {
                radioButton5.Enabled = false;
                radioButton5.BackColor = Color.Gray;
            }
            if (gracz2_6_r3.Text != "")
            {
                radioButton6.Enabled = false;
                radioButton6.BackColor = Color.Gray;
            }
            if (gracz2Jedna_r3.Text != "")
            {
                jednaParaRadio.Enabled = false;
                jednaParaRadio.BackColor = Color.Gray;
            }
            if (gracz2Dwie_r3.Text != "")
            {
                dwieParyRadio.Enabled = false;
                dwieParyRadio.BackColor = Color.Gray;
            }
            if (gracz2Trojka_r3.Text != "")
            {
                trojkaRadio.Enabled = false;
                trojkaRadio.BackColor = Color.Gray;
            }
            if (gracz2Maly_r3.Text != "")
            {
                malyRadio.Enabled = false;
                malyRadio.BackColor = Color.Gray;
            }
            if (gracz2Duzy_r3.Text != "")
            {
                duzyRadio.Enabled = false;
                duzyRadio.BackColor = Color.Gray;
            }
            if (gracz2Full_r3.Text != "")
            {
                fullRadio.Enabled = false;
                fullRadio.BackColor = Color.Gray;
            }
            if (gracz2Kareta_r3.Text != "")
            {
                karetaRadio.Enabled = false;
                karetaRadio.BackColor = Color.Gray;
            }
            if (gracz2Poker_r3.Text != "")
            {
                pokerRadio.Enabled = false;
                pokerRadio.BackColor = Color.Gray;
            }
            if (gracz2Szansa_r3.Text != "")
            {
                szansaRadio.Enabled = false;
                szansaRadio.BackColor = Color.Gray;
            }
        }

        #endregion

        #region liczenie
        public void liczenie1()
        {
            wynikKoniec1 = 0;
            //if (gracz1_1.Text != "" && gracz1_1.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_1.Text);                
            //}
            //if (gracz1_2.Text != "" && gracz1_2.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_2.Text);
            //}
            //if (gracz1_3.Text != "" && gracz1_3.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_3.Text);
            //}
            //if (gracz1_4.Text != "" && gracz1_4.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_4.Text);
            //}
            //if (gracz1_5.Text != "" && gracz1_5.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_5.Text);
            //}
            //if (gracz1_6.Text != "" && gracz1_6.Text != "x")
            //{
            //    wynikKoniec1 += Int32.Parse(gracz1_6.Text);
            //}
            if (gracz1Jedna.Text != "" && gracz1Jedna.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Jedna.Text);
            }
            if (gracz1Dwie.Text != "" && gracz1Dwie.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Dwie.Text);
            }
            if (gracz1Trojka.Text != "" && gracz1Trojka.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Trojka.Text);
            }
            if (gracz1Maly.Text != "" && gracz1Maly.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Maly.Text);
            }
            if (gracz1Duzy.Text != "" && gracz1Duzy.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Duzy.Text);
            }
            if (gracz1Full.Text != "" && gracz1Full.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Full.Text);
            }
            if (gracz1Kareta.Text != "" && gracz1Kareta.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Kareta.Text);
            }
            if (gracz1Poker.Text != "" && gracz1Poker.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Poker.Text);
            }
            if (gracz1Szansa.Text != "" && gracz1Szansa.Text != "x")
            {
                wynikKoniec1 += Int32.Parse(gracz1Szansa.Text);
               
            }
        }
        public void liczenie2()
        {
            wynikKoniec2 = 0;
            //if (gracz2_1.Text != "" && gracz2_1.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_1.Text);
            //}
            //if (gracz2_2.Text != "" && gracz2_2.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_2.Text);
            //}
            //if (gracz2_3.Text != "" && gracz2_3.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_3.Text);
            //}
            //if (gracz2_4.Text != "" && gracz2_4.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_4.Text);
            //}
            //if (gracz2_5.Text != "" && gracz2_5.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_5.Text);
            //}
            //if (gracz2_6.Text != "" && gracz2_6.Text != "x")
            //{
            //    wynikKoniec2 += Int32.Parse(gracz2_6.Text);
            //}
            if (gracz2Jedna.Text != "" && gracz2Jedna.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Jedna.Text);
            }
            if (gracz2Dwie.Text != "" && gracz2Dwie.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Dwie.Text);
            }
            if (gracz2Trojka.Text != "" && gracz2Trojka.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Trojka.Text);
            }
            if (gracz2Maly.Text != "" && gracz2Maly.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Maly.Text);
            }
            if (gracz2Duzy.Text != "" && gracz2Duzy.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Duzy.Text);
            }
            if (gracz2Full.Text != "" && gracz2Full.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Full.Text);
            }
            if (gracz2Kareta.Text != "" && gracz2Kareta.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Kareta.Text);
            }
            if (gracz2Poker.Text != "" && gracz2Poker.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Poker.Text);
            }
            if (gracz2Szansa.Text != "" && gracz2Szansa.Text != "x")
            {
                wynikKoniec2 += Int32.Parse(gracz2Szansa.Text);
            }
        }

        public void liczenie1_r2()
        {
            wynikKoniec1_r2 = 0;
            //if (gracz1_1_r2.Text != "" && gracz1_1_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_1_r2.Text);
            //}
            //if (gracz1_2_r2.Text != "" && gracz1_2_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_2_r2.Text);
            //}
            //if (gracz1_3_r2.Text != "" && gracz1_3_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_3_r2.Text);
            //}
            //if (gracz1_4_r2.Text != "" && gracz1_4_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_4_r2.Text);
            //}
            //if (gracz1_5_r2.Text != "" && gracz1_5_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_5_r2.Text);
            //}
            //if (gracz1_6_r2.Text != "" && gracz1_6_r2.Text != "x")
            //{
            //    wynikKoniec1_r2 += Int32.Parse(gracz1_6_r2.Text);
            //}
            if (gracz1Jedna_r2.Text != "" && gracz1Jedna_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Jedna_r2.Text);
            }
            if (gracz1Dwie_r2.Text != "" && gracz1Dwie_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Dwie_r2.Text);
            }
            if (gracz1Trojka_r2.Text != "" && gracz1Trojka_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Trojka_r2.Text);
            }
            if (gracz1Maly_r2.Text != "" && gracz1Maly_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Maly_r2.Text);
            }
            if (gracz1Duzy_r2.Text != "" && gracz1Duzy_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Duzy_r2.Text);
            }
            if (gracz1Full_r2.Text != "" && gracz1Full_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Full_r2.Text);
            }
            if (gracz1Kareta_r2.Text != "" && gracz1Kareta_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Kareta_r2.Text);
            }
            if (gracz1Poker_r2.Text != "" && gracz1Poker_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Poker_r2.Text);
            }
            if (gracz1Szansa_r2.Text != "" && gracz1Szansa_r2.Text != "x")
            {
                wynikKoniec1_r2 += Int32.Parse(gracz1Szansa_r2.Text);
            }
        }
        public void liczenie2_r2()
        {
            wynikKoniec2_r2 = 0;
            //if (gracz2_1_r2.Text != "" && gracz2_1_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_1_r2.Text);
            //}
            //if (gracz2_2_r2.Text != "" && gracz2_2_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_2_r2.Text);
            //}
            //if (gracz2_3_r2.Text != "" && gracz2_3_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_3_r2.Text);
            //}
            //if (gracz2_4_r2.Text != "" && gracz2_4_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_4_r2.Text);
            //}
            //if (gracz2_5_r2.Text != "" && gracz2_5_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_5_r2.Text);
            //}
            //if (gracz2_6_r2.Text != "" && gracz2_6_r2.Text != "x")
            //{
            //    wynikKoniec2_r2 += Int32.Parse(gracz2_6_r2.Text);
            //}
            if (gracz2Jedna_r2.Text != "" && gracz2Jedna_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Jedna_r2.Text);
            }
            if (gracz2Dwie_r2.Text != "" && gracz2Dwie_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Dwie_r2.Text);
            }
            if (gracz2Trojka_r2.Text != "" && gracz2Trojka_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Trojka_r2.Text);
            }
            if (gracz2Maly_r2.Text != "" && gracz2Maly_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Maly_r2.Text);
            }
            if (gracz2Duzy_r2.Text != "" && gracz2Duzy_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Duzy_r2.Text);
            }
            if (gracz2Full_r2.Text != "" && gracz2Full_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Full_r2.Text);
            }
            if (gracz2Kareta_r2.Text != "" && gracz2Kareta_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Kareta_r2.Text);
            }
            if (gracz2Poker_r2.Text != "" && gracz2Poker_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Poker_r2.Text);
            }
            if (gracz2Szansa_r2.Text != "" && gracz2Szansa_r2.Text != "x")
            {
                wynikKoniec2_r2 += Int32.Parse(gracz2Szansa_r2.Text);
            }
        }

        public void liczenie1_r3()
        {
            wynikKoniec1_r3 = 0;
            //if (gracz1_1_r3.Text != "" && gracz1_1_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_1_r3.Text);
            //}
            //if (gracz1_2_r3.Text != "" && gracz1_2_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_2_r3.Text);
            //}
            //if (gracz1_3_r3.Text != "" && gracz1_3_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_3_r3.Text);
            //}
            //if (gracz1_4_r3.Text != "" && gracz1_4_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_4_r3.Text);
            //}
            //if (gracz1_5_r3.Text != "" && gracz1_5_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_5_r3.Text);
            //}
            //if (gracz1_6_r3.Text != "" && gracz1_6_r3.Text != "x")
            //{
            //    wynikKoniec1_r3 += Int32.Parse(gracz1_6_r3.Text);
            //}
            if (gracz1Jedna_r3.Text != "" && gracz1Jedna_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Jedna_r3.Text);
            }
            if (gracz1Dwie_r3.Text != "" && gracz1Dwie_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Dwie_r3.Text);
            }
            if (gracz1Trojka_r3.Text != "" && gracz1Trojka_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Trojka_r3.Text);
            }
            if (gracz1Maly_r3.Text != "" && gracz1Maly_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Maly_r3.Text);
            }
            if (gracz1Duzy_r3.Text != "" && gracz1Duzy_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Duzy_r3.Text);
            }
            if (gracz1Full_r3.Text != "" && gracz1Full_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Full_r3.Text);
            }
            if (gracz1Kareta_r3.Text != "" && gracz1Kareta_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Kareta_r3.Text);
            }
            if (gracz1Poker_r3.Text != "" && gracz1Poker_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Poker_r3.Text);
            }
            if (gracz1Szansa_r3.Text != "" && gracz1Szansa_r3.Text != "x")
            {
                wynikKoniec1_r3 += Int32.Parse(gracz1Szansa_r3.Text);
            }
        }
        public void liczenie2_r3()
        {
            wynikKoniec2_r3 = 0;
            //if (gracz2_1_r3.Text != "" && gracz2_1_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_1_r3.Text);
            //}
            //if (gracz2_2_r3.Text != "" && gracz2_2_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_2_r3.Text);
            //}
            //if (gracz2_3_r3.Text != "" && gracz2_3_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_3_r3.Text);
            //}
            //if (gracz2_4_r3.Text != "" && gracz2_4_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_4_r3.Text);
            //}
            //if (gracz2_5_r3.Text != "" && gracz2_5_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_5_r3.Text);
            //}
            //if (gracz2_6_r3.Text != "" && gracz2_6_r3.Text != "x")
            //{
            //    wynikKoniec2_r3 += Int32.Parse(gracz2_6_r3.Text);
            //}
            if (gracz2Jedna_r3.Text != "" && gracz2Jedna_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Jedna_r3.Text);
            }
            if (gracz2Dwie_r3.Text != "" && gracz2Dwie_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Dwie_r3.Text);
            }
            if (gracz2Trojka_r3.Text != "" && gracz2Trojka_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Trojka_r3.Text);
            }
            if (gracz2Maly_r3.Text != "" && gracz2Maly_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Maly_r3.Text);
            }
            if (gracz2Duzy_r3.Text != "" && gracz2Duzy_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Duzy_r3.Text);
            }
            if (gracz2Full_r3.Text != "" && gracz2Full_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Full_r3.Text);
            }
            if (gracz2Kareta_r3.Text != "" && gracz2Kareta_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Kareta_r3.Text);
            }
            if (gracz2Poker_r3.Text != "" && gracz2Poker_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Poker_r3.Text);
            }
            if (gracz2Szansa_r3.Text != "" && gracz2Szansa_r3.Text != "x")
            {
                wynikKoniec2_r3 += Int32.Parse(gracz2Szansa_r3.Text);
            }
        }
        #endregion

        #region menuStrip
        //NOWA GRA
        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyscLabele();
            kasowanieRadioCheck();
            gracz = 1;
            wynikKoniec1 = 0;
            wynikKoniec2 = 0;
            wynikSzkola1 = 0;
            wynikSzkola2 = 0;
            iloscRzutow = 0;
            wymusWybor = false;
            lbl_dice1.Image = Properties.Resources.dice_blank;
            lbl_dice2.Image = Properties.Resources.dice_blank;
            lbl_dice3.Image = Properties.Resources.dice_blank;
            lbl_dice4.Image = Properties.Resources.dice_blank;
            lbl_dice5.Image = Properties.Resources.dice_blank;
        }
        //ZAKOŃCZ
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        public void czyscLabele()
        {
            //Gracz 1 r1
            gracz1_1.Text = "";
            gracz1_2.Text = "";
            gracz1_3.Text = "";
            gracz1_4.Text = "";
            gracz1_5.Text = "";
            gracz1_6.Text = "";
            gracz1Jedna.Text = "";
            gracz1Dwie.Text = "";
            gracz1Trojka.Text = "";
            gracz1Maly.Text = "";
            gracz1Duzy.Text = "";
            gracz1Full.Text = "";
            gracz1Kareta.Text = "";
            gracz1Poker.Text = "";
            gracz1Szansa.Text = "";
            gracz1Suma.Text = "";
            sumaSzkola1.Text = "";
            //Gracz 2 r1
            gracz2_1.Text = "";
            gracz2_2.Text = "";
            gracz2_3.Text = "";
            gracz2_4.Text = "";
            gracz2_5.Text = "";
            gracz2_6.Text = "";
            gracz2Jedna.Text = "";
            gracz2Dwie.Text = "";
            gracz2Trojka.Text = "";
            gracz2Maly.Text = "";
            gracz2Duzy.Text = "";
            gracz2Full.Text = "";
            gracz2Kareta.Text = "";
            gracz2Poker.Text = "";
            gracz2Szansa.Text = "";
            gracz2Suma.Text = "";
            sumaSzkola2.Text = "";

            //Gracz 1 r2
            gracz1_1_r2.Text = "";
            gracz1_2_r2.Text = "";
            gracz1_3_r2.Text = "";
            gracz1_4_r2.Text = "";
            gracz1_5_r2.Text = "";
            gracz1_6_r2.Text = "";
            gracz1Jedna_r2.Text = "";
            gracz1Dwie_r2.Text = "";
            gracz1Trojka_r2.Text = "";
            gracz1Maly_r2.Text = "";
            gracz1Duzy_r2.Text = "";
            gracz1Full_r2.Text = "";
            gracz1Kareta_r2.Text = "";
            gracz1Poker_r2.Text = "";
            gracz1Szansa_r2.Text = "";
            gracz1Suma_r2.Text = "";
            sumaSzkola1_r2.Text = "";

            //Gracz 2 r2
            gracz2_1_r2.Text = "";
            gracz2_2_r2.Text = "";
            gracz2_3_r2.Text = "";
            gracz2_4_r2.Text = "";
            gracz2_5_r2.Text = "";
            gracz2_6_r2.Text = "";
            gracz2Jedna_r2.Text = "";
            gracz2Dwie_r2.Text = "";
            gracz2Trojka_r2.Text = "";
            gracz2Maly_r2.Text = "";
            gracz2Duzy_r2.Text = "";
            gracz2Full_r2.Text = "";
            gracz2Kareta_r2.Text = "";
            gracz2Poker_r2.Text = "";
            gracz2Szansa_r2.Text = "";
            gracz2Suma_r2.Text = "";
            sumaSzkola2_r2.Text = "";

            //Gracz 1 r3
            gracz1_1_r3.Text = "";
            gracz1_2_r3.Text = "";
            gracz1_3_r3.Text = "";
            gracz1_4_r3.Text = "";
            gracz1_5_r3.Text = "";
            gracz1_6_r3.Text = "";
            gracz1Jedna_r3.Text = "";
            gracz1Dwie_r3.Text = "";
            gracz1Trojka_r3.Text = "";
            gracz1Maly_r3.Text = "";
            gracz1Duzy_r3.Text = "";
            gracz1Full_r3.Text = "";
            gracz1Kareta_r3.Text = "";
            gracz1Poker_r3.Text = "";
            gracz1Szansa_r3.Text = "";
            gracz1Suma_r3.Text = "";
            sumaSzkola1_r3.Text = "";

            //Gracz 2 r3
            gracz2_1_r3.Text = "";
            gracz2_2_r3.Text = "";
            gracz2_3_r3.Text = "";
            gracz2_4_r3.Text = "";
            gracz2_5_r3.Text = "";
            gracz2_6_r3.Text = "";
            gracz2Jedna_r3.Text = "";
            gracz2Dwie_r3.Text = "";
            gracz2Trojka_r3.Text = "";
            gracz2Maly_r3.Text = "";
            gracz2Duzy_r3.Text = "";
            gracz2Full_r3.Text = "";
            gracz2Kareta_r3.Text = "";
            gracz2Poker_r3.Text = "";
            gracz2Szansa_r3.Text = "";
            gracz2Suma_r3.Text = "";
            sumaSzkola2_r3.Text = "";

            //gora labele
            gracz2_label.BackColor = Color.ForestGreen;
            gracz1_label.BackColor = Color.ForestGreen;

            gracz2_label_r2.BackColor = Color.Firebrick;
            gracz1_label_r2.BackColor = Color.Firebrick;

            gracz2_label_r3.BackColor = Color.LightSeaGreen;
            gracz1_label_r3.BackColor = Color.LightSeaGreen;

            iloscRzutowLabel.Text = "Rzut: 0";
            warunekLabel.Text = "";
            ktoryGraczLabel.Text = "Gracz 1";
            runda = 1;
            trzeciaRunda = 0;
            posredniWynik1 = 0;
            posredniWynik2 = 0;
            posredniWynik3 = 0;
            posredniWynik4 = 0;
            posredniWynik5 = 0;
            posredniWynik6 = 0;
            ostatniWynik1 = 0; 
            ostatniWynik2 = 0;
            wynikSzkola1 = 0;
            wynikSzkola1_r2 = 0;
            wynikSzkola1_r3 = 0;
            wynikSzkola2 = 0;
            wynikSzkola2_r2 = 0;
            wynikSzkola2_r3 = 0;
            wynikKoniec1 = 0;
            wynikKoniec1_r2 = 0;
            wynikKoniec1_r3 = 0;
            wynikKoniec2 = 0;
            wynikKoniec2_r2 = 0;
            wynikKoniec2_r3 = 0;
        }
        public void dla1()
        {
            gracz1_1.Text = "1";
            gracz1_2.Text = "2";
            gracz1_3.Text = "3";
            gracz1_4.Text = "x";
            gracz1_5.Text = "x";
            gracz1_6.Text = "x";
            gracz1Jedna.Text = "x";
            gracz1Dwie.Text = "x";
            gracz1Trojka.Text = "x";
            gracz1Maly.Text = "15";
            gracz1Duzy.Text = "x";
            gracz1Full.Text = "x";
            gracz1Kareta.Text = "4";
            gracz1Poker.Text = "x";
            gracz1Szansa.Text = "1";
            gracz1Suma.Text = "";
            sumaSzkola1.Text = "6";
            wynikKoniec1 = 26;
            wynikSzkola1 = 6;
            wykluczanieGracz1();
        }
        public void dla2()
        {
            gracz2_1.Text = "x";
            gracz2_2.Text = "x";
            gracz2_3.Text = "x";
            gracz2_4.Text = "x";
            gracz2_5.Text = "x";
            gracz2_6.Text = "-6";
            gracz2Jedna.Text = "4";
            gracz2Dwie.Text = "18";
            gracz2Trojka.Text = "x";
            gracz2Maly.Text = "x";
            gracz2Duzy.Text = "x";
            gracz2Full.Text = "x";
            gracz2Kareta.Text = "x";
            gracz2Poker.Text = "x";
            gracz2Szansa.Text = "1";
            gracz2Suma.Text = "";
            sumaSzkola2.Text = "-6";
            wynikSzkola2 = -6;
        }

        public void dla1_r2()
        {
            gracz1_1_r2.Text = "1";
            gracz1_2_r2.Text = "2";
            gracz1_3_r2.Text = "3";
            gracz1_4_r2.Text = "x";
            gracz1_5_r2.Text = "x";
            gracz1_6_r2.Text = "x";
            gracz1Jedna_r2.Text = "x";
            gracz1Dwie_r2.Text = "x";
            gracz1Trojka_r2.Text = "x";
            gracz1Maly_r2.Text = "15";
            gracz1Duzy_r2.Text = "x";
            gracz1Full_r2.Text = "x";
            gracz1Kareta_r2.Text = "4";
            gracz1Poker_r2.Text = "x";
            gracz1Szansa_r2.Text = "";
            gracz1Suma_r2.Text = "";
            sumaSzkola1_r2.Text = "6";
            wynikKoniec1_r2 = 25;
            wynikSzkola1_r2 = 6;
            wykluczanieGracz1_r2();
        }
        public void dla2_r2()
        {
            gracz2_1_r2.Text = "x";
            gracz2_2_r2.Text = "x";
            gracz2_3_r2.Text = "x";
            gracz2_4_r2.Text = "x";
            gracz2_5_r2.Text = "x";
            gracz2_6_r2.Text = "-6";
            gracz2Jedna_r2.Text = "4";
            gracz2Dwie_r2.Text = "18";
            gracz2Trojka_r2.Text = "x";
            gracz2Maly_r2.Text = "x";
            gracz2Duzy_r2.Text = "x";
            gracz2Full_r2.Text = "x";
            gracz2Kareta_r2.Text = "x";
            gracz2Poker_r2.Text = "x";
            gracz2Szansa_r2.Text = "";
            gracz2Suma_r2.Text = "";
            sumaSzkola2_r2.Text = "-6";
            wynikSzkola2_r2 = -6;
        }
        #endregion
    }
        
}
       