﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityMetric.Entity
{
    public static class MyMatrix
    {

        private static int columnFactValue;
        private static int rownFactValue;

        private static int columnPredict;
        private static int rownPredict;

        public static int[,] fact_value;
        public static int[,] predict;

        public static int ColumnFactValue { get => columnFactValue; set => columnFactValue = value; }
        public static int RownFactValue { get => rownFactValue; set => rownFactValue = value; }
        public static int ColumnPredict { get => columnPredict; set => columnPredict = value; }
        public static int RownPredict { get => rownPredict; set => rownPredict = value; }
       

        public static void ProverkaFactValue()
        {
            for(int i = 0; i < rownFactValue; i++)
            {
                for(int j = 0; j < columnFactValue; j++)
                {
                    if(fact_value[i,j] == 1 || fact_value[i,j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        throw new ArgumentException("Uncorrected value elements matrix");
                    }
                }
            }
        }

        public static void ProverkaPredict()
        {
            for (int i = 0; i < rownPredict; i++)
            {
                for (int j = 0; j < columnPredict; j++)
                {
                    if (predict[i, j] == 1 || predict[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        throw new ArgumentException("Uncorrected value elements matrix");
                    }
                }
            }
        }

        private static int countFalsePositive;//(predic = 1, fact_value = 0)
        private static int countTrueNegative;//(predict = 0, fact_value = 0)
        public static void NumberOfRatings() //метод принимающий два массива, и вычисляющий кол-во оценок
        {
            if ((ColumnFactValue != ColumnPredict) && (RownFactValue != RownPredict))
            {
                throw new ArgumentException("Array sizes not found");
            }

            for (int i = 0; i < rownFactValue; i++)
            {
                for (int j = 0; j < columnPredict; j++)
                {
                    if (predict[i, j] == 1 && fact_value[i, j] == 0)
                    {
                        countFalsePositive += 1;
                    }
                    else if (predict[i, j] == 0 && fact_value[i, j] == 0)
                    {
                        countTrueNegative += 1;
                    }
                }
            }
            
        }
        public static string PrintResult()
        {
            return $"Count False Positive: {countFalsePositive}\nCount True Negative: {countTrueNegative}";
        }
    }
}
