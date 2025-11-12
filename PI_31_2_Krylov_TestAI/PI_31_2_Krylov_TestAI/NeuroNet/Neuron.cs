using static System.Math;

namespace PI_31_2_Krylov_TestAI.NeuroNet
{
    class Neuron
    {
        //поля
        private NeuronType type;
        private double[] weights;
        private double[] inputs;
        private double output;
        private double derivative;

        //константы для функции активации
        private double a = 1d;

        //Свойства
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }

        //конструктор
        public Neuron(double[] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        //метод активации нейрона
        public void Activator(double[] i)
        {
            inputs = i;
            double sum = weights[0]; // bias weight

            for (int j = 0; j < inputs.Length; j++)
            {
                sum += inputs[j] * weights[j + 1];
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = Tanh(sum);
                    derivative = TanhDerivative(output); // Исправлено: передаем output, а не sum
                    break;

                case NeuronType.Output:
                    // Для выходного слоя лучше использовать Softmax (будет вычисляться на уровне слоя)
                    // Или сигмоиду для бинарной классификации
                    output = Exp(sum);
                    break;
            }
        }

        // Гиперболический тангенс
        private double Tanh(double x)
        {
            return System.Math.Tanh(a * x);
        }

        // Производная гиперболического тангенса
        private double TanhDerivative(double x)
        {
            return a * (1 - x * x);
        }
    }
}