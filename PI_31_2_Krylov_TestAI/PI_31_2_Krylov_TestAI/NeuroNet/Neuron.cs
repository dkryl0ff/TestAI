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

        //константы для функции активации(заменить под гиперболический тангенс)
        private double a = 1.00d;

        //Cвойства
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
            double sum = weights[0];

            for(int j = 0; j < inputs.Length; j++)
            {
                sum += inputs[j] * weights[j + 1];
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = Tanh(sum);
                    derivative = TanhDerivative(sum);
                    break;

                case NeuronType.Output:
                    output = Exp(sum);
                    break;
            }

            
            //обращение к функции активации также заменить под свою функцию активации для output все одинаковое

            //функция активации

            //производная
            
        }
        private double Tanh(double x)
        {
            return Tanh(a * x);
        }

        // Производная гиперболического тангенса
        private double TanhDerivative(double output)
        {
            return a * (1 - output * output);
        }
    }
}
