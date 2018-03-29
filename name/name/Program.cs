using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            //列出各種資料
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] girls = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] z = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            double countA = 0;
            double countB = 0;
            double countO = 0;
            double countAB = 0;
            int sumG = 0;//女生總合
            int countG = 0;
            int sumB = 0;//男生總合
            int countb = 0;
            int sum = 0;
            int countpp = 0;




            for (int i = 0; i < blood.Length; i++)
            {


                if (blood[i] == "A")
                {
                    countA++;
                }
                if (blood[i] == "B")
                {
                    countB++;
                }
                if (blood[i] == "O")
                {
                    countO++;
                }
                if (blood[i] == "AB")
                {
                    countAB++;
                }
            }

            //計算百分比
            double precentA = (double)countA / (double)blood.Length * 100;
            double precentB = (double)countB / (double)blood.Length * 100;
            double precentO = (double)countO / (double)blood.Length * 100;
            double precentAB = (double)countAB / (double)blood.Length * 100;

            //列出每個東西
            Console.WriteLine("A型人數: {0} {1:0} %", countA, precentA);
            Console.WriteLine("B型人數: {0} {1:0} %", countB, precentB);
            Console.WriteLine("O型人數: {0} {1:0} %", countO, precentO);
            Console.WriteLine("AB型人數: {0} {1:0} %", countAB, precentAB);



            int max = -9999999;
            int min = 99999999;

            //迴圈跑過每一筆資料
            for (int t = 0; t < heights.Length; t++)
            {
                //過濾無效資料
                if (heights[t] > 100 && heights[t] < 200)
                {

                    //如果是女生
                    if (girls[t] == "女")
                    {
                        //累加
                        sumG = sumG + heights[t];
                        countG++;
                    }

                    //如果是男生
                    if (girls[t] == "男")
                    {
                        //累加
                        sumB = sumB + heights[t];
                        countb++;
                    }

                    //身高最大值最小值
                    if (heights[t] > max)
                    {
                        max = heights[t];
                    }
                    if (min > heights[t])
                    {
                        min = heights[t];
                    }
                    sum = sum + heights[t];

                }

            }


            //列出結果

            Console.WriteLine("女生平均身高:" + sumG / countG);
            Console.WriteLine("男生平均身高:" + sumB / countb);
            Console.WriteLine("全部平均身高:" + sum / heights.Length);
            Console.WriteLine("最高身高是:" + max);
            Console.WriteLine("最矮的身高是:" + min);




            //for (int m = 0; m < girls.Length; m++)
            {


                // if (girls[m] == "男")
                //{
                // countb += 1;
                // }

                // if (girls[m] == "女")
                // {
                //  countG += 1;
                // }
                // double precentb = (double)countb / (double)girls.Length * 100;
                //  double precentG = (double)countG / (double)girls.Length * 100;

                //列出人數
                //Console.WriteLine("男生人數:" + countb+"   "+precentb+" %");
                // Console.WriteLine("男生人數: {0} {1:0} %", countb, precentb);
                // Console.WriteLine("女生人數: " + countG+"   "+precentG+" %");
                // Console.WriteLine("女生人數: {0} {1:0} %", countG, precentG);


                // }
                Console.ReadLine();
            }
        }
    }
}



