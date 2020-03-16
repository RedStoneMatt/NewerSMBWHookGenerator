using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerSMBWHookGenerator
{
    public partial class MapfileTool : Form
    {
        public MapfileTool()
        {
            InitializeComponent();
        }

        public long EU1ToEU2(long offs, bool reversed)
        {
			int isReversed = (reversed) ? -1 : 1;
            if(offs >= 0x800CF6E8 && offs <= 0x800CF90F) {
                return offs + (8 * isReversed);
            }
            if (offs >= 0x807685A0 && offs <= 0x807AAA70)
            {
                return offs + (0x40 * isReversed);
            }
            if(offs >= 0x807AAA74 && offs <= 0x809907FF) {
                return offs + (0x10 * isReversed);
			}
            if(offs >= 0x80990800)
            {
                return offs + (0x20 * isReversed);
			}
            return offs;
        }
        public long EU1ToUS1(long offs, bool reversed)
		{
			int isReversed = (reversed) ? -1 : 1;
			// .text section
			if (offs >= 0x800B4604 && offs <= 0x800C8E4C)
			{
				return offs - (0x50 * isReversed);
			}
			if (offs >= 0x800C8E50 && offs <= 0x800E4D70)
			{
				return offs - (0xF0 * isReversed);
			}
			if (offs >= 0x800E4EC0 && offs <= 0x8010F200)
			{
				return offs - (0x110 * isReversed);
			}
			if (offs >= 0x8010F430 && offs <= 0x802BB6BC)
			{
				return offs - (0x140 * isReversed);
			}
			if (offs >= 0x802BB6C0 && offs <= 0x802BB74C)
			{
				return offs - (0x150 * isReversed);
			}
			if (offs >= 0x802BB860 && offs <= 0x802BBBFC)
			{
				return offs - (0x260 * isReversed);
			}
			if (offs >= 0x802BBC90 && offs <= 0x802EDCC0)
			{
				return offs - (0x2F0 * isReversed);
			}
			// .ctors, .dtors, .rodata, part of .data section
			if (offs >= 0x802EDCE0 && offs <= 0x80317734)
			{
				return offs - (0x300 * isReversed);
			}
			// .data section
			if (offs >= 0x80317750 && offs <= 0x80322FE0)
			{
				return offs - (0x318 * isReversed);
			}
			if (offs >= 0x80323118 && offs <= 0x8032E77C)
			{
				return offs - (0x348 * isReversed);
			}
			if (offs >= 0x8032E780 && offs <= 0x8035197C)
			{
				return offs - (0x340 * isReversed);
			}
			// .sdata section, part of .sbss
			if (offs >= 0x80351980 && offs <= 0x80427E87)
			{
				return offs - (0x300 * isReversed);
			}
			// .sbss, .sdata2, .sbss2 sections
			if (offs >= 0x80427E88 && offs <= 0x80429563)
			{
				return offs - (0x310 * isReversed);
			}
			if (offs >= 0x80429564 && offs <= 0x80429D7F)
			{
				return offs - (0x2F8 * isReversed);
			}
			if (offs >= 0x80429D80 && offs <= 0x807684BF)
			{
				return offs - (0x2E0 * isReversed);
			}
			// part of d_basesNP, d_enemiesNP, d_en_bossNP
			if (offs >= 0x8098A43C)
			{
				return offs + (0x20 * isReversed);
			}
			return offs;
		}

		public long EU1ToUS2(long offs, bool reversed)
		{
			if (!reversed)
			{
				offs = EU1ToUS1(offs, false);
				if (offs >= 0x800CF5F8 && offs <= 0x800CF81F)
				{
					return offs + 8;
				}
				if (offs >= 0x807685A0 && offs <= 0x807AAA70)
				{
					return offs + 0x40;
				}
				if (offs >= 0x807AAA74 && offs <= 0x8099081C)
				{
					return offs + 0x10;
				}
				if (offs >= 0x80990820)
				{
					return offs + 0x20;
				}
				return offs;
			}
			if (reversed)
			{
				if (offs >= 0x800CF5F8 && offs <= 0x800CF81F)
				{
					return EU1ToUS1(offs - 8, true);
				}
				if (offs >= 0x807685A0 && offs <= 0x807AAA70)
				{
					return EU1ToUS1(offs - 0x40, true);
				}
				if (offs >= 0x807AAA74 && offs <= 0x8099081C)
				{
					return EU1ToUS1(offs - 0x10, true);
				}
				if (offs >= 0x80990820)
				{
					return EU1ToUS1(offs - 0x20, true);
				}
				return EU1ToUS1(offs, true);
			}
			return 0;
		}

		public long EU1ToJP1(long offs, bool reversed)
		{
			int isReversed = (reversed) ? -1 : 1;
			// .text section
			if (offs >= 0x800B4604 && offs <= 0x800B475C)
			{
				return offs - (0x50 * isReversed);
			}
			if (offs >= 0x800B4760 && offs <= 0x800C8DAC)
			{
				return offs - (0xD0 * isReversed);
			}
			if (offs >= 0x800C8E50 && offs <= 0x800E4D6C)
			{
				return offs - (0x170 * isReversed);
			}
			if (offs >= 0x800E4D94 && offs <= 0x800E4EB4)
			{
				return offs - (0x194 * isReversed);
			}
			if (offs >= 0x800E4EB8 && offs <= 0x8010F1D0)
			{
				return offs - (0x190 * isReversed);
			}
			if (offs >= 0x8010F430 && offs <= 0x802BB6BC)
			{
				return offs - (0x330 * isReversed);
			}
			if (offs >= 0x802BB6D0 && offs <= 0x802BB74C)
			{
				return offs - (0x340 * isReversed);
			}
			if (offs >= 0x802BB860 && offs <= 0x802BBBFC)
			{
				return offs - (0x450 * isReversed);
			}
			if (offs >= 0x802BBC90 && offs <= 0x802EDCC0)
			{
				return offs - (0x4E0 * isReversed);
			}
			// .ctors, .dtors, .rodata, part of .data section
			if (offs >= 0x802EDCE0 && offs <= 0x80317734)
			{
				return offs - (0x4E0 * isReversed);
			}
			// .data section
			if (offs >= 0x80317750 && offs <= 0x80322FDC)
			{
				return offs - (0x4F8 * isReversed);
			}
			if (offs >= 0x80323118 && offs <= 0x8035197C)
			{
				return offs - (0x5E0 * isReversed);
			}
			// .sdata, part of .sbss section
			if (offs >= 0x80351980 && offs <= 0x80427E5F)
			{
				return offs - (0x580 * isReversed);
			}
			if (offs >= 0x80427E88 && offs <= 0x8042954B)
			{
				return offs - (0x5A8 * isReversed);
			}
			if (offs >= 0x80429570 && offs <= 0x80429D7F)
			{
				return offs - (0x5C8 * isReversed);
			}
			// part of .sdata2, .sbss2 section
			if (offs >= 0x80429D80 && offs <= 0x807684BF)
			{ // end offset is right before d_profileNP header
				return offs - (0x5C0 * isReversed);
			}
			// d_profileNP && d_basesNP
			// "no change" gap ends at 8779ABC
			if (offs >= 0x80779C70 && offs <= 0x8078891F)
			{
				return offs - (0x130 * isReversed);
			}
			if (offs >= 0x80788AD0 && offs <= 0x80789EEF)
			{
				return offs - (0x260 * isReversed);
			}
			if (offs >= 0x80789F00 && offs <= 0x808D3B87)
			{
				return offs - (0x270 * isReversed);
			}
			if (offs >= 0x808D3BD4 && offs <= 0x808D3C1F)
			{
				return offs - (0x2B4 * isReversed);
			}
			if (offs >= 0x808D3C20 && offs <= 0x80940C47)
			{
				return offs - (0x2C0 * isReversed);
			}
			if (offs >= 0x80940F58 && offs <= 0x80943167)
			{
				return offs - (0x4E8 * isReversed);
			}
			if (offs >= 0x809431F8 && offs <= 0x8094329F)
			{
				return offs - (0x4F8 * isReversed);
			}
			if (offs >= 0x809432C0 && offs <= 0x80944E77)
			{
				return offs - (0x500 * isReversed);
			}
			if (offs >= 0x80945144 && offs <= 0x80945153)
			{
				return offs - (0x714 * isReversed);
			}
			if (offs >= 0x80945158 && offs <= 0x8098A36B)
			{
				return offs - (0x718 * isReversed);
			}
			if (offs >= 0x8098A478 && offs <= 0x8098FF18)
			{
				return offs - (0x6F8 * isReversed);
			}
			// d_enemiesNP
			// this offset starts at the .rel header
			if (offs >= 0x80990800 && offs <= 0xDEADBEEF)
			{
				return offs - (0x700 * isReversed);
			}
			//if(offs >= 0x8010F430 && offs <= 0xDEADBEEF) {
			//	return offs - 0x330;
			//if(offs >= 0x8010F430 && offs <= 0xDEADBEEF) {
			//	return offs - 0x330;
			return offs;
		}

		public long EU1ToJP2(long offs, bool reversed)
		{
			if (!reversed) { 
				offs = EU1ToJP1(offs, false);
				if (offs >= 0x800CF578 && offs <= 0x800CF79F)
				{
					return offs + 8;
				}
				if (offs >= 0x807685A0 && offs <= 0x807AA7FF)
				{
					return offs + 0x40;
				}
				if (offs >= 0x807AA800 && offs <= 0x809900FF)
				{
					return offs + 0x10;
				}
				if (offs >= 0x80990100)
				{
					return offs + 0x20;
				}
				return offs;
			}
			if(reversed)
			{
				if (offs >= 0x800CF578 && offs <= 0x800CF79F)
				{
					return EU1ToJP1(offs - 8, true);
				}
				if (offs >= 0x807685A0 && offs <= 0x807AA7FF)
				{
					return EU1ToJP1(offs - 0x40, true);
				}
				if (offs >= 0x807AA800 && offs <= 0x809900FF)
				{
					return EU1ToJP1(offs - 0x10, true);
				}
				if (offs >= 0x80990100)
				{
					return EU1ToJP1(offs - 0x20, true);
				}
				return EU1ToJP1(offs, true);
			}
			return 0;
		}

		private void MapfileTool_Load(object sender, EventArgs e)
        {
            inputRegion.SelectedIndex = 0;
            outputRegion.SelectedIndex = 0;
        }

        private void convertButton_Click(object sender, EventArgs e)
		{
			long input = Convert.ToInt64(inputTextBox.Text, 16);
			if (inputRegion.SelectedIndex == 0) //EUv1
			{
				if (outputRegion.SelectedIndex == 0) //EUv1
				{
					outputTextBox.Text = inputTextBox.Text;
				}
				if (outputRegion.SelectedIndex == 1) //EUv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToEU2(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 2) //USv1
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToUS1(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 3) //USv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToUS2(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 4) //JPv1
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToJP1(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 5) //JPv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToJP2(input, false), 16).ToUpper();
				}
			}
			else
			{
				/*************************/
				/*Converting back to EUv1*/
				/*************************/
				if (inputRegion.SelectedIndex == 1) //EUv2
				{
					input = EU1ToEU2(input, true);
				}
				if (inputRegion.SelectedIndex == 2) //USv1
				{
					input = EU1ToUS1(input, true);
				}
				if (inputRegion.SelectedIndex == 3) //USv2
				{
					input = EU1ToUS2(input, true);
				}
				if (inputRegion.SelectedIndex == 4) //JPv1
				{
					input = EU1ToJP1(input, true);
				}
				if (inputRegion.SelectedIndex == 5) //JPv2
				{
					input = EU1ToJP2(input, true);
				}
				/************************/
				/*EUv1 Normal Conversion*/
				/************************/
				if (outputRegion.SelectedIndex == 0) //EUv1
				{
					outputTextBox.Text = "0x" + Convert.ToString(input, 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 1) //EUv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToEU2(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 2) //USv1
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToUS1(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 3) //USv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToUS2(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 4) //JPv1
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToJP1(input, false), 16).ToUpper();
				}
				if (outputRegion.SelectedIndex == 5) //JPv2
				{
					outputTextBox.Text = "0x" + Convert.ToString(EU1ToJP2(input, false), 16).ToUpper();
				}
			}
		}
    }
}
