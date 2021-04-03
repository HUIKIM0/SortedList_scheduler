using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Detail
{
    public partial class Form1 : Form
    {

        List<object> oList = new List<object>();  // Main으로 사용할 object List


        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        private void tboxDataInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lboxList.Text == tboxDataInsert.Text)   // 동일한 text -> 삭제
            {
                oList.Remove(tboxDataInsert.Text);
            }

            else if (numPosition.Value == -1)
            {
                oList.Remove(tboxDataInsert.Text);  //Remove -> List 내의 해당내용★ 삭제
            }

            else
            {
                oList.RemoveAt((int)numPosition.Value);  //RemoveAt -> List내의 해당 index삭제★
            }

            lboxList.DataSource = oList.ToList<object>();
            lboxNoCreate();
            oList_Detail();



        }


        // 변경대상값 입력 후 변경하길 원하는 문자로 입력 ->버튼클릭
        private void btnChange_Click(object sender, EventArgs e)
        {
            List<object> ListChange = new List<object>();  //바뀐 oList값을 담을
            ListChange = oList.ConvertAll<object>(s => s.ToString().Replace(tboxChangeOld.Text, tboxChangeNew.Text));   // List의 값을 변경 해서 새로운 List를 만듬

            
            lboxChangeList.DataSource = ListChange.ToList<object>();  
            oChangeList_Data(ListChange); 

        }



        // 값 추가 함수
        private void DataAdd()
        {
            
            if(numPosition.Value == -1)  // -1은 배열에 존재하지 않는 포지션(사용자가 indext 선택 안한거)
            {
                oList.Add(tboxDataInsert.Text);  // List 끝에 값 추가
            }
            else
            {
                oList.Insert((int)numPosition.Value, tboxDataInsert.Text);  // List의 해당 index에, text내용 넣기 
            }
            

            lboxList.DataSource = oList.ToList<object>(); // .DataSource ->데이터값 전부 .ToList ->반복문 안쓰고 list대입(복사)

            lboxNoCreate();
            oList_Detail();

            tboxDataInsert.Text = "";
        }


        // lboxNo (index위치) 보여주기 위한 함수
        private void lboxNoCreate()
        {
            List<int> iList = (Enumerable.Repeat(0, oList.Count)).ToList<int>();   // List를 선언 하면서 초기화


            for (int i =0; i < iList.Count; i++)
            {
                iList[i] = i;
            }
            lboxNo.DataSource = iList.ToList<int>();
        }


        //tbox에 찍어줄 List에 대한 detail 내용
        private void oList_Detail()
        {
            tboxDetail.Text = null;

            int oListCount = oList.Count;   //항목개수
            int oListCapacity = oList.Capacity; //메모리 할당크기
            string oListstrData = string.Join(", ", oList);   // List안 요소를 stirng 문자열로 변경

            //StringBuilder sb = new StringBuilder();
            //sb.Append("List 개수 : " + oListCount +"\r\n");
            //tboxDetail.Text = sb.ToString();

            // string strDetail = string.Format("List 개수 : {0}", oListCount); 

            string strListDetail = $@"
List 개수 : {oListCount}
메모리 할당크기 : {oListCapacity}
Data : {oListstrData}
";

            tboxDetail.Text = strListDetail;

        }



        // 수정 List_Detail tbox. 원본
        private void oChangeList_Data(List<object> oChangeList)
        {
            tboxDetail_Change.Text = null;

            int iListCount = oChangeList.Count;
            int ilistCapacity = oChangeList.Capacity;
            string strListData = string.Join(", ", oChangeList);

            //List<object> oTEST = oChangeList.GetRange(3, 2);      // List에서 해당 위치에서 지정 범위의 값을 추출
            //oChangeList.Sort();          // List 정렬

            string strListDetail = $@"
    Capacity : {ilistCapacity}
    Count : {iListCount}
    Data : {strListData}
    ";

            tboxDetail_Change.Text = strListDetail;



        }


    }
}
