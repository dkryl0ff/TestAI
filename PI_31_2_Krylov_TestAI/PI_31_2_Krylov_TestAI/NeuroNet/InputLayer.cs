using System;
using System.IO;

namespace PI_31_2_Krylov_TestAI.NeuroNet
{
    class InputLayer
    {
        private double[,] trainset;//100 изображений в обучающей выборке
        private double[,] testset;//10 изображений в тестовой выборке

        public double[,] Trainset { get => trainset; }
        public double[,] Testset { get => testset; }

        public InputLayer(NetworkMode nm)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string[] tmpArrStr;
            string[] tmpStr;

            switch (nm)
            {
                case NetworkMode.Train:
                    tmpArrStr = File.ReadAllLines(path + "train.txt");//считывание из файла обуч выборки
                    trainset = new double[tmpArrStr.Length, 16];//массив обучающей выборки
                    
                    for(int i = 0; i < tmpArrStr.Length; i++)//перебор строк обучающей выборки
                    {
                        tmpStr = tmpArrStr[i].Split(' ');
                        for(int j =0; j < 16; j++)
                        {
                            trainset[i, j] = double.Parse(tmpStr[j]);
                        }
                    }
                    Shuffling_Array_Rows(trainset); //перетасовка
                    break;

                case NetworkMode.Test:
                    tmpArrStr = File.ReadAllLines(path + "test.txt");//считывание из файла обуч выборки
                    testset = new double[tmpArrStr.Length, 16];//массив обучающей выборки

                    for (int i = 0; i < tmpArrStr.Length; i++)//перебор строк обучающей выборки
                    {
                        tmpStr = tmpArrStr[i].Split(' ');
                        for (int j = 0; j < 16; j++)
                        {
                            testset[i, j] = double.Parse(tmpStr[j]);
                        }
                    }
                    Shuffling_Array_Rows(testset); //перетасовка
                    break;
            }
        }

        //перетасовка методом Фишера-Йетса 
        public void Shuffling_Array_Rows(double[,] arr)
        {
            int rowCount = arr.GetLength(0);
            int colCount = arr.GetLength(1);
            Random random = new Random();

            // Проходим по всем строкам, кроме последней
            for (int i = rowCount - 1; i > 0; i--)
            {
                // Генерируем случайный индекс от 0 до i
                int j = random.Next(i + 1);

                // Меняем местами строки i и j
                for (int k = 0; k < colCount; k++)
                {
                    double temp = arr[i, k];
                    arr[i, k] = arr[j, k];
                    arr[j, k] = temp;
                }
            }

        }
    }
}
