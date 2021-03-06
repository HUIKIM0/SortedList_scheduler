using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //SortedList : Dictionry와 사용법 같음 <key,value>. ★key값을 기준으로 정렬해서 넣어준다!!
        SortedList<DateTime, string> slScheduler = new SortedList<DateTime, string>();

        //Dictionary<DateTime, string> dScheduler = new Dictionary<DateTime, string>();


        public Form1()
        {
            InitializeComponent();
        }


        // 캘린더 날짜 선택 -> tbox에 일정 입력 -> '일정 등록' 클릭 시 lbox에 날짜와 일정 뜨기
        // 단 날짜 순으로 정렬되게 -> SortedList
        private void btnScheduler_Click(object sender, EventArgs e)
        {
            DateTime dtSelect = mcScheduler.SelectionStart; //선택한 날짜 가져옴. 시간은 12:00로 고정


            if (!slScheduler.ContainsKey(dtSelect)) //SortedList에 선택 날짜가 없으면(처음으로 정보 입력)
            { 
                slScheduler.Add(dtSelect, tboxScheduler.Text);  //선택날짜(Datetime)랑 입력테스트(string) Add


                if (slScheduler.ContainsValue(""))
                {
                    MessageBox.Show("일정을 입력해주세요");
                    slScheduler.Remove(dtSelect);
                }


                mcScheduler.AddBoldedDate(dtSelect);
                mcScheduler.UpdateBoldedDates();


                lboxScheduler.Items.Add(string.Format("{0} : {1}", dtSelect.ToString(), tboxScheduler.Text));
      
            }


            lboxScheduler.Items.Clear();  //중복으로 찍히는거 방지


            foreach (KeyValuePair<DateTime, string> oitem in slScheduler)
            {
                lboxScheduler.Items.Add(string.Format("{0} : {1}", oitem.Key.ToString("yyyy-MM-dd"), oitem.Value));
            }

        }


        // 날짜 선택 -> 해당 날짜에 일정이 있으면 tbox에 일정내용 보여줌
        private void mcScheduler_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dtSelect = mcScheduler.SelectionStart;

            if (slScheduler.ContainsKey(dtSelect))
            {
                tboxScheduler.Text = slScheduler[dtSelect];
            }
            else
            {
                tboxScheduler.Text = string.Empty;
            }
        }

        //ListBox의 항목 선택하면 -> 선택한 항목의 SortedList<Key,Value> 삭제됨.
        private void btnRemove_Click(object sender, EventArgs e)
        {  
            int iRemoveData = lboxScheduler.SelectedIndex;       //ListBox 선택한 index값
            DateTime dtRemoveData = mcScheduler.SelectionStart;


            try
            {

                //if (slScheduler.ContainsKey(dtRemoveData).Equals(iRemoveData))         //SortedList.RemoveAt 전에 달력 Bold처리 삭제
                //{
                //    mcScheduler.RemoveBoldedDate(dtRemoveData);
                //    mcScheduler.UpdateBoldedDates();
                //}

                slScheduler.RemoveAt(iRemoveData);
            }
            catch (Exception)
            {

                MessageBox.Show("오른쪽 ListBox의 항목을 선택하여 일정을 삭제해주세요");
            }

                     
            lboxScheduler.Items.Clear();

            foreach (KeyValuePair<DateTime, string> oitem in slScheduler)
            {
                lboxScheduler.Items.Add(string.Format("{0} : {1}", oitem.Key.ToString("yyyy-MM-dd"), oitem.Value));
            }


        }
    }
}
