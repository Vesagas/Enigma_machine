using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Enigma_machine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {


//        //            Orig keyboard


// lbl_one;
 
// lbl_two;
 
//lbl_three;

// lbl_four;

// lbl_five;

// lbl_six;

// lbl_seven;

// lbl_eight;

//lbl_nine;

// lbl_zero;
 
// lbl_minus;

//lbl_equals;

//lbl_plus;

//lbl_eraser;

//lbl_tab;

// lbl_q;
 
//lbl_w;
 
//lbl_e;
 
//lbl_r;

// lbl_t

// lbl_y;


//lbl_u;


//lbl_i;

//lbl_o;

// lbl_p;

//   lbl_bracket;
//lbl_cbracket;

//lbl_bslash;

//lbl_Caps;

//lbl_A;
 
// lbl_s;
 
//lbl_d;

// lbl_f;

// lbl_g;

// lbl_h;

// lbl_j;

// lbl_k;

// lbl_l;

//  lbl_semicolon;
 
//lbl_quotation;

//lbl_less;
 
//lbl_greaterthan;
 

//lbl_enter;
 
// lbl_shift;
 
//lbl_z;

// lbl_x;

// lbl_c;
 
//lbl_v;

// lbl_b;

// lbl_n;

// lbl_m;
 
// lbl_coma;

// lbl_period;

// lbl_fslash;

//lbl_mark;
//lbl__shift2;

// lbl_53;


//        //topKeyboard

//        lbl_39;

//       lbl__Copy34;

//         lbl__Copy40;

//       lbl__Copy35;

//        lbl__Copy36;

//       lbl__Copy30;

//        lbl__Copy31;

//      lbl__Copy33;

//    lbl__Copy32;

//        lbl__Copy48;

//         lbl__Copy45;

//        lbl__Copy54;

//     lbl__Copy46;

//      lbl__Copy47;

//        lbl__Copy41;

//   lbl__Copy42;

//      lbl__Copy44;

//        lbl__Copy43;

//       lbl__Copy7;

//        lbl__Copy4;

//         lbl__Copy8;

//        lbl__Copy5;

//         lbl__Copy6;

//         lbl_xx;

//         lbl__Copy1;

//        lbl__Copy3;

//         lbl_mark2;
//        lbl_bracket2;


//        lbl_cbracket2;

//         lbl_1;

//         lbl_2;

//        lbl_3;

//         lbl_4;

//        lbl_5;

//        lbl_6;

//        lbl_7;

//        lbl_8;

//       lbl_9;

//        lbl_0;

//        lbl_underscr;

//       lbl_add;

//        lbl_curl;

//        lbl_ccurl;

//         lbl_1;
//         lbl_quot;

//        lbl_lessthan;

//       lbl_Greaterthan1;

//        lbl_one_1;

//        lbl_two_2;


//        lbl_three_3;

//        lbl_four_4;

//        lbl_five_5;

//        lbl_six_6;

//       lbl_seven_7;

//        lbl_eight_8;

//        lbl_nine_9;

//         lbl_zero_0;



//            //Buttons

//            btnPlusSeconds1;
//        btnMinusSeconds1;

//        btnPlusMinutes1;
//         btnMinusMinutes1;
//         btnPlusHours1;
//         btnMinusHours1;

//         btn_Seconds2;
//         btnMinusSeconds2;
//         btnPlusMinutes2;
//       btnMinusMinutes2;
//         btnPlusSeconds2;
//      btnMinusHours2;
//       btn_openfile;
//     btn_rotoron;

//            //TextBox
//             tbx_location;
//            tbx_input;
//             tbx_encrypted;
//           lblSelectionSecondsCounter1;
//  lblSelectionMinutesCounter1;
//  lblSelectionHoursCounter1;

//                lblSelectionSecondsCounter2;
      
//                lblSelectionMinutesCounter2;
        
//                lblSelectionHoursCounter2;

            InitializeComponent();

            //keyLabels[0] = lbl_1;
            //keyLabels[1] = lbl_2;
            //keyLabels[2] = lbl_3;
            //keyLabels[3] = lbl_4;
            //keyLabels[4] = lbl_5;
            //keyLabels[5] = lbl_6;
            //keyLabels[6] = lbl_7;
            //keyLabels[7] = lbl_8;
            //keyLabels[8] = lbl_9;
            //keyLabels[9] = lbl_0;
            //keyLabels[10] = lbl11;
            //keyLabels[11] = lbl12;
            //keyLabels[12] = lbl13;
            //keyLabels[13] = lbl14;
            //keyLabels[14] = lbl15;
            //keyLabels[15] = lbl16;
            //keyLabels[16] = lbl17;
            //keyLabels[17] = lbl18;
            //keyLabels[18] = lbl19;
            //keyLabels[19] = lbl20;
            //keyLabels[20] = lbl21;
            //keyLabels[21] = lbl22;
            //keyLabels[22] = lbl23;
            //keyLabels[23] = lbl24;
            //keyLabels[24] = lbl25;
            //keyLabels[25] = lbl26;
            //keyLabels[26] = lbl27;
            //keyLabels[27] = lbl28;
            //keyLabels[28] = lbl29;
            //keyLabels[29] = lbl30;
            //keyLabels[30] = lbl31;
            //keyLabels[31] = lbl32;
            //keyLabels[32] = lbl33;
            //keyLabels[33] = lbl34;
            //keyLabels[34] = lbl35;
            //keyLabels[35] = lbl36;
            //keyLabels[36] = lbl37;
            //keyLabels[37] = lbl38;
            //keyLabels[38] = lbl39;
            //keyLabels[39] = lbl40;
            //keyLabels[40] = lbl41;
            //keyLabels[41] = lbl42;
            //keyLabels[42] = lbl43;
            //keyLabels[43] = lbl44;
            //keyLabels[44] = lbl45;
            //keyLabels[45] = lbl46;
            //keyLabels[46] = lbl47;
            //keyLabels[47] = lbl48;
            //keyLabels[48] = lbl49;
            //keyLabels[49] = lbl50;
            //keyLabels[50] = lbl51;
            //keyLabels[51] = lbl52;
            //keyLabels[52] = lbl53;
            //keyLabels[53] = lbl54;
            //keyLabels[54] = lbl55;
            //keyLabels[55] = lbl56;
            //keyLabels[56] = lbl57;
            //keyLabels[57] = lbl58;
            //keyLabels[58] = lbl59;
            //keyLabels[59] = lbl60;
            //keyLabels[60] = lbl61;
            //keyLabels[61] = lbl62;
            //keyLabels[62] = lbl63;
            //keyLabels[63] = lbl64;
            //keyLabels[64] = lbl65;
            //keyLabels[65] = lbl_underscr;
            //keyLabels[66] = lbl_add;
            //keyLabels[67] = lbl68;
            //keyLabels[68] = lbl69;
            //keyLabels[69] = lbl_;
            //keyLabels[70] = lbl_less;
            //keyLabels[71] = lbl_curl;
            //keyLabels[72] = lbl_ccurl;
            //keyLabels[73] = lbl_bar;
            //keyLabels[74] = lbl_semicolon;
            //keyLabels[75] = lbl_11;
            //keyLabels[76] = lbl_coma;
            //keyLabels[77] = lbl_period;
            //keyLabels[78] = lbl_bslash;
            //keyLabels[79] = lbl_lessthan;
            //keyLabels[80] = lbl_greaterthan;
            //keyLabels[81] = lbl82;
            //keyLabels[82] = lbl83;
            //keyLabels[83] = lbl84;
            //keyLabels[84] = lbl85;
            //keyLabels[85] = lbl86;
            //keyLabels[86] = lbl87;
            //keyLabels[87] = lbl88;
            //keyLabels[88] = lbl89;
            //keyLabels[89] = lbl90;
            //keyLabels[90] = lbl_0;

        }

        void updateDisplayCount()
        {
            lblSelectionSecondsCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[0]);
            lblSelectionMinutesCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[1]);
            lblSelectionHoursCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[2]);

            lblSelectionSecondsCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[0]);
            lblSelectionMinutesCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[1]);
            lblSelectionHoursCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[2]);
        }

        void ringSelectorChecker()
        {
            if (EnigmaClass.ringSelection[0] == EnigmaClass.ringSelection[1] || EnigmaClass.ringSelection[1] == EnigmaClass.ringSelection[2] || EnigmaClass.ringSelection[0] == EnigmaClass.ringSelection[2])
            {
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btn_Hours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btn_set.IsEnabled = false;
            }
            else
            {
                btnPlusSeconds2.IsEnabled = true;
                btnPlusMinutes2.IsEnabled = true;
                btn_Hours2.IsEnabled = true;
                btnMinusSeconds2.IsEnabled = true;
                btnMinusMinutes2.IsEnabled = true;
                btnMinusHours2.IsEnabled = true;
                btn_set.IsEnabled = true;
            }
        }

        
           
    }
}
